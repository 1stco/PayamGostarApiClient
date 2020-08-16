using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketGetReplyFileModel
    {
        public string TicketId { get; set; }

        public string ReplyId { get; set; }

        public string FileId { get; set; }
    }
}
