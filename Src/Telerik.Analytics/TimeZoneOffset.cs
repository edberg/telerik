using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class TimeZoneOffset
    {
        public string DisplayName { get; set; }
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan ZoneOffset { get; set; }
    }
}