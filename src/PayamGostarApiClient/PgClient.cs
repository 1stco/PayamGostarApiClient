using PayamGostarClient.TelephonySystem;
using Septa.PayamGostarApiClient.Form;
using Septa.PayamGostarApiClient.Invoice.PurchaseInvoice;
using Septa.PayamGostarApiClient.Invoice.SalesInvoice;
using Septa.PayamGostarApiClient.Organization;
using Septa.PayamGostarApiClient.Person;
using Septa.PayamGostarApiClient.SecurityItem;
using Septa.PayamGostarApiClient.Task;
using Septa.PayamGostarApiClient.Ticket;

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

        public IFormClient GetFormClient()
        {
            return new PgFormClient(_httpClient, this);
        }

        public IPersonClient GetPersonClient()
        {
            return new PgPersonClient(_httpClient, this);
        }

        public ISalesInvoiceClient GetSalesInvoiceClient()
        {
            return new PgSalesInvoiceClient(_httpClient, this);
        }

        public IPurchaseInvoiceClient GetPurchaseInvoiceClient()
        {
            return new PgPurchaseInvoiceClient(_httpClient, this);
        }

        public ISecurityItemClient GetSecurityItem()
        {
            return new PgSecurityItemClient(_httpClient, this);
        }

        public ITelephonySystemClient GetTelephonySystem()
        {
            return new PgTelephonySystemClient(_httpClient, this);
        }

        public ITicketClient GetTicketClient()
        {
            return new PgTicketClient(_httpClient, this);
        }

        public IOrganizationClient GetOrganizationClient()
        {
            return new PgOrganizationClient(_httpClient, this);
        }

        public ITaskClient GetTaskClient()
        {
            return new PgTaskClient(_httpClient, this);
        }
    }
}
