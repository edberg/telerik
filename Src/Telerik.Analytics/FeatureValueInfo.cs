using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class FeatureValueInfo
    {
        [JsonConverter(typeof(MillisecondsTimeSpanConverter))]
        public TimeSpan Runtime { get; set; }
        public string FeatureName { get; set; }
        public long Value { get; set; }
        public bool IsTiming { get; set; }
    }
}