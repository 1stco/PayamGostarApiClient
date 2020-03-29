using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketActiveProcessLifePathGetResult
    {
        public string Id { get; set; }

        public string State { get; set; }

        public int Index { get; set; }
    }
}
