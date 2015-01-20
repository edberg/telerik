using System;

namespace Telerik.Analytics
{
    public class ExceptionItem
    {
        public Guid ProductID { get; set; }
        public long ExceptionBucketID { get; set; }
        public int ExceptionCaseNumber { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionStackTrace { get; set; }
        public DateTime FirstOccurrence { get; set; }
        public DateTime LastOccurrence { get; set; }
        public string ContextMessage { get; set; }
        public int Count { get; set; }
        public string ExceptionMessage { get; set; }
        public State State { get; set; }
        public bool IsAutoClosed { get; set; }
        public bool IsAutoGroup { get; set; }
        public int? GroupMatched { get; set; }
        public string AcknowledgedInVersion { get; set; }
    }
}