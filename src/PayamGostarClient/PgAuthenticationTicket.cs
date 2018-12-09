using System;

namespace PayamGostarClient
{

    public class PgAuthenticationTicket
    {
        public PgAuthenticationTicket(string accessToken, DateTime expireDate)
        {
            AccessToken = accessToken;
            ExpireDate = expireDate;
        }

        public string AccessToken { get; private set; }

        public DateTime ExpireDate { get; private set; }
    }
}
