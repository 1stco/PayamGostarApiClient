using Septa.PayamGostarApiClient.Common;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public interface ITicketClient
    {
        TicketGetResult CallGet(TicketGetModel model);
        TicketCreateResult CallCreate(TicketCreateModel model);
        TicketUpdateResult CallUpdate(TicketUpdateModel model);
        bool CallDelete(TicketDeleteModel model);
        TicketFindResult CallFind(CrmObjectFindModel model);
        bool CallCustomerReply(TicketCreateCustomerReplyModel model);
        List<SelectListItemModel> CallGetTicketTypes();
        byte[] CallGetReplyFileByName(TicketGetReplyFileModel model);
    }
}
