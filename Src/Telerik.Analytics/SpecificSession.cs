using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class SpecificSession
    {
        public UsageSession UsageSession { get; set; }
        public List<ExceptionInfo> Exceptions { get; set; }
        public List<LogMessageInfo> LogMessages { get; set; }
        public List<FeatureValueInfo> FeatureValues { get; set; }
        public List<FeatureUsageInfo> FeatureUsages { get; set; }
        public List<InstallationPropertyInfo> InstallationProperties { get; set; }
    }
}