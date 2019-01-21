using Septa.PayamGostarApiClient.TelephonySystem;
using System;
using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{

    public class TelephonySystemPeerResult
    {
        public Guid? Id { get; set; }

        public Guid TelephonySystemId { get; set; }

        public string TelephonySystemKey { get; set; }

        public string Name { get; set; }

        public TelephonySystemPeerType TelephonySystemPeerType { get; set; }

        public Guid? UserId { get; set; }

        public string Username { get; set; }
    }
}
