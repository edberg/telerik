using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class LoyaltyGroupDataSeries
    {
        public LoyaltyGroup Group { get; set; }
        public List<long> AverageRunTimes { get; set; }
        public bool IsHidden { get; set; }
        public string DisplayName { get; set; }
        public string SeriesName { get; set; }
        public List<double> Values { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime BeginDate { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime EndDate { get; set; }
    }
}