using System.Collections.Generic;

namespace Telerik.Analytics
{
    public class ExceptionOccurenceCollection
    {
        public List<ExceptionOccurence> Results { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public int Count { get; set; }
    }
}