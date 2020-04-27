using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketFindResult : CrmObjectFindResult
    {
        public List<TicketFindGetResult> data { get; set; }
    }
}
