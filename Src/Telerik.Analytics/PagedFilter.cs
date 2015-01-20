namespace Telerik.Analytics
{
    public class PagedFilter : Filter
    {
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public string SortBy { get; set; }
        public SortDir? SortDir { get; set; }
        public string FilterField { get; set; }
        public string FilterText { get; set; }
    }
}