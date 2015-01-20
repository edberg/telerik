using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class UsageSession
    {
        public long UsageID { get; set; }
        public int UsageNumber { get; set; }
        public string InstallationID { get; set; }
        public Guid CookieID { get; set; }
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan RunTime { get; set; }
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }
        public DateTime ServerTime { get; set; }
        public DateTime ClientTime { get; set; }
        public bool StopRegistered { get; set; }
        public long Memory { get; set; }
        public bool IsInternal { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string MonitorType { get; set; }
        public int NumberOfProcessor { get; set; }
        public int Architecture { get; set; }
        public string Language { get; set; }
        public string Framework { get; set; }
        public string FrameworkSP { get; set; }
        public string OperatingSystem { get; set; }
        public string MemoryStr { get; set; }
        public int ExceptionCount { get; set; }
        public int LogMessageCount { get; set; }
        public int FeatureValues { get; set; }
        public int FeatureTimings { get; set; }
        public int FeatureUsages { get; set; }
    }
}