using Septa.PayamGostarApiClient.TelephonySystem;
using System;
using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{
    public interface ITelephonySystemClient
    {
        TelephonySystemResult CreateTelephonySystem(TelephonySystemModel telephonySystem);

        CallCreateResult CallCreate(CallCreateModel model);

        CallChannelCreateResult CallChannelCreate(CallChannelCreateModel model);

        void CallChannelUpdate(CallChannelUpdateModel model);

        CallUpdateResult CallUpdate(CallUpdateModel model);

        void UpdateIdentity(UpdateCallIdentityModel model);

        bool MergeCall(CallMergeModel model);

        IEnumerable<TelephonySystemModel> GetAll();

        IEnumerable<ActiveCallResult> GetActiveCalls(ActiveCallFilterModel model);

        TelephonySystemPeerResult GetPeer(string tsKey, string name);

        TelephonySystemPeerResult CreatePeer(string tsKey, TelephonySystemPeerModel peer);

        TelephonySystemPeerResult UpdatePeer(string tsKey, Guid id, TelephonySystemPeerModel peer);

        void DeletePeer(string tsKey, Guid id);
    }
}
