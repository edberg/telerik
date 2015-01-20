using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class RawSessionActivity
    {
        public Guid SessionID { get; set; }
        public long UsageID { get; set; }
        public string InstallationID { get; set; }
        public Guid CookieID { get; set; }
        public string IP { get; set; }
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }
        public DateTime ServerTime { get; set; }
        public DateTime ClientTime { get; set; }
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan TimeSinceActivity { get; set; }
        public bool Stopped { get; set; }
        public Origin Origin { get; set; }
    }
}