﻿using PayamGostarClient.Internals;
using System.Collections.Generic;
using System.Net;

namespace PayamGostarClient
{
    public interface IHttpClient
    {
        IQueryStringSerializer QueryStringSerializer { get; set; }


        HttpResponse PostForm(string serviceUrl, string path, IDictionary<string, string> parameters);


        TResponse GetJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class;


        TResponse PostJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class;

        HttpStatusCode PostJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class;


        TResponse PutJson<TRequest, TResponse>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class
            where TResponse : class;

        HttpStatusCode PutJson<TRequest>(string serviceUrl, string path, PgAuthenticationTicket ticket, TRequest model)
            where TRequest : class;


        bool Test(string serviceUrl, string path, PgAuthenticationTicket ticket);
    }
}
