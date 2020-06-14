using PayamGostarClient.TelephonySystem;
using Septa.PayamGostarApiClient.Form;
using Septa.PayamGostarApiClient.Invoice.PurchaseInvoice;
using Septa.PayamGostarApiClient.Invoice.SalesInvoice;
using Septa.PayamGostarApiClient.Person;
using Septa.PayamGostarApiClient.SecurityItem;
using Septa.PayamGostarApiClient.Ticket;

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

        ITicketClient GetTicketClient();

        ISalesInvoiceClient GetSalesInvoiceClient();

        IPurchaseInvoiceClient GetPurchaseInvoiceClient();
    }
}
