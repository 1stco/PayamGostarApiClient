using Septa.PayamGostarApiClient.TelephonySystem;
using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{
    public interface ITelephonySystemClient
    {
        CallCreateResult CallCreate(CallCreateModel model);

        CallChannelCreateResult CallChannelCreate(CallChannelCreateModel model);

        void CallChannelUpdate(CallChannelUpdateModel model);

        CallUpdateResult CallUpdate(CallUpdateModel model);

        void UpdateIdentity(UpdateCallIdentityModel model);

        bool MergeCall(CallMergeModel model);

        IEnumerable<TelephonySystem> GetAll();

        IEnumerable<ActiveCallResult> GetActiveCalls(ActiveCallFilterModel model);
    }
}
