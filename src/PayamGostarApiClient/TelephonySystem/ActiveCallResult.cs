using System;
using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{

    public class ActiveCallResult
    {
        public long CallId { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CallDate { get; set; }

        public string CallTime
        {
            get
            {
                return CallDate.ToString("HH:mm");
            }
        }

        public Guid? IdentityId { get; set; }

        public string NickName { get; set; }

        string ColorName { get; set; }

        public Guid? RelatedSalesUserId { get; set; }

        public string RelatedSalesUserName { get; set; }

        public Guid? RelatedSupportUserId { get; set; }

        public string RelatedSupportUserName { get; set; }

        public Guid? RelatedOtherUserId { get; set; }

        public string RelatedOtherUserName { get; set; }

        public IdentityType IdentityType { get; set; }

        public CallDirection CallDirection { get; set; }
    }
}
