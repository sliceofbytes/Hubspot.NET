# HubSpot.NET.Api.SubscriptionsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchive**](SubscriptionsApi.md#deletewebhooksv3appidsubscriptionssubscriptionidarchive) | **DELETE** /webhooks/v3/{appId}/subscriptions/{subscriptionId} | 
[**GetWebhooksV3AppIdSubscriptionsGetAll**](SubscriptionsApi.md#getwebhooksv3appidsubscriptionsgetall) | **GET** /webhooks/v3/{appId}/subscriptions | 
[**GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetById**](SubscriptionsApi.md#getwebhooksv3appidsubscriptionssubscriptionidgetbyid) | **GET** /webhooks/v3/{appId}/subscriptions/{subscriptionId} | 
[**PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdate**](SubscriptionsApi.md#patchwebhooksv3appidsubscriptionssubscriptionidupdate) | **PATCH** /webhooks/v3/{appId}/subscriptions/{subscriptionId} | 
[**PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatch**](SubscriptionsApi.md#postwebhooksv3appidsubscriptionsbatchupdateupdatebatch) | **POST** /webhooks/v3/{appId}/subscriptions/batch/update | 
[**PostWebhooksV3AppIdSubscriptionsCreate**](SubscriptionsApi.md#postwebhooksv3appidsubscriptionscreate) | **POST** /webhooks/v3/{appId}/subscriptions | 


<a name="deletewebhooksv3appidsubscriptionssubscriptionidarchive"></a>
# **DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchive**
> void DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchive (int subscriptionId, int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var subscriptionId = 56;  // int | 
            var appId = 56;  // int | 

            try
            {
                apiInstance.DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchive(subscriptionId, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteWebhooksV3AppIdSubscriptionsSubscriptionIdArchive: " + e.Message );
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
 **subscriptionId** | **int**|  | 
 **appId** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksv3appidsubscriptionsgetall"></a>
# **GetWebhooksV3AppIdSubscriptionsGetAll**
> SubscriptionListResponse GetWebhooksV3AppIdSubscriptionsGetAll (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetWebhooksV3AppIdSubscriptionsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var appId = 56;  // int | 

            try
            {
                SubscriptionListResponse result = apiInstance.GetWebhooksV3AppIdSubscriptionsGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetWebhooksV3AppIdSubscriptionsGetAll: " + e.Message );
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
 **appId** | **int**|  | 

### Return type

[**SubscriptionListResponse**](SubscriptionListResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksv3appidsubscriptionssubscriptionidgetbyid"></a>
# **GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetById**
> SubscriptionResponse GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetById (int subscriptionId, int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var subscriptionId = 56;  // int | 
            var appId = 56;  // int | 

            try
            {
                SubscriptionResponse result = apiInstance.GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetById(subscriptionId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetWebhooksV3AppIdSubscriptionsSubscriptionIdGetById: " + e.Message );
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
 **subscriptionId** | **int**|  | 
 **appId** | **int**|  | 

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchwebhooksv3appidsubscriptionssubscriptionidupdate"></a>
# **PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdate**
> SubscriptionResponse PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdate (int subscriptionId, int appId, SubscriptionPatchRequest subscriptionPatchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var subscriptionId = 56;  // int | 
            var appId = 56;  // int | 
            var subscriptionPatchRequest = new SubscriptionPatchRequest(); // SubscriptionPatchRequest | 

            try
            {
                SubscriptionResponse result = apiInstance.PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdate(subscriptionId, appId, subscriptionPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PatchWebhooksV3AppIdSubscriptionsSubscriptionIdUpdate: " + e.Message );
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
 **subscriptionId** | **int**|  | 
 **appId** | **int**|  | 
 **subscriptionPatchRequest** | [**SubscriptionPatchRequest**](SubscriptionPatchRequest.md)|  | 

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwebhooksv3appidsubscriptionsbatchupdateupdatebatch"></a>
# **PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatch**
> BatchResponseSubscriptionResponse PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatch (int appId, BatchInputSubscriptionBatchUpdateRequest batchInputSubscriptionBatchUpdateRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var appId = 56;  // int | 
            var batchInputSubscriptionBatchUpdateRequest = new BatchInputSubscriptionBatchUpdateRequest(); // BatchInputSubscriptionBatchUpdateRequest | 

            try
            {
                BatchResponseSubscriptionResponse result = apiInstance.PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatch(appId, batchInputSubscriptionBatchUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PostWebhooksV3AppIdSubscriptionsBatchUpdateUpdateBatch: " + e.Message );
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
 **appId** | **int**|  | 
 **batchInputSubscriptionBatchUpdateRequest** | [**BatchInputSubscriptionBatchUpdateRequest**](BatchInputSubscriptionBatchUpdateRequest.md)|  | 

### Return type

[**BatchResponseSubscriptionResponse**](BatchResponseSubscriptionResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwebhooksv3appidsubscriptionscreate"></a>
# **PostWebhooksV3AppIdSubscriptionsCreate**
> SubscriptionResponse PostWebhooksV3AppIdSubscriptionsCreate (int appId, SubscriptionCreateRequest subscriptionCreateRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostWebhooksV3AppIdSubscriptionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SubscriptionsApi(config);
            var appId = 56;  // int | 
            var subscriptionCreateRequest = new SubscriptionCreateRequest(); // SubscriptionCreateRequest | 

            try
            {
                SubscriptionResponse result = apiInstance.PostWebhooksV3AppIdSubscriptionsCreate(appId, subscriptionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PostWebhooksV3AppIdSubscriptionsCreate: " + e.Message );
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
 **appId** | **int**|  | 
 **subscriptionCreateRequest** | [**SubscriptionCreateRequest**](SubscriptionCreateRequest.md)|  | 

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

