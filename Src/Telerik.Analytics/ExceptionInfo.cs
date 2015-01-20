using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class ExceptionInfo
    {
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan Runtime { get; set; }
        public long ExceptionBucketID { get; set; }
        public long ExceptionCaseNumber { get; set; }
        public string ExceptionStackTrace { get; set; }
        public string ExceptionType { get; set; }
    }
}