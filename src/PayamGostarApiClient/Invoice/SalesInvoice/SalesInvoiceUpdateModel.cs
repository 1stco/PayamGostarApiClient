using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice.SalesInvoice
{
    public class SalesInvoiceUpdateModel : InvoiceUpdateModel
    {
        public string RelatedQuoteId { get; set; }
    }
}
