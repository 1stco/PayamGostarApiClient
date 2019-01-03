using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{
    public interface ITelephonySystemClient
    {
        CallCreateResult CallCreate(CallCreateModel model);

        CallChannelCreateResult CallChannelCreate(CallChannelCreateModel model);

        void CallChannelUpdate(CallChannelUpdateModel model);

        void CallUpdate(CallUpdateModel model);

        void UpdateIdentity(UpdateCallIdentityModel model);

        IEnumerable<TelephonySystem> GetAll();

        IEnumerable<ActiveCallResult> GetActiveCalls(ActiveCallFilterModel model);
    }
}
