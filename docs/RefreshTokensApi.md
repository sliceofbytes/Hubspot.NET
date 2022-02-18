# HubSpot.NET.Api.RefreshTokensApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOauthV1RefreshTokensTokenArchiveRefreshToken**](RefreshTokensApi.md#deleteoauthv1refreshtokenstokenarchiverefreshtoken) | **DELETE** /oauth/v1/refresh-tokens/{token} | 
[**GetOauthV1RefreshTokensTokenGetRefreshToken**](RefreshTokensApi.md#getoauthv1refreshtokenstokengetrefreshtoken) | **GET** /oauth/v1/refresh-tokens/{token} | 


<a name="deleteoauthv1refreshtokenstokenarchiverefreshtoken"></a>
# **DeleteOauthV1RefreshTokensTokenArchiveRefreshToken**
> Error DeleteOauthV1RefreshTokensTokenArchiveRefreshToken (string token)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RefreshTokensApi(config);
            var token = "token_example";  // string | 

            try
            {
                Error result = apiInstance.DeleteOauthV1RefreshTokensTokenArchiveRefreshToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefreshTokensApi.DeleteOauthV1RefreshTokensTokenArchiveRefreshToken: " + e.Message );
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

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthv1refreshtokenstokengetrefreshtoken"></a>
# **GetOauthV1RefreshTokensTokenGetRefreshToken**
> RefreshTokenInfoResponse GetOauthV1RefreshTokensTokenGetRefreshToken (string token)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetOauthV1RefreshTokensTokenGetRefreshTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RefreshTokensApi(config);
            var token = "token_example";  // string | 

            try
            {
                RefreshTokenInfoResponse result = apiInstance.GetOauthV1RefreshTokensTokenGetRefreshToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefreshTokensApi.GetOauthV1RefreshTokensTokenGetRefreshToken: " + e.Message );
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

[**RefreshTokenInfoResponse**](RefreshTokenInfoResponse.md)

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

