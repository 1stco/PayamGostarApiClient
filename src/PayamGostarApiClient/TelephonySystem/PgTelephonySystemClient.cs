using System;
using System.Collections.Generic;
using Septa.PayamGostarApiClient.TelephonySystem;

namespace PayamGostarClient.TelephonySystem
{
    public class PgTelephonySystemClient : ITelephonySystemClient
    {
        private readonly IHttpClient _httpClient;
        private readonly IPgClient _pgClient;

        public PgTelephonySystemClient(IHttpClient httpClient, IPgClient pgClient)
        {
            _httpClient = httpClient;
            _pgClient = pgClient;
        }

        public CallChannelCreateResult CallChannelCreate(CallChannelCreateModel model)
        {
            return _httpClient.PostJson<CallChannelCreateModel, CallChannelCreateResult>(_pgClient.ServiceUrl, "/api/v1/telephony/channel", _pgClient.Ticket, model);
        }

        public CallCreateResult CallCreate(CallCreateModel model)
        {
            return _httpClient.PostJson<CallCreateModel, CallCreateResult>(_pgClient.ServiceUrl, "/api/v1/telephony/call", _pgClient.Ticket, model);
        }

        public void CallChannelUpdate(CallChannelUpdateModel model)
        {
            _httpClient.PutJson(_pgClient.ServiceUrl, "/api/v1/telephony/channel", _pgClient.Ticket, model);
        }

        public CallUpdateResult CallUpdate(CallUpdateModel model)
        {
            return _httpClient.PutJson<CallUpdateModel, CallUpdateResult>(_pgClient.ServiceUrl, "/api/v1/telephony/call", _pgClient.Ticket, model);
        }

        public void UpdateIdentity(UpdateCallIdentityModel model)
        {
            _httpClient.PostJson(_pgClient.ServiceUrl, "/api/v1/telephony/updateIdentity", _pgClient.Ticket, model);
        }

        public IEnumerable<ActiveCallResult> GetActiveCalls(ActiveCallFilterModel model)
        {
            return _httpClient.GetJson<ActiveCallFilterModel, List<ActiveCallResult>>(_pgClient.ServiceUrl, "/api/v1/telephony/call/active", _pgClient.Ticket, model);
        }

        public IEnumerable<TelephonySystem> GetAll()
        {
            return _httpClient.GetJson<TelephonySystemRequest, List<TelephonySystem>>(_pgClient.ServiceUrl, "/api/v1/telephony", _pgClient.Ticket, null);
        }

        public bool MergeCall(CallMergeModel model)
        {
            return _httpClient.PutJson(_pgClient.ServiceUrl, "api/v1/telephony/call/merge", _pgClient.Ticket, model) == System.Net.HttpStatusCode.OK;
        }
    }

    public class TelephonySystemRequest
    {
    }

    public class TelephonySystem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid? OfficeId { get; set; }

        public string Key { get; set; }

        public string BrevityName { get; set; }
    }
}
