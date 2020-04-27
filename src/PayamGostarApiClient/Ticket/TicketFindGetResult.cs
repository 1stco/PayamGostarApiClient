using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketFindGetResult : TicketGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
