using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PayamGostarClient
{

    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException() : base("Username or password is not valid.")
        {
        }
    }
}
