# HubSpot.NET.Api.DomainsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCmsV3DomainsDomainIdGetById**](DomainsApi.md#getcmsv3domainsdomainidgetbyid) | **GET** /cms/v3/domains/{domainId} | Get a single domain
[**GetCmsV3DomainsGetPage**](DomainsApi.md#getcmsv3domainsgetpage) | **GET** /cms/v3/domains/ | Get current domains


<a name="getcmsv3domainsdomainidgetbyid"></a>
# **GetCmsV3DomainsDomainIdGetById**
> Domain GetCmsV3DomainsDomainIdGetById (string domainId, bool? archived = null)

Get a single domain

Returns a single domains with the id specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3DomainsDomainIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new DomainsApi(config);
            var domainId = "domainId_example";  // string | The unique ID of the domain.
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Get a single domain
                Domain result = apiInstance.GetCmsV3DomainsDomainIdGetById(domainId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsDomainIdGetById: " + e.Message );
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
 **domainId** | **string**| The unique ID of the domain. | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] 

### Return type

[**Domain**](Domain.md)

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

<a name="getcmsv3domainsgetpage"></a>
# **GetCmsV3DomainsGetPage**
> CollectionResponseWithTotalDomain GetCmsV3DomainsGetPage (long? createdAt = null, long? createdAfter = null, long? createdBefore = null, long? updatedAt = null, long? updatedAfter = null, long? updatedBefore = null, List<string> sort = null, List<string> properties = null, string after = null, string before = null, int? limit = null, bool? archived = null)

Get current domains

Returns all existing domains that have been created. Results can be limited and filtered by creation or updated date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3DomainsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new DomainsApi(config);
            var createdAt = 789L;  // long? | Only return domains created at this date. (optional) 
            var createdAfter = 789L;  // long? | Only return domains created after this date. (optional) 
            var createdBefore = 789L;  // long? | Only return domains created before this date. (optional) 
            var updatedAt = 789L;  // long? | Only return domains updated at this date. (optional) 
            var updatedAfter = 789L;  // long? | Only return domains updated after this date. (optional) 
            var updatedBefore = 789L;  // long? | Only return domains updated before this date. (optional) 
            var sort = new List<string>(); // List<string> |  (optional) 
            var properties = new List<string>(); // List<string> |  (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | Maximum number of results per page. (optional) 
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Get current domains
                CollectionResponseWithTotalDomain result = apiInstance.GetCmsV3DomainsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, properties, after, before, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsGetPage: " + e.Message );
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
 **createdAt** | **long?**| Only return domains created at this date. | [optional] 
 **createdAfter** | **long?**| Only return domains created after this date. | [optional] 
 **createdBefore** | **long?**| Only return domains created before this date. | [optional] 
 **updatedAt** | **long?**| Only return domains updated at this date. | [optional] 
 **updatedAfter** | **long?**| Only return domains updated after this date. | [optional] 
 **updatedBefore** | **long?**| Only return domains updated before this date. | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **properties** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **before** | **string**|  | [optional] 
 **limit** | **int?**| Maximum number of results per page. | [optional] 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] 

### Return type

[**CollectionResponseWithTotalDomain**](CollectionResponseWithTotalDomain.md)

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

