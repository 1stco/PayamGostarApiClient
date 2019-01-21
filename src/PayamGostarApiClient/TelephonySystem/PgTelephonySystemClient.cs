using System;
using System.Collections.Generic;
using PayamGostarClient.Internals;
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

        public IEnumerable<TelephonySystemModel> GetAll()
        {
            return _httpClient.GetJson<TelephonySystemRequest, List<TelephonySystemModel>>(_pgClient.ServiceUrl, "/api/v1/telephony", _pgClient.Ticket, null);
        }

        public bool MergeCall(CallMergeModel model)
        {
            var status = _httpClient.PutJson(_pgClient.ServiceUrl, "api/v1/telephony/call/merge", _pgClient.Ticket, model);
            return status.IsOk();
        }

        public TelephonySystemPeerResult CreatePeer(string tsKey, TelephonySystemPeerModel peer)
        {
            return _httpClient.PostJson<TelephonySystemPeerModel, TelephonySystemPeerResult>(_pgClient.ServiceUrl, $"api/v1/telephony/{tsKey}/peer", _pgClient.Ticket, peer);
        }

        public TelephonySystemPeerResult UpdatePeer(string tsKey, Guid id, TelephonySystemPeerModel peer)
        {
            return _httpClient.PutJson<TelephonySystemPeerModel, TelephonySystemPeerResult>(_pgClient.ServiceUrl, $"api/v1/telephony/{tsKey}/peer/{id}", _pgClient.Ticket, peer);
        }

        public void DeletePeer(string tsKey, Guid id)
        {
            _httpClient.Delete(_pgClient.ServiceUrl, $"api/v1/telephony/{tsKey}/{id}", _pgClient.Ticket);
        }

        public TelephonySystemResult CreateTelephonySystem(TelephonySystemModel telephonySystem)
        {
            return _httpClient.PostJson<TelephonySystemModel, TelephonySystemResult>(_pgClient.ServiceUrl, "api/v1/telephony", _pgClient.Ticket, telephonySystem);
        }

        public TelephonySystemPeerResult GetPeer(string tsKey, string name)
        {
            return _httpClient.GetJson<TelephonySystemPeerRequest, TelephonySystemPeerResult>(_pgClient.ServiceUrl, $"api/v1/telephony/{tsKey}/peer/{name}", _pgClient.Ticket, null);
        }
    }

    public class TelephonySystemPeerRequest { }

    public class TelephonySystemRequest
    {
    }

    public class TelephonySystemModel
    {
        public Guid? Id { get; set; }

        public string ServiceAddress { get; set; }

        public string Name { get; set; }

        public Guid? OfficeId { get; set; }

        public string Key { get; set; }

        public string BrevityName { get; set; }

        public bool UpdatePeersIfNotExists { get; set; }
    }

    public class TelephonySystemResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid? OfficeId { get; set; }

        public string Key { get; set; }

        public string BrevityName { get; set; }

        public bool UpdatePeersIfNotExists { get; set; }

        public string ServiceAddress { get; set; }
    }
}
