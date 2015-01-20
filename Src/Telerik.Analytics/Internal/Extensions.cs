using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Analytics.Internal
{
    internal static class Extensions
    {
        public static string ToQueryString(this Filter filter)
        {
            var querystring = new Dictionary<string, string>();
            querystring["StartDate"] = filter.StartDate.DaysSinceMillenium().ToString();
            querystring["EndDate"] = filter.EndDate.DaysSinceMillenium().ToString();
            if (filter.IsLiveMode != null) querystring["IsLiveMode"] = filter.IsLiveMode.Value ? "true" : "false";
            if (filter.Countries != null) querystring["Countries"] = string.Join("_", filter.Countries.ToArray());
            if (filter.CountryOperator != null) querystring["CO"] = Enum.GetName(typeof(Operator), filter.CountryOperator);
            if (filter.Versions != null) querystring["Version"] = string.Join("_", filter.Versions.ToArray());
            if (filter.VersionOperator != null) querystring["VO"] = Enum.GetName(typeof(Operator), filter.VersionOperator);
            if (filter.Origin != null) querystring["Origin"] = Enum.GetName(typeof(Origin), filter.Origin);
            if (filter.Mode != null) querystring["Mode"] = Enum.GetName(typeof(Mode), filter.Mode);

            if (filter is PagedFilter)
            {
                var pagedfilter = filter as PagedFilter;
                if (pagedfilter.Skip != null) querystring["Skip"] = pagedfilter.Skip.ToString();
                if (pagedfilter.Take != null) querystring["Take"] = pagedfilter.Take.ToString();
                if (pagedfilter.SortBy != null) querystring["SortBy"] = pagedfilter.SortBy;
                if (pagedfilter.SortDir != null) querystring["SortDir"] = Enum.GetName(typeof(SortDir), pagedfilter.SortDir);
                if (pagedfilter.FilterField != null) querystring["FilterField"] = pagedfilter.FilterField;
                if (pagedfilter.FilterText != null) querystring["FilterText"] = pagedfilter.FilterText;
            }

            return querystring.ToQueryString();
        }

        public static string ToQueryString(this SessionFilter filter)
        {
            var querystring = new Dictionary<string, string>();
            if (filter.CookieID != null) querystring["CookieID"] = filter.CookieID;
            if (filter.Installation != null) querystring["Installation"] = filter.Installation;
            if (filter.IP != null) querystring["IP"] = filter.IP;
            if (filter.Origin != null) querystring["Origin"] = Enum.GetName(typeof(Origin), filter.Origin);
            return querystring.ToQueryString();
        }

        public static string ToQueryString(this Dictionary<string, string> item)
        {
            var items = from i in item.ToList()
                select string.Format("{0}={1}", i.Key, i.Value);
            return string.Join("&", items);
        }



        public static int DaysSinceMillenium(this DateTime date)
        {
            var millenium = new DateTime(2000, 1, 1);
            return Convert.ToInt32((date - millenium).TotalDays);
        }

        public static DateTime Date(this int dayssincemillenium)
        {
            var millenium = new DateTime(2000, 1, 1);
            return millenium.AddDays(dayssincemillenium);
        }

        public static string UrlEncode(this string url)
        {
            return Uri.EscapeUriString(url);
        }

        public static string ToBase64(this string data)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}