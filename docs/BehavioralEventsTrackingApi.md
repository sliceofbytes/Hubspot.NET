# HubSpot.NET.Api.BehavioralEventsTrackingApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostEventsV3Send**](BehavioralEventsTrackingApi.md#posteventsv3send) | **POST** /events/v3/send | Sends Custom Behavioral Event


<a name="posteventsv3send"></a>
# **PostEventsV3Send**
> void PostEventsV3Send (BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest)

Sends Custom Behavioral Event

Endpoint to send an instance of a behavioral event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostEventsV3SendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BehavioralEventsTrackingApi(config);
            var behavioralEventHttpCompletionRequest = new BehavioralEventHttpCompletionRequest(); // BehavioralEventHttpCompletionRequest | 

            try
            {
                // Sends Custom Behavioral Event
                apiInstance.PostEventsV3Send(behavioralEventHttpCompletionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BehavioralEventsTrackingApi.PostEventsV3Send: " + e.Message );
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
 **behavioralEventHttpCompletionRequest** | [**BehavioralEventHttpCompletionRequest**](BehavioralEventHttpCompletionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

