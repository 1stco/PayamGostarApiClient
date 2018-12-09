using PayamGostarClient.TelephonySystem;

namespace PayamGostarClient
{
    public class PgClient : IPgClient
    {
        private readonly IHttpClient _httpClient;

        public PgClient(string serviceUrl, PgAuthenticationTicket ticket, IHttpClient httpClient)
        {
            ServiceUrl = serviceUrl;
            Ticket = ticket;
            _httpClient = httpClient;
        }

        public string ServiceUrl { get; set; }

        public PgAuthenticationTicket Ticket { get; private set; }

        public ITelephonySystemClient GetTelephonySystem()
        {
            return new PgTelephonySystemClient(_httpClient, this);
        }
    }
}
