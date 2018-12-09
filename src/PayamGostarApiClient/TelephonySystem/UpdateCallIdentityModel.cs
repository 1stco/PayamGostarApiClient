using System;

namespace PayamGostarClient.TelephonySystem
{
    public class UpdateCallIdentityModel
    {
        public string TsKey { get; set; }

        public string CallSourceId { get; set; }

        public string phoneNumber { get; set; }

        public Guid IdentityId { get; set; }
        
        public bool AddPhoneNumberAsContact { get; set; }
    }
}