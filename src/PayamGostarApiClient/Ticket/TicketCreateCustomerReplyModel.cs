using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketCreateCustomerReplyModel
    {
        public string TicketId { get; set; }

        public string UserId { get; set; }

        public string Content { get; set; }

        public List<TicketCreateCustomerReplyFilePathModel> FileIds { get; set; }
    }
}
