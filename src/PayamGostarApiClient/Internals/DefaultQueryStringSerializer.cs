using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PayamGostarClient.Internals
{

    public class DefaultQueryStringSerializer : IQueryStringSerializer
    {
        public string Serialize(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            var queryString = string.Join("&", properties.ToArray());
            return queryString;
        }
    }
}
