using System;
using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class Filter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? IsLiveMode { get; set; }
        public List<string> Countries { get; set; }
        public Operator? CountryOperator { get; set; }
        public List<string> Versions { get; set; }
        public Operator? VersionOperator { get; set; }
        public Origin? Origin { get; set; }
        public Mode? Mode { get; set; }
    }
}