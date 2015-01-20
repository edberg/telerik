using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class FeatureValuesDataSeriesCollection
    {
        public List<FeatureValuesDataSeries> Series { get; set; }
        public List<double> AvgSeries { get; set; }
        public int DefinedBuckets { get; set; }
        public bool DataIsBeingUpdated { get; set; }
        public string Unit { get; set; }
        public double Scale { get; set; }
        public string DisplayName { get; set; }
        public string OriginalName { get; set; }
        public string Description { get; set; }
    }
}