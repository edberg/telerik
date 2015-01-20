using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class FeatureUsageDataSeriesCollection
    {
        public List<DataSeries> Series { get; set; }
        public string DisplayName { get; set; }
        public string OriginalName { get; set; }
        public string Description { get; set; }
        public int OverflowedSeries { get; set; }
    }
}