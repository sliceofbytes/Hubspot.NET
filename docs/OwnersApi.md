# HubSpot.NET.Api.OwnersApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3OwnersGetPage**](OwnersApi.md#getcrmv3ownersgetpage) | **GET** /crm/v3/owners/ | Get a page of owners
[**GetCrmV3OwnersOwnerIdGetById**](OwnersApi.md#getcrmv3ownersowneridgetbyid) | **GET** /crm/v3/owners/{ownerId} | Read an owner by given &#x60;id&#x60; or &#x60;userId&#x60;


<a name="getcrmv3ownersgetpage"></a>
# **GetCrmV3OwnersGetPage**
> CollectionResponsePublicOwnerForwardPaging GetCrmV3OwnersGetPage (string email = null, string after = null, int? limit = null, bool? archived = null)

Get a page of owners

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3OwnersGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new OwnersApi(config);
            var email = "email_example";  // string | Filter by email address (optional) (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 100;  // int? | The maximum number of results to display per page. (optional)  (default to 100)
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Get a page of owners
                CollectionResponsePublicOwnerForwardPaging result = apiInstance.GetCrmV3OwnersGetPage(email, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OwnersApi.GetCrmV3OwnersGetPage: " + e.Message );
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
 **email** | **string**| Filter by email address (optional) | [optional] 
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **limit** | **int?**| The maximum number of results to display per page. | [optional] [default to 100]
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**CollectionResponsePublicOwnerForwardPaging**](CollectionResponsePublicOwnerForwardPaging.md)

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

<a name="getcrmv3ownersowneridgetbyid"></a>
# **GetCrmV3OwnersOwnerIdGetById**
> PublicOwner GetCrmV3OwnersOwnerIdGetById (int ownerId, string idProperty = null, bool? archived = null)

Read an owner by given `id` or `userId`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3OwnersOwnerIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new OwnersApi(config);
            var ownerId = 56;  // int | 
            var idProperty = "id";  // string |  (optional)  (default to id)
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read an owner by given `id` or `userId`
                PublicOwner result = apiInstance.GetCrmV3OwnersOwnerIdGetById(ownerId, idProperty, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OwnersApi.GetCrmV3OwnersOwnerIdGetById: " + e.Message );
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
 **ownerId** | **int**|  | 
 **idProperty** | **string**|  | [optional] [default to id]
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**PublicOwner**](PublicOwner.md)

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

