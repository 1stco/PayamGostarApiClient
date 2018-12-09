using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PayamGostarClient.Internals
{
    internal class RestSharpHttpClient : IHttpClient
    {
        public HttpResponse PostForm(string serviceUrl, string path, IDictionary<string, string> parameters)
        {
            var client = new RestClient(serviceUrl);
            var request = new RestRequest(path);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            var paramsBuilder = new StringBuilder();
            foreach (var kvp in parameters)
            {
                paramsBuilder.Append($"{kvp.Key}={kvp.Value}&");
            }

            request.AddParameter("undefined", paramsBuilder.ToString(), ParameterType.RequestBody);

            var response = client.Post(request);
            return new HttpResponse
            {
                StatusCode = response.StatusCode,
                Content = response.Content
            };
        }

        public TResponse PostJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class
        {
            var response = InternalPostJson(serviceUrl, path, ticket, model);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException($"Server responded with status {response.StatusCode}");

            return JsonConvert.DeserializeObject<TResponse>(response.Content);
        }

        public void PostJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model) where TRequest : class
        {
            InternalPostJson(serviceUrl, path, ticket, model);
        }

        private static IRestResponse InternalPostJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model) where TRequest : class
        {
            var client = new RestClient(serviceUrl);
            var request = new RestRequest(path);
            request.AddHeader("Content-Type", "application/json");

            if (ticket != null)
            {
                request.AddHeader("Authorization", $"Bearer {ticket.AccessToken}");
            }

            var jsonData = JsonConvert.SerializeObject(model);
            request.AddParameter("undefined", jsonData, ParameterType.RequestBody);

            return client.Post(request);
        }

        public bool Test(string serviceUrl, string path, PgAuthenticationTicket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }

            if (ticket.ExpireDate < DateTime.Now)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(serviceUrl))
            {
                throw new ArgumentException("message", nameof(serviceUrl));
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("message", nameof(path));
            }

            var client = new RestClient(serviceUrl);
            var request = new RestRequest(path, Method.GET);
            request.AddHeader("Authorization", $"Bearer {ticket.AccessToken}");

            var response = client.Execute(request);

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
