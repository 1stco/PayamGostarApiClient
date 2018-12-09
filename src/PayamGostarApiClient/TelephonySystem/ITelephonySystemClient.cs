namespace PayamGostarClient.TelephonySystem
{
    public interface ITelephonySystemClient
    {
        CallCreateResult CallCreate(CallCreateModel model);

        CallChannelCreateResult CallChannelCreate(CallChannelCreateModel model);

        void CallChannelUpdate(CallChannelUpdateModel model);

        void CallUpdate(CallUpdateModel model);

        void UpdateIdentity(UpdateCallIdentityModel model);
    }
}
