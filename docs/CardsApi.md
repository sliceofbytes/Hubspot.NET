# HubSpot.NET.Api.CardsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmV3ExtensionsCardsAppIdCardIdArchive**](CardsApi.md#deletecrmv3extensionscardsappidcardidarchive) | **DELETE** /crm/v3/extensions/cards/{appId}/{cardId} | Delete a card
[**GetCrmV3ExtensionsCardsAppIdCardIdGetById**](CardsApi.md#getcrmv3extensionscardsappidcardidgetbyid) | **GET** /crm/v3/extensions/cards/{appId}/{cardId} | Get a card.
[**GetCrmV3ExtensionsCardsAppIdGetAll**](CardsApi.md#getcrmv3extensionscardsappidgetall) | **GET** /crm/v3/extensions/cards/{appId} | Get all cards
[**PatchCrmV3ExtensionsCardsAppIdCardIdUpdate**](CardsApi.md#patchcrmv3extensionscardsappidcardidupdate) | **PATCH** /crm/v3/extensions/cards/{appId}/{cardId} | Update a card
[**PostCrmV3ExtensionsCardsAppIdCreate**](CardsApi.md#postcrmv3extensionscardsappidcreate) | **POST** /crm/v3/extensions/cards/{appId} | Create a new card


<a name="deletecrmv3extensionscardsappidcardidarchive"></a>
# **DeleteCrmV3ExtensionsCardsAppIdCardIdArchive**
> void DeleteCrmV3ExtensionsCardsAppIdCardIdArchive (int appId, string cardId)

Delete a card

Permanently deletes a card definition with the given ID. Once deleted, data fetch requests for this card will no longer be sent to your service. This can't be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsCardsAppIdCardIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new CardsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var cardId = "cardId_example";  // string | The ID of the card to delete.

            try
            {
                // Delete a card
                apiInstance.DeleteCrmV3ExtensionsCardsAppIdCardIdArchive(appId, cardId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.DeleteCrmV3ExtensionsCardsAppIdCardIdArchive: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **cardId** | **string**| The ID of the card to delete. | 

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

<a name="getcrmv3extensionscardsappidcardidgetbyid"></a>
# **GetCrmV3ExtensionsCardsAppIdCardIdGetById**
> CardResponse GetCrmV3ExtensionsCardsAppIdCardIdGetById (int appId, string cardId)

Get a card.

Returns the definition for a card with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsCardsAppIdCardIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new CardsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var cardId = "cardId_example";  // string | The ID of the target card.

            try
            {
                // Get a card.
                CardResponse result = apiInstance.GetCrmV3ExtensionsCardsAppIdCardIdGetById(appId, cardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetCrmV3ExtensionsCardsAppIdCardIdGetById: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **cardId** | **string**| The ID of the target card. | 

### Return type

[**CardResponse**](CardResponse.md)

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

<a name="getcrmv3extensionscardsappidgetall"></a>
# **GetCrmV3ExtensionsCardsAppIdGetAll**
> CardListResponse GetCrmV3ExtensionsCardsAppIdGetAll (int appId)

Get all cards

Returns a list of cards for a given app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsCardsAppIdGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new CardsApi(config);
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Get all cards
                CardListResponse result = apiInstance.GetCrmV3ExtensionsCardsAppIdGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetCrmV3ExtensionsCardsAppIdGetAll: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 

### Return type

[**CardListResponse**](CardListResponse.md)

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

<a name="patchcrmv3extensionscardsappidcardidupdate"></a>
# **PatchCrmV3ExtensionsCardsAppIdCardIdUpdate**
> CardResponse PatchCrmV3ExtensionsCardsAppIdCardIdUpdate (int appId, string cardId, CardPatchRequest cardPatchRequest)

Update a card

Update a card definition with new details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3ExtensionsCardsAppIdCardIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new CardsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var cardId = "cardId_example";  // string | The ID of the card to update.
            var cardPatchRequest = new CardPatchRequest(); // CardPatchRequest | Card definition fields to be updated.

            try
            {
                // Update a card
                CardResponse result = apiInstance.PatchCrmV3ExtensionsCardsAppIdCardIdUpdate(appId, cardId, cardPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.PatchCrmV3ExtensionsCardsAppIdCardIdUpdate: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **cardId** | **string**| The ID of the card to update. | 
 **cardPatchRequest** | [**CardPatchRequest**](CardPatchRequest.md)| Card definition fields to be updated. | 

### Return type

[**CardResponse**](CardResponse.md)

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

<a name="postcrmv3extensionscardsappidcreate"></a>
# **PostCrmV3ExtensionsCardsAppIdCreate**
> CardResponse PostCrmV3ExtensionsCardsAppIdCreate (int appId, CardCreateRequest cardCreateRequest)

Create a new card

Defines a new card that will become active on an account when this app is installed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ExtensionsCardsAppIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new CardsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var cardCreateRequest = new CardCreateRequest(); // CardCreateRequest | The new card definition.

            try
            {
                // Create a new card
                CardResponse result = apiInstance.PostCrmV3ExtensionsCardsAppIdCreate(appId, cardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.PostCrmV3ExtensionsCardsAppIdCreate: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **cardCreateRequest** | [**CardCreateRequest**](CardCreateRequest.md)| The new card definition. | 

### Return type

[**CardResponse**](CardResponse.md)

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

