using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class ExceptionSummary
    {
        public int TotalException { get; set; }
        public List<ExceptionState> States { get; set; }
    }
}