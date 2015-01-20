using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class DataSeries
    {
        public string DisplayName { get; set; }
        public string SeriesName { get; set; }
        public List<double> Values { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime BeginDate { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime EndDate { get; set; }
        public bool IsHidden { get; set; }
    }
}