# HubSpot.NET.Api.AccessTokensApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOauthV1AccessTokensTokenGetAccessToken**](AccessTokensApi.md#getoauthv1accesstokenstokengetaccesstoken) | **GET** /oauth/v1/access-tokens/{token} | 


<a name="getoauthv1accesstokenstokengetaccesstoken"></a>
# **GetOauthV1AccessTokensTokenGetAccessToken**
> AccessTokenInfoResponse GetOauthV1AccessTokensTokenGetAccessToken (string token)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetOauthV1AccessTokensTokenGetAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new AccessTokensApi(config);
            var token = "token_example";  // string | 

            try
            {
                AccessTokenInfoResponse result = apiInstance.GetOauthV1AccessTokensTokenGetAccessToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokensApi.GetOauthV1AccessTokensTokenGetAccessToken: " + e.Message );
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
 **token** | **string**|  | 

### Return type

[**AccessTokenInfoResponse**](AccessTokenInfoResponse.md)

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

