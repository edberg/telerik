using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class ExceptionDetails
    {
        public int AffectedUsers { get; set; }
        public int AffectedVersions { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        [JsonProperty("FirstOccuranceDaysSinceMillenium")]
        public DateTime FirstOccurance { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        [JsonProperty("LastOccuranceDaysSinceMillenium")]
        public DateTime LastOccurance { get; set; }
        public int OthersOfSameExceptionType { get; set; }
        public int TotalCount { get; set; }
    }
}