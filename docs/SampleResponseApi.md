# HubSpot.NET.Api.SampleResponseApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponse**](SampleResponseApi.md#getcrmv3extensionscardssampleresponsegetcardssampleresponse) | **GET** /crm/v3/extensions/cards/sample-response | Get sample card detail response


<a name="getcrmv3extensionscardssampleresponsegetcardssampleresponse"></a>
# **GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponse**
> IntegratorCardPayloadResponse GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponse ()

Get sample card detail response

Returns an example card detail response. This is the payload with displayed details for a card that will be shown to a user. An app should send this in response to the data fetch request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SampleResponseApi(config);

            try
            {
                // Get sample card detail response
                IntegratorCardPayloadResponse result = apiInstance.GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponse();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SampleResponseApi.GetCrmV3ExtensionsCardsSampleResponseGetCardsSampleResponse: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IntegratorCardPayloadResponse**](IntegratorCardPayloadResponse.md)

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

