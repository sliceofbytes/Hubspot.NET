# HubSpot.NET.Api.SubscriberStateChangesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsert**](SubscriberStateChangesApi.md#postmarketingv3marketingeventseventsexternaleventidsubscriberstateemailupsert) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/{subscriberState}/email-upsert | Record
[**PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsert**](SubscriberStateChangesApi.md#postmarketingv3marketingeventseventsexternaleventidsubscriberstateupsert) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/{subscriberState}/upsert | Record


<a name="postmarketingv3marketingeventseventsexternaleventidsubscriberstateemailupsert"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsert**
> Error PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsert (string externalEventId, string subscriberState, string externalAccountId, BatchInputMarketingEventEmailSubscriber batchInputMarketingEventEmailSubscriber)

Record

Record a subscription state between multiple HubSpot contacts and a marketing event, using contact email addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SubscriberStateChangesApi(config);
            var externalEventId = "externalEventId_example";  // string | The id of the marketing event
            var subscriberState = "subscriberState_example";  // string | The new subscriber state for the HubSpot contacts and the specified marketing event
            var externalAccountId = "externalAccountId_example";  // string | The account id associated with the marketing event
            var batchInputMarketingEventEmailSubscriber = new BatchInputMarketingEventEmailSubscriber(); // BatchInputMarketingEventEmailSubscriber | The details of the contacts to subscribe to the event

            try
            {
                // Record
                Error result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsert(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventEmailSubscriber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriberStateChangesApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsert: " + e.Message );
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
 **externalEventId** | **string**| The id of the marketing event | 
 **subscriberState** | **string**| The new subscriber state for the HubSpot contacts and the specified marketing event | 
 **externalAccountId** | **string**| The account id associated with the marketing event | 
 **batchInputMarketingEventEmailSubscriber** | [**BatchInputMarketingEventEmailSubscriber**](BatchInputMarketingEventEmailSubscriber.md)| The details of the contacts to subscribe to the event | 

### Return type

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmarketingv3marketingeventseventsexternaleventidsubscriberstateupsert"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsert**
> Error PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsert (string externalEventId, string subscriberState, string externalAccountId, BatchInputMarketingEventSubscriber batchInputMarketingEventSubscriber)

Record

Record a subscription state between multiple HubSpot contacts and a marketing event, using HubSpot contact ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SubscriberStateChangesApi(config);
            var externalEventId = "externalEventId_example";  // string | The id of the marketing event
            var subscriberState = "subscriberState_example";  // string | The new subscriber state for the HubSpot contacts and the specified marketing event
            var externalAccountId = "externalAccountId_example";  // string | The account id associated with the marketing event
            var batchInputMarketingEventSubscriber = new BatchInputMarketingEventSubscriber(); // BatchInputMarketingEventSubscriber | The details of the contacts to subscribe to the event

            try
            {
                // Record
                Error result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsert(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventSubscriber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriberStateChangesApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsert: " + e.Message );
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
 **externalEventId** | **string**| The id of the marketing event | 
 **subscriberState** | **string**| The new subscriber state for the HubSpot contacts and the specified marketing event | 
 **externalAccountId** | **string**| The account id associated with the marketing event | 
 **batchInputMarketingEventSubscriber** | [**BatchInputMarketingEventSubscriber**](BatchInputMarketingEventSubscriber.md)| The details of the contacts to subscribe to the event | 

### Return type

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

