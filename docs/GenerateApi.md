# HubSpot.NET.Api.GenerateApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostVisitorIdentificationV3TokensCreateGenerateToken**](GenerateApi.md#postvisitoridentificationv3tokenscreategeneratetoken) | **POST** /conversations/v3/visitor-identification/tokens/create | Generate a token


<a name="postvisitoridentificationv3tokenscreategeneratetoken"></a>
# **PostVisitorIdentificationV3TokensCreateGenerateToken**
> IdentificationTokenResponse PostVisitorIdentificationV3TokensCreateGenerateToken (IdentificationTokenGenerationRequest identificationTokenGenerationRequest)

Generate a token

Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostVisitorIdentificationV3TokensCreateGenerateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GenerateApi(config);
            var identificationTokenGenerationRequest = new IdentificationTokenGenerationRequest(); // IdentificationTokenGenerationRequest | 

            try
            {
                // Generate a token
                IdentificationTokenResponse result = apiInstance.PostVisitorIdentificationV3TokensCreateGenerateToken(identificationTokenGenerationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateApi.PostVisitorIdentificationV3TokensCreateGenerateToken: " + e.Message );
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
 **identificationTokenGenerationRequest** | [**IdentificationTokenGenerationRequest**](IdentificationTokenGenerationRequest.md)|  | 

### Return type

[**IdentificationTokenResponse**](IdentificationTokenResponse.md)

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

