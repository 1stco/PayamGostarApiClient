using PayamGostarClient.TelephonySystem;

namespace PayamGostarClient
{
    public interface IPgClient
    {
        string ServiceUrl { get; set; }

        PgAuthenticationTicket Ticket { get; }

        ITelephonySystemClient GetTelephonySystem();
    }
}
