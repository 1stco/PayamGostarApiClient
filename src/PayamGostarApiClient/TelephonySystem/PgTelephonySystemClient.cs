using System;
using System.Collections.Generic;

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
            return _httpClient.PostJson<CallChannelCreateModel, CallChannelCreateResult>(_pgClient.ServiceUrl, "/api/v1/telephony/callChannelCreate", _pgClient.Ticket, model);
        }

        public CallCreateResult CallCreate(CallCreateModel model)
        {
            return _httpClient.PostJson<CallCreateModel, CallCreateResult>(_pgClient.ServiceUrl, "/api/v1/telephony/callCreate", _pgClient.Ticket, model);
        }

        public void CallChannelUpdate(CallChannelUpdateModel model)
        {
            _httpClient.PostJson(_pgClient.ServiceUrl, "/api/v1/telephony/callChannelUpdate", _pgClient.Ticket, model);
        }

        public void CallUpdate(CallUpdateModel model)
        {
            _httpClient.PostJson(_pgClient.ServiceUrl, "/api/v1/telephony/callUpdate", _pgClient.Ticket, model);
        }

        public void UpdateIdentity(UpdateCallIdentityModel model)
        {
            _httpClient.PostJson(_pgClient.ServiceUrl, "/api/v1/telephony/updateIdentity", _pgClient.Ticket, model);
        }

        public IEnumerable<ActiveCallResult> GetActiveCalls(ActiveCallFilterModel model)
        {
            return _httpClient.PostJson<ActiveCallFilterModel, List<ActiveCallResult>>(_pgClient.ServiceUrl, "/api/v1/telephony/getActiveCalls", _pgClient.Ticket, model);
        }
    }
}
