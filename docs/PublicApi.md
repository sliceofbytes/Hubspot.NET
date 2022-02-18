# HubSpot.NET.Api.PublicApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCmsV3SiteSearchIndexedDataContentIdGetById**](PublicApi.md#getcmsv3sitesearchindexeddatacontentidgetbyid) | **GET** /cms/v3/site-search/indexed-data/{contentId} | Get indexed properties.
[**GetCmsV3SiteSearchSearchSearch**](PublicApi.md#getcmsv3sitesearchsearchsearch) | **GET** /cms/v3/site-search/search | Search your site.


<a name="getcmsv3sitesearchindexeddatacontentidgetbyid"></a>
# **GetCmsV3SiteSearchIndexedDataContentIdGetById**
> IndexedData GetCmsV3SiteSearchIndexedDataContentIdGetById (string contentId, string type = null)

Get indexed properties.

For a given account and document ID (page ID, blog post ID, HubDB row ID, etc.), return all indexed data for that document. This is useful when debugging why a particular document is not returned from a custom search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3SiteSearchIndexedDataContentIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicApi(config);
            var contentId = "contentId_example";  // string | ID of the target document when searching for indexed properties.
            var type = "LANDING_PAGE";  // string | The type of document. Can be one of `SITE_PAGE`, `BLOG_POST`, or `KNOWLEDGE_ARTICLE`. (optional) 

            try
            {
                // Get indexed properties.
                IndexedData result = apiInstance.GetCmsV3SiteSearchIndexedDataContentIdGetById(contentId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicApi.GetCmsV3SiteSearchIndexedDataContentIdGetById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentId** | **string**| ID of the target document when searching for indexed properties. | 
 **type** | **string**| The type of document. Can be one of &#x60;SITE_PAGE&#x60;, &#x60;BLOG_POST&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;. | [optional] 

### Return type

[**IndexedData**](IndexedData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcmsv3sitesearchsearchsearch"></a>
# **GetCmsV3SiteSearchSearchSearch**
> PublicSearchResults GetCmsV3SiteSearchSearchSearch (string q = null, int? limit = null, int? offset = null, string language = null, bool? matchPrefix = null, bool? autocomplete = null, decimal? popularityBoost = null, decimal? boostLimit = null, decimal? minScore = null, string boostRecent = null, long? tableId = null, string hubdbQuery = null, List<string> domain = null, List<string> type = null, List<string> pathPrefix = null, List<string> property = null, string length = null, List<long> groupId = null)

Search your site.

Returns any website content matching the given search criteria for a given HubSpot account. Searches can be filtered by content type, domain, or URL path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3SiteSearchSearchSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicApi(config);
            var q = "q_example";  // string | The term to search for. (optional) 
            var limit = 56;  // int? | Specifies the number of results to be returned in a single response. Defaults to `10`. Maximum value is `100`. (optional) 
            var offset = 56;  // int? | Used to page through the results. If there are more results than specified by the `limit` parameter, you will need to use the value of offset returned in the previous request to get the next set of results. (optional) 
            var language = "af";  // string | Specifies the language of content to be searched. This value must be a valid [ISO 639-1 language code](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `es` for Spanish) (optional) 
            var matchPrefix = true;  // bool? | Inverts the behavior of the pathPrefix filter when set to `false`. Defaults to `true`. (optional) 
            var autocomplete = true;  // bool? | Specifies whether or not you are showing autocomplete results. Defaults to false. (optional) 
            var popularityBoost = 8.14D;  // decimal? | Specifies how strongly a result is boosted based on its view count. Defaults to 1.0. (optional) 
            var boostLimit = 8.14D;  // decimal? | Specifies the maximum amount a result will be boosted based on its view count. Defaults to 5.0. Read more about elasticsearch boosting [here](https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-boost.html). (optional) 
            var minScore = 8.14D;  // decimal? | Specifies the minimum search score threshold for returned results. This value is intentionally set low by default in order to return many results. Increase this for higher precision, but less recall. (optional) 
            var boostRecent = "boostRecent_example";  // string | Specifies a relative time window where scores of documents published outside this time window decay. This can only be used for blog posts. For example, boostRecent=10d will boost documents published within the last 10 days. Supported timeunits are ms (milliseconds), s (seconds), m (minutes), h (hours), d (days). (optional) 
            var tableId = 789L;  // long? | Specifies a specific HubDB table to search. Only returns results from the specified table. Can be used in tandem with the `hubdbQuery` parameter to further filter results. (optional) 
            var hubdbQuery = "hubdbQuery_example";  // string | Specify a HubDB query to further filter the search results. (optional) 
            var domain = new List<string>(); // List<string> | A domain to match search results for. Multiple domains can be provided with &. (optional) 
            var type = new List<string>(); // List<string> | Specifies the type of content to search. Can be one or more of SITE_PAGE, LANDING_PAGE, BLOG_POST, LISTING_PAGE, and KNOWLEDGE_ARTICLE. Defaults to all content types except LANDING_PAGE and KNOWLEDGE_ARTICLE (optional) 
            var pathPrefix = new List<string>(); // List<string> | Specifies a path prefix to filter search results. Will only return results with URL paths that start with the specified parameter. Can be used multiple times. (optional) 
            var property = new List<string>(); // List<string> | Specifies which properties to include in the search. Options include `title`, `description`, and `html`. All properties will be searched by default. (optional) 
            var length = "SHORT";  // string | Specifies the length of the search results. Can be set to `LONG` or `SHORT`. `SHORT` will return the first 128 characters of the content's meta description. `LONG` will build a more detailed content snippet based on the html/content of the page. (optional) 
            var groupId = new List<long>(); // List<long> | Specifies which blog(s) to be searched by blog ID. Can be used multiple times to search more than one blog. (optional) 

            try
            {
                // Search your site.
                PublicSearchResults result = apiInstance.GetCmsV3SiteSearchSearchSearch(q, limit, offset, language, matchPrefix, autocomplete, popularityBoost, boostLimit, minScore, boostRecent, tableId, hubdbQuery, domain, type, pathPrefix, property, length, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicApi.GetCmsV3SiteSearchSearchSearch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The term to search for. | [optional] 
 **limit** | **int?**| Specifies the number of results to be returned in a single response. Defaults to &#x60;10&#x60;. Maximum value is &#x60;100&#x60;. | [optional] 
 **offset** | **int?**| Used to page through the results. If there are more results than specified by the &#x60;limit&#x60; parameter, you will need to use the value of offset returned in the previous request to get the next set of results. | [optional] 
 **language** | **string**| Specifies the language of content to be searched. This value must be a valid [ISO 639-1 language code](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. &#x60;es&#x60; for Spanish) | [optional] 
 **matchPrefix** | **bool?**| Inverts the behavior of the pathPrefix filter when set to &#x60;false&#x60;. Defaults to &#x60;true&#x60;. | [optional] 
 **autocomplete** | **bool?**| Specifies whether or not you are showing autocomplete results. Defaults to false. | [optional] 
 **popularityBoost** | **decimal?**| Specifies how strongly a result is boosted based on its view count. Defaults to 1.0. | [optional] 
 **boostLimit** | **decimal?**| Specifies the maximum amount a result will be boosted based on its view count. Defaults to 5.0. Read more about elasticsearch boosting [here](https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-boost.html). | [optional] 
 **minScore** | **decimal?**| Specifies the minimum search score threshold for returned results. This value is intentionally set low by default in order to return many results. Increase this for higher precision, but less recall. | [optional] 
 **boostRecent** | **string**| Specifies a relative time window where scores of documents published outside this time window decay. This can only be used for blog posts. For example, boostRecent&#x3D;10d will boost documents published within the last 10 days. Supported timeunits are ms (milliseconds), s (seconds), m (minutes), h (hours), d (days). | [optional] 
 **tableId** | **long?**| Specifies a specific HubDB table to search. Only returns results from the specified table. Can be used in tandem with the &#x60;hubdbQuery&#x60; parameter to further filter results. | [optional] 
 **hubdbQuery** | **string**| Specify a HubDB query to further filter the search results. | [optional] 
 **domain** | [**List&lt;string&gt;**](string.md)| A domain to match search results for. Multiple domains can be provided with &amp;. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Specifies the type of content to search. Can be one or more of SITE_PAGE, LANDING_PAGE, BLOG_POST, LISTING_PAGE, and KNOWLEDGE_ARTICLE. Defaults to all content types except LANDING_PAGE and KNOWLEDGE_ARTICLE | [optional] 
 **pathPrefix** | [**List&lt;string&gt;**](string.md)| Specifies a path prefix to filter search results. Will only return results with URL paths that start with the specified parameter. Can be used multiple times. | [optional] 
 **property** | [**List&lt;string&gt;**](string.md)| Specifies which properties to include in the search. Options include &#x60;title&#x60;, &#x60;description&#x60;, and &#x60;html&#x60;. All properties will be searched by default. | [optional] 
 **length** | **string**| Specifies the length of the search results. Can be set to &#x60;LONG&#x60; or &#x60;SHORT&#x60;. &#x60;SHORT&#x60; will return the first 128 characters of the content&#39;s meta description. &#x60;LONG&#x60; will build a more detailed content snippet based on the html/content of the page. | [optional] 
 **groupId** | [**List&lt;long&gt;**](long.md)| Specifies which blog(s) to be searched by blog ID. Can be used multiple times to search more than one blog. | [optional] 

### Return type

[**PublicSearchResults**](PublicSearchResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

