using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayamGostarClient.TelephonySystem
{
    public class CallCreateModel 
    {
        public string TsKey { get; set; }

        public string SourceId { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime StartDate { get; set; }

        public int CallTypeIndex { get; set; }

        public string InitChannelPeerName { get; set; }

        public int InitChannelPeerTypeIndex { get; set; }

        public string InitChannelSourceId { get; set; }

        public bool IsLive { get; set; }
    }
}
