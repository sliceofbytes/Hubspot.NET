# HubSpot.NET.Api.StatusApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus**](StatusApi.md#getcommunicationpreferencesv3statusemailemailaddressgetemailstatus) | **GET** /communication-preferences/v3/status/email/{emailAddress} | Get subscription statuses for a contact
[**PostCommunicationPreferencesV3SubscribeSubscribe**](StatusApi.md#postcommunicationpreferencesv3subscribesubscribe) | **POST** /communication-preferences/v3/subscribe | Subscribe a contact
[**PostCommunicationPreferencesV3UnsubscribeUnsubscribe**](StatusApi.md#postcommunicationpreferencesv3unsubscribeunsubscribe) | **POST** /communication-preferences/v3/unsubscribe | Unsubscribe a contact


<a name="getcommunicationpreferencesv3statusemailemailaddressgetemailstatus"></a>
# **GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus**
> PublicSubscriptionStatusesResponse GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus (string emailAddress)

Get subscription statuses for a contact

Returns a list of subscriptions and their status for a given contact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new StatusApi(config);
            var emailAddress = "emailAddress_example";  // string | 

            try
            {
                // Get subscription statuses for a contact
                PublicSubscriptionStatusesResponse result = apiInstance.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus(emailAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus: " + e.Message );
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
 **emailAddress** | **string**|  | 

### Return type

[**PublicSubscriptionStatusesResponse**](PublicSubscriptionStatusesResponse.md)

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

<a name="postcommunicationpreferencesv3subscribesubscribe"></a>
# **PostCommunicationPreferencesV3SubscribeSubscribe**
> PublicSubscriptionStatus PostCommunicationPreferencesV3SubscribeSubscribe (PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)

Subscribe a contact

Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCommunicationPreferencesV3SubscribeSubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new StatusApi(config);
            var publicUpdateSubscriptionStatusRequest = new PublicUpdateSubscriptionStatusRequest(); // PublicUpdateSubscriptionStatusRequest | 

            try
            {
                // Subscribe a contact
                PublicSubscriptionStatus result = apiInstance.PostCommunicationPreferencesV3SubscribeSubscribe(publicUpdateSubscriptionStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3SubscribeSubscribe: " + e.Message );
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
 **publicUpdateSubscriptionStatusRequest** | [**PublicUpdateSubscriptionStatusRequest**](PublicUpdateSubscriptionStatusRequest.md)|  | 

### Return type

[**PublicSubscriptionStatus**](PublicSubscriptionStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcommunicationpreferencesv3unsubscribeunsubscribe"></a>
# **PostCommunicationPreferencesV3UnsubscribeUnsubscribe**
> PublicSubscriptionStatus PostCommunicationPreferencesV3UnsubscribeUnsubscribe (PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)

Unsubscribe a contact

Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCommunicationPreferencesV3UnsubscribeUnsubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new StatusApi(config);
            var publicUpdateSubscriptionStatusRequest = new PublicUpdateSubscriptionStatusRequest(); // PublicUpdateSubscriptionStatusRequest | 

            try
            {
                // Unsubscribe a contact
                PublicSubscriptionStatus result = apiInstance.PostCommunicationPreferencesV3UnsubscribeUnsubscribe(publicUpdateSubscriptionStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3UnsubscribeUnsubscribe: " + e.Message );
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
 **publicUpdateSubscriptionStatusRequest** | [**PublicUpdateSubscriptionStatusRequest**](PublicUpdateSubscriptionStatusRequest.md)|  | 

### Return type

[**PublicSubscriptionStatus**](PublicSubscriptionStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

