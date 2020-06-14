using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice.PurchaseInvoice
{
    public class PurchaseInvoiceUpdateModel : InvoiceUpdateModel
    {
        public string RelatedQuoteId { get; set; }
    }
}
