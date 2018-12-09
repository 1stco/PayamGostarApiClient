﻿using System;

namespace PayamGostarClient.TelephonySystem
{

    public class CallChannelUpdateModel
    {
        public long CallChannelId { get; set; }

        public ChannelStatus ChannelStatusIndex { get; set; }

        public ChannelResponse ChannelResponseIndex { get; set; }

        public string RecordedFileName { get; set; }

        public DateTime? ConnectDate { get; set; }

        public DateTime? HangupDate { get; set; }

        public bool IsLive { get; set; }
    }
}
