﻿using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PayamGostarClient.Internals
{
    internal class RestSharpHttpClient : IHttpClient
    {
        private IQueryStringSerializer _queryStringSerializer = null;
        public IQueryStringSerializer QueryStringSerializer
        {
            get
            {
                if (_queryStringSerializer == null)
                {
                    _queryStringSerializer = new DefaultQueryStringSerializer();
                }

                return _queryStringSerializer;
            }
            set
            {
                _queryStringSerializer = value;
            }
        }


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
            var response = InternalSendJson(Method.POST, serviceUrl, path, ticket, model);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException($"Server responded with status {response.StatusCode}");

            return JsonConvert.DeserializeObject<TResponse>(response.Content);
        }

        public void PostJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model) where TRequest : class
        {
            InternalSendJson(Method.POST, serviceUrl, path, ticket, model);
        }

        private static IRestResponse InternalSendJson<TRequest>(Method method, string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model) where TRequest : class
        {
            var client = new RestClient(serviceUrl);
            var request = new RestRequest(path, method);
            request.AddHeader("Content-Type", "application/json");

            if (ticket != null)
            {
                request.AddHeader("Authorization", $"Bearer {ticket.AccessToken}");
            }

            if (model != null)
            {
                request.AddJsonBody(model);
            }

            return client.Execute(request);
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

        public TResponse PutJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class
        {
            var response = InternalSendJson(Method.PUT, serviceUrl, path, ticket, model);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException($"Server responded with status {response.StatusCode}: '{response.StatusDescription}'");

            return JsonConvert.DeserializeObject<TResponse>(response.Content);
        }

        public void PutJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model) where TRequest : class
        {
            InternalSendJson(Method.PUT, serviceUrl, path, ticket, model);
        }

        public TResponse GetJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class
        {
            var pathWithQueryString = model != null ? $"{path}?{QueryStringSerializer.Serialize(model)}" : path;

            var response = InternalSendJson(Method.GET, serviceUrl, pathWithQueryString, ticket, default(TRequest));
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new InvalidOperationException($"Server responded with status {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<TResponse>(response.Content);
        }
    }
}
