using System;
using Newtonsoft.Json;
using Telerik.Analytics.Internal;

namespace Telerik.Analytics
{
    public class Project
    {
        public string ProjectKey { get; set; }
        public Guid DefaultDashboardKey { get; set; }
        public ProjectType Type { get; set; }
        public bool HasData { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime? FirstData { get; set; }
        [JsonConverter(typeof(MilleniumDateConverter))]
        public DateTime? LastData { get; set; }
        public int? CustomScripts { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public Guid AccountId { get; set; }
        public string AccountEmail { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}