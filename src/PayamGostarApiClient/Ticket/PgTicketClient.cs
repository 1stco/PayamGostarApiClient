using PayamGostarClient;
using Septa.PayamGostarApiClient.Common;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class PgTicketClient : ITicketClient
    {
        private readonly IHttpClient _httpClient;
        private readonly IPgClient _pgClient;

        public PgTicketClient(IHttpClient httpClient, IPgClient pgClient)
        {
            _httpClient = httpClient;
            _pgClient = pgClient;
        }

        public TicketCreateResult CallCreate(TicketCreateModel model)
        {
            return _httpClient.PostJson<TicketCreateModel, TicketCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/create", _pgClient.Ticket, model);
        }

        public bool CallCustomerReply(TicketCreateCustomerReplyModel model)
        {
            try
            {
                _httpClient.PostJson<TicketCreateCustomerReplyModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/customer/reply", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CallDelete(TicketDeleteModel model)
        {
            try
            {
                _httpClient.PostJson<TicketDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/delete", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TicketFindResult CallFind(CrmObjectFindModel model)
        {
            return _httpClient.PostJson<CrmObjectFindModel, TicketFindResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/find", _pgClient.Ticket, model);
        }

        public TicketGetResult CallGet(TicketGetModel model)
        {
            return _httpClient.PostJson<TicketGetModel, TicketGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/get", _pgClient.Ticket, model);
        }

        public TicketUpdateResult CallUpdate(TicketUpdateModel model)
        {
            return _httpClient.PostJson<TicketUpdateModel, TicketUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/update", _pgClient.Ticket, model);
        }

        public List<SelectListItemModel> CallGetTicketTypes()
        {
            return _httpClient.PostJson<List<SelectListItemModel>>(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/gettickettypes", _pgClient.Ticket);
        }

        public byte[] CallGetReplyFileByName(TicketGetReplyFileModel model)
        {
            var queryparams = new Dictionary<string, string>()
            {
                { "TicketId", model.TicketId },
                { "ReplyId", model.ReplyId },
                { "FileId", model.FileId }
            };

            return _httpClient.DownloadFile(_pgClient.ServiceUrl, $"api/v2/crmobject/ticket/getreplyfile", _pgClient.Ticket, queryparams);
        }

    }
}
