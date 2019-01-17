using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayamGostarClient.TelephonySystem
{

    public class CallCreateResult
    {
        public long CallId { get; set; }

        public long InitChannelId { get; set; }

        public Guid? IdentityId { get; set; }

        public string IdentityNickName { get; set; }
    }
}
