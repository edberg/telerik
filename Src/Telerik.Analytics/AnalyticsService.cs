namespace Telerik.Analytics
{
    public static class AnalyticsService
    {
        public static IAnalyticsService Create(string key)
        {
            return new Internal.Analytics(key);
        }
    }
}