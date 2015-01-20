namespace Telerik.Analytics
{
    public class SessionFilter
    {
        public string CookieID { get; set; }
        public string Installation { get; set; }
        public string IP { get; set; }
        public Origin? Origin { get; set; }
    }
}