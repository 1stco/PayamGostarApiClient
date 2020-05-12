using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice
{
    public class InvoiceFindGetResult : InvoiceGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
