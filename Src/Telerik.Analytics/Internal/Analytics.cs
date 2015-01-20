using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Analytics.Internal
{
    internal class Analytics : IAnalyticsService
    {
        private readonly HttpClient client;

        public Analytics(string key)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://platform.telerik.com/analytics/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var byteArray = Encoding.UTF8.GetBytes(string.Format("api:{0}", key));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var result = await client.GetAsync(url);
            result.EnsureSuccessStatusCode();
            //(await result.Content.ReadAsStringAsync()).Dump();
            return await result.Content.ReadAsAsync<T>();
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await GetAsync<List<Country>>("data/assets/countries");
        }

        public async Task<List<TimeZoneOffset>> GetTimezonesAsync()
        {
            return await GetAsync<List<TimeZoneOffset>>("data/assets/timezones");
        }

        public async Task<DataSeriesCollection> GetEnvironmentsAsync(string projectId, EnvironmentType type, Filter filter)
        {
            var url = string.Format("data/environments/{0}/{1}?{2}", projectId, Enum.GetName(typeof(EnvironmentType), type), filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<List<string>> GetEnvironmentValuesAsync(string projectId, EnvironmentType type)
        {
            var url = string.Format("data/environments/{0}/{1}/values", projectId, Enum.GetName(typeof(EnvironmentType), type));
            return await GetAsync<List<string>>(url);
        }

        public async Task<DataSeriesCollection> GetExceptionItemsAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/exceptionitems/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<DataSeriesCollection> GetExceptionOccurencesAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/exceptionoccurrences/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<DataSeriesCollection> GetExceptionOccurencesAverageAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/exceptionoccurrences/{0}/average?{1}", projectId, filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<ExceptionItemCollection> GetExceptionsAsync(string projectId, PagedFilter filter)
        {
            var url = string.Format("data/exceptions/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<ExceptionItemCollection>(url);
        }

        public async Task<ExceptionItem> GetExceptionAsync(string projectId, long exceptionBucketId)
        {
            var url = string.Format("data/exceptions/{0}/bucket/{1}", projectId, exceptionBucketId);
            return await GetAsync<ExceptionItem>(url);
        }

        public async Task<ExceptionDetails> GetExceptionDetailsAsync(string projectId, long exceptionBucketId)
        {
            var url = string.Format("data/exceptions/{0}/details/{1}", projectId, exceptionBucketId);
            return await GetAsync<ExceptionDetails>(url);
        }

        public async Task<ExceptionOccurenceCollection> GetExceptionOccurencesAsync(string projectId, long exceptionBucketId, PagedFilter filter)
        {
            var url = string.Format("data/exceptions/{0}/occurences/{1}?{2}", projectId, exceptionBucketId, filter.ToQueryString());
            return await GetAsync<ExceptionOccurenceCollection>(url);
        }

        public async Task<ExceptionSummary> GetExceptionSummaryAsync(string projectId)
        {
            var url = string.Format("data/exceptions/{0}/summary", projectId);
            return await GetAsync<ExceptionSummary>(url);
        }

        public async Task<List<FeatureValueCategory>> GetFeatureTimingsAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/featuretiming/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<List<FeatureValueCategory>>(url);
        }

        public async Task<FeatureValuesDataSeriesCollection> GetFeatureTimingAsync(string projectId, long featureId, Filter filter)
        {
            var url = string.Format("data/featuretiming/{0}/{1}?{2}", projectId, featureId, filter.ToQueryString());
            return await GetAsync<FeatureValuesDataSeriesCollection>(url);
        }

        public async Task<List<FeatureCategory>> GetFeatureUsagesAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/featureusage/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<List<FeatureCategory>>(url);
        }

        public async Task<FeatureUsageDataSeriesCollection> GetFeatureUsageAsync(string projectId, string category, Filter filter)
        {
            var url = string.Format("data/featureusage/{0}/{1}?{2}", projectId, category.ToBase64(), filter.ToQueryString());
            return await GetAsync<FeatureUsageDataSeriesCollection>(url);
        }

        public async Task<List<FeatureValueCategory>> GetFeatureValuesAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/featurevalue/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<List<FeatureValueCategory>>(url);
        }

        public async Task<FeatureValuesDataSeriesCollection> GetFeatureValueAsync(string projectId, long featureId, Filter filter)
        {
            var url = string.Format("data/featurevalue/{0}/{1}?{2}", projectId, featureId, filter.ToQueryString());
            return await GetAsync<FeatureValuesDataSeriesCollection>(url);
        }

        public async Task<NamedValueCollection> GetGeoLocationCountryAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/geolocation/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<NamedValueCollection>(url);
        }

        public async Task<GeoLocationNamedCollection> GetGeoLocationCityByCountryAsync(string projectId, string countryCode, Filter filter)
        {
            var url = string.Format("data/geolocation/{0}/citybycountry/{1}?{2}", projectId, countryCode, filter.ToQueryString());
            return await GetAsync<GeoLocationNamedCollection>(url);
        }

        public async Task<GeoLocationNamedCollection> GetGeoLocationCityByRegionAsync(string projectId, string countryCode, string regionCode, Filter filter)
        {
            var url = string.Format("data/geolocation/{0}/citybyregion/{1}/{2}?{3}", projectId, countryCode, regionCode, filter.ToQueryString());
            return await GetAsync<GeoLocationNamedCollection>(url);
        }

        public async Task<List<Country>> GetGeoLocationExistingCountriesAsync(string projectId, Origin origin = Origin.All)
        {
            var url = string.Format("data/geolocation/{0}/existing?Origin=", projectId, Enum.GetName(typeof(Origin), origin));
            return await GetAsync<List<Country>>(url);
        }

        public async Task<NamedValueCollection> GetGeoLocationRegionByCountryAsync(string projectId, string countryCode, Filter filter)
        {
            var url = string.Format("data/geolocation/{0}/regionbycountry/{1}?{2}", projectId, countryCode, filter.ToQueryString());
            return await GetAsync<NamedValueCollection>(url);
        }

        public async Task<List<Region>> GetGeoLocationExistingRegionsAsync(string projectId, string countryCode, Origin origin = Origin.All)
        {
            var url = string.Format("data/geolocation/{0}/regions/{1}?Origin=", projectId, countryCode, Enum.GetName(typeof(Origin), origin));
            return await GetAsync<List<Region>>(url);
        }

        public async Task<NamedValueCollection> GetHourOfDayAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/hourofday/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<NamedValueCollection>(url);
        }

        public async Task<List<RawSessionActivity>> GetLiveSessionsAsync(string projectId, SessionFilter filter)
        {
            var url = string.Format("data/live/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<List<RawSessionActivity>>(url);
        }

        public async Task<LoyaltyGroupDataSeriesCollection> GetLoyaltyAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/loyalty/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<LoyaltyGroupDataSeriesCollection>(url);
        }

        public async Task<DataSeriesCollection> GetNewUsersAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/newusers/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<NamedValueCollection> GetSessionLengthAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/sessionlength/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<NamedValueCollection>(url);
        }

        public async Task<List<UsageSession>> GetSessionsAsync(string projectId, SessionFilter filter)
        {
            var url = string.Format("data/sessions/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<List<UsageSession>>(url);
        }

        public async Task<SpecificSession> GetSessionAsync(string projectId, long usageId)
        {
            var url = string.Format("data/sessions/{0}/{1}", projectId, usageId);
            return await GetAsync<SpecificSession>(url);
        }

        public async Task<List<SessionIdentifier>> GetSessionIdentifiersAsync(string projectId, string identifier)
        {
            var url = string.Format("data/sessions/{0}/search?Identifier={1}", projectId, identifier);
            return await GetAsync<List<SessionIdentifier>>(url);
        }

        public async Task<TrendsData> GetTrendsAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/trends/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<TrendsData>(url);
        }

        public async Task<DataSeriesCollection> GetUsagesAsync(string projectId, Filter filter)
        {
            var url = string.Format("data/usage/{0}?{1}", projectId, filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<DataSeriesCollection> GetVersionsAsync(string projectId, Filter filter, VersionGrouping grouping = VersionGrouping.All)
        {
            var url = string.Format("data/versions/{0}/{1}?{2}", projectId, Enum.GetName(typeof(VersionGrouping), grouping), filter.ToQueryString());
            return await GetAsync<DataSeriesCollection>(url);
        }

        public async Task<List<string>> GetExistingVersionsAsync(string projectId, Origin origin = Origin.Public)
        {
            var url = string.Format("data/versions/{0}/existing?Origin=", projectId, Enum.GetName(typeof(Origin), origin));
            return await GetAsync<List<string>>(url);
        }

        public async Task<Project> GetProjectAsync(string projectId)
        {
            var url = string.Format("projects/{0}", projectId);
            return await GetAsync<Project>(url);
        }

    }
}