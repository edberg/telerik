using System.Collections.Generic;
using System.Threading.Tasks;

namespace Telerik.Analytics
{
    public interface IAnalyticsService
    {
        Task<List<Country>> GetCountriesAsync();
        Task<List<TimeZoneOffset>> GetTimezonesAsync();
        Task<DataSeriesCollection> GetEnvironmentsAsync(string projectId, EnvironmentType type, Filter filter);
        Task<List<string>> GetEnvironmentValuesAsync(string projectId, EnvironmentType type);
        Task<DataSeriesCollection> GetExceptionItemsAsync(string projectId, Filter filter);
        Task<DataSeriesCollection> GetExceptionOccurencesAsync(string projectId, Filter filter);
        Task<DataSeriesCollection> GetExceptionOccurencesAverageAsync(string projectId, Filter filter);
        Task<ExceptionItemCollection> GetExceptionsAsync(string projectId, PagedFilter filter);
        Task<ExceptionItem> GetExceptionAsync(string projectId, long exceptionBucketId);
        Task<ExceptionDetails> GetExceptionDetailsAsync(string projectId, long exceptionBucketId);
        Task<ExceptionOccurenceCollection> GetExceptionOccurencesAsync(string projectId, long exceptionBucketId, PagedFilter filter);
        Task<ExceptionSummary> GetExceptionSummaryAsync(string projectId);
        Task<List<FeatureValueCategory>> GetFeatureTimingsAsync(string projectId, Filter filter);
        Task<FeatureValuesDataSeriesCollection> GetFeatureTimingAsync(string projectId, long featureId, Filter filter);
        Task<List<FeatureCategory>> GetFeatureUsagesAsync(string projectId, Filter filter);
        Task<FeatureUsageDataSeriesCollection> GetFeatureUsageAsync(string projectId, string category, Filter filter);
        Task<List<FeatureValueCategory>> GetFeatureValuesAsync(string projectId, Filter filter);
        Task<FeatureValuesDataSeriesCollection> GetFeatureValueAsync(string projectId, long featureId, Filter filter);
        Task<NamedValueCollection> GetGeoLocationCountryAsync(string projectId, Filter filter);
        Task<GeoLocationNamedCollection> GetGeoLocationCityByCountryAsync(string projectId, string countryCode, Filter filter);
        Task<GeoLocationNamedCollection> GetGeoLocationCityByRegionAsync(string projectId, string countryCode, string regionCode, Filter filter);
        Task<List<Country>> GetGeoLocationExistingCountriesAsync(string projectId, Origin origin = Origin.All);
        Task<NamedValueCollection> GetGeoLocationRegionByCountryAsync(string projectId, string countryCode, Filter filter);
        Task<List<Region>> GetGeoLocationExistingRegionsAsync(string projectId, string countryCode, Origin origin = Origin.All);
        Task<NamedValueCollection> GetHourOfDayAsync(string projectId, Filter filter);
        Task<List<RawSessionActivity>> GetLiveSessionsAsync(string projectId, SessionFilter filter);
        Task<LoyaltyGroupDataSeriesCollection> GetLoyaltyAsync(string projectId, Filter filter);
        Task<DataSeriesCollection> GetNewUsersAsync(string projectId, Filter filter);
        Task<NamedValueCollection> GetSessionLengthAsync(string projectId, Filter filter);
        Task<List<UsageSession>> GetSessionsAsync(string projectId, SessionFilter filter);
        Task<SpecificSession> GetSessionAsync(string projectId, long usageId);
        Task<List<SessionIdentifier>> GetSessionIdentifiersAsync(string projectId, string identifier);
        Task<TrendsData> GetTrendsAsync(string projectId, Filter filter);
        Task<DataSeriesCollection> GetUsagesAsync(string projectId, Filter filter);
        Task<DataSeriesCollection> GetVersionsAsync(string projectId, Filter filter, VersionGrouping grouping = VersionGrouping.All);
        Task<List<string>> GetExistingVersionsAsync(string projectId, Origin origin = Origin.Public);
        Task<Project> GetProjectAsync(string projectId);
    }
}