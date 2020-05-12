using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice
{
    public class InvoiceFindResult : CrmObjectFindResult
    {
        public List<InvoiceFindGetResult> data { get; set; }
    }
}
