namespace Septa.PayamGostarApiClient.TelephonySystem
{
    public class CallMergeModel
    {
        public string TsKey { get; set; }

        public long SourceCallId { get; set; }

        public long DestinationCallId { get; set; }
    }
}
