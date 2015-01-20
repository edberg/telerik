using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class ExceptionOccurence
    {
        public long ExceptionID { get; set; }
        public DateTime ClientTime { get; set; }
        public DateTime ServerTime { get; set; }
        public string Version { get; set; }
        public string IP { get; set; }
        public string ContextMessage { get; set; }
        public string Memory { get; set; }
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan Runtime { get; set; }
        public string InstallationID { get; set; }
        public long UsageID { get; set; }
        public string ClientCookie { get; set; }
        public string NumberOfProcessor { get; set; }
        public string Architecture { get; set; }
        public string Language { get; set; }
        public string Framework { get; set; }
        public string OperatingSystem { get; set; }
    }
}