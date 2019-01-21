using Septa.PayamGostarApiClient.TelephonySystem;
using System;
using System.Collections.Generic;

namespace PayamGostarClient.TelephonySystem
{

    public class TelephonySystemPeerModel
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public Guid? UserId { get; set; }

        public TelephonySystemPeerType TelephonySystemPeerType { get; set; }
    }
}
