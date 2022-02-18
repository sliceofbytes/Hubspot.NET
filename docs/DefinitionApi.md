# HubSpot.NET.Api.DefinitionApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCommunicationPreferencesV3DefinitionsGetPage**](DefinitionApi.md#getcommunicationpreferencesv3definitionsgetpage) | **GET** /communication-preferences/v3/definitions | Get subscription definitions


<a name="getcommunicationpreferencesv3definitionsgetpage"></a>
# **GetCommunicationPreferencesV3DefinitionsGetPage**
> SubscriptionDefinitionsResponse GetCommunicationPreferencesV3DefinitionsGetPage ()

Get subscription definitions

Get a list of all subscription definitions for the portal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCommunicationPreferencesV3DefinitionsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new DefinitionApi(config);

            try
            {
                // Get subscription definitions
                SubscriptionDefinitionsResponse result = apiInstance.GetCommunicationPreferencesV3DefinitionsGetPage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionApi.GetCommunicationPreferencesV3DefinitionsGetPage: " + e.Message );
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

[**SubscriptionDefinitionsResponse**](SubscriptionDefinitionsResponse.md)

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

