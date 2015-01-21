Telerik Analytics
=========

This is a .NET portable class library for the Telerik Platform Analytics Public API, see http://docs.telerik.com/platform/analytics/api/public-api.

There is a NuGet package available here: https://www.nuget.org/packages/Telerik.Analytics

Getting started
===============

After you have installed the NuGet package, you can get an instance of the service using the AnalyticsService class:

```C#
using Telerik.Analytics;

var apikey = "<insert your api key>";
var projectkey = "<insert your projectid>";
var analytics = AnalyticsService.Create(apikey);
var project = await analytics.GetProjectAsync(projectkey); 
```
