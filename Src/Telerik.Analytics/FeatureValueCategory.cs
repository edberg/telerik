namespace Telerik.Analytics
{
    public class FeatureValueCategory
    {
        public long FeatureID { get; set; }
        public FeatureType Type { get; set; }
        public string FeatureName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool IsHidden { get; set; }
        public string Unit { get; set; }
        public double Scale { get; set; }
    }
}