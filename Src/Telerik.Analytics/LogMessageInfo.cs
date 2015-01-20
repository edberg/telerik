using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class LogMessageInfo
    {
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan Runtime { get; set; }
        public long LogMessageID { get; set; }
        public string LogMessageText { get; set; }
        public bool HasLogFile { get; set; }
    }
}