using Newtonsoft.Json.Linq;
using PayamGostarClient.Internals;
using System;
using System.Collections.Generic;
using System.Net;

namespace PayamGostarClient
{

    public class PgClientFactory : IPgClientFactory
    {
        private readonly IHttpClient _httpClient;

        public PgClientFactory(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public PgClientFactory() : this(new RestSharpHttpClient())
        {
        }

        public IPgClient Create(string serviceUrl, PgCredentials credentials)
        {
            var result = InternalAuthenticate(serviceUrl, credentials);

            switch (result.Status)
            {
                case PgAuthenticationStatus.Ok:
                    return new PgClient(serviceUrl, result.Ticket, _httpClient);

                case PgAuthenticationStatus.BadRequest:
                    throw new Exception($"Server responded with 400 (Bad Request)");

                case PgAuthenticationStatus.Unauthorized:
                    throw new InvalidCredentialsException();

                case PgAuthenticationStatus.Forbidden:
                    throw new Exception($"Server responded with 401 (User is locked out temporary)");

                default:
                case PgAuthenticationStatus.ServerError:
                    throw new InvalidOperationException("Server error.");
            }
        }

        public IPgClient Create(string serviceUrl, PgAuthenticationTicket ticket)
        {
            return new PgClient(serviceUrl, ticket, new RestSharpHttpClient());
        }

        public PgAuthenticationResult SignIn(string serviceUrl, PgCredentials credentials)
        {
            return InternalAuthenticate(serviceUrl, credentials);
        }

        private PgAuthenticationResult InternalAuthenticate(string serviceUrl, PgCredentials credentials)
        {
            if (serviceUrl == null)
                throw new ArgumentNullException(nameof(serviceUrl));

            serviceUrl = serviceUrl.TrimEnd('/');

            var parameters = new Dictionary<string, string>
            {
                { "username", credentials.Username },
                { "password", credentials.Password },
                { "grant_type", "password" }
            };

            var response = _httpClient.PostForm(serviceUrl, "/api/v1/auth", parameters);
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var ticket = CreateTicket(response.Content);
                    return new PgAuthenticationResult(ticket, PgAuthenticationStatus.Ok);

                case HttpStatusCode.Unauthorized:
                    return new PgAuthenticationResult(null, PgAuthenticationStatus.Unauthorized);

                case HttpStatusCode.Forbidden:
                    return new PgAuthenticationResult(null, PgAuthenticationStatus.Forbidden);

                case HttpStatusCode.InternalServerError:
                    return new PgAuthenticationResult(null, PgAuthenticationStatus.ServerError);

                case HttpStatusCode.BadRequest:
                    return new PgAuthenticationResult(null, PgAuthenticationStatus.BadRequest);

                default:
                    throw new Exception($"Server responded with error code {response.StatusCode}");
            }
        }

        private PgAuthenticationTicket CreateTicket(string jsonResponse)
        {
            var content = JObject.Parse(jsonResponse);
            var accessToken = content.Value<string>("access_token");
            var expiresInSeconds = content.Value<int>("expires_in");

            var expiresIn = DateTime.Now.AddSeconds(expiresInSeconds);

            return new PgAuthenticationTicket(accessToken, expiresIn);
        }

        public bool Test(string serviceUrl, PgAuthenticationTicket ticket)
        {
            return _httpClient.Test(serviceUrl, "/api", ticket);
        }
    }
}
