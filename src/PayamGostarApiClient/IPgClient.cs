using PayamGostarClient.TelephonySystem;
using Septa.PayamGostarApiClient.Form;
using Septa.PayamGostarApiClient.Person;
using Septa.PayamGostarApiClient.SecurityItem;

namespace PayamGostarClient
{
    public interface IPgClient
    {
        string ServiceUrl { get; set; }

        PgAuthenticationTicket Ticket { get; }

        ITelephonySystemClient GetTelephonySystem();

        ISecurityItemClient GetSecurityItem();

        IFormClient GetFormClient();

        IPersonClient GetPersonClient();
    }
}
