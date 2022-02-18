# HubSpot.NET.Api.PublicImportsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3ImportsImportIdErrorsGetErrors**](PublicImportsApi.md#getcrmv3importsimportiderrorsgeterrors) | **GET** /crm/v3/imports/{importId}/errors | 


<a name="getcrmv3importsimportiderrorsgeterrors"></a>
# **GetCrmV3ImportsImportIdErrorsGetErrors**
> CollectionResponsePublicImportErrorForwardPaging GetCrmV3ImportsImportIdErrorsGetErrors (long importId, string after = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ImportsImportIdErrorsGetErrorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicImportsApi(config);
            var importId = 789L;  // long | 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to display per page. (optional) 

            try
            {
                CollectionResponsePublicImportErrorForwardPaging result = apiInstance.GetCrmV3ImportsImportIdErrorsGetErrors(importId, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicImportsApi.GetCrmV3ImportsImportIdErrorsGetErrors: " + e.Message );
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
 **importId** | **long**|  | 
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **limit** | **int?**| The maximum number of results to display per page. | [optional] 

### Return type

[**CollectionResponsePublicImportErrorForwardPaging**](CollectionResponsePublicImportErrorForwardPaging.md)

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

