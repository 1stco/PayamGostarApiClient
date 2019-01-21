using PayamGostarClient.TelephonySystem;
using Septa.PayamGostarApiClient.SecurityItem;

namespace PayamGostarClient
{
    public interface IPgClient
    {
        string ServiceUrl { get; set; }

        PgAuthenticationTicket Ticket { get; }

        ITelephonySystemClient GetTelephonySystem();

        ISecurityItemClient GetSecurityItem();
    }
}
