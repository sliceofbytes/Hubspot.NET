# HubSpot.NET.Api.PublicSmtpTokensApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveToken**](PublicSmtpTokensApi.md#deletemarketingv3transactionalsmtptokenstokenidarchivetoken) | **DELETE** /marketing/v3/transactional/smtp-tokens/{tokenId} | Delete a single token by ID.
[**GetMarketingV3TransactionalSmtpTokensGetTokensPage**](PublicSmtpTokensApi.md#getmarketingv3transactionalsmtptokensgettokenspage) | **GET** /marketing/v3/transactional/smtp-tokens | Query SMTP API tokens by campaign name or an emailCampaignId.
[**GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenById**](PublicSmtpTokensApi.md#getmarketingv3transactionalsmtptokenstokenidgettokenbyid) | **GET** /marketing/v3/transactional/smtp-tokens/{tokenId} | Query a single token by ID.
[**PostMarketingV3TransactionalSmtpTokensCreateToken**](PublicSmtpTokensApi.md#postmarketingv3transactionalsmtptokenscreatetoken) | **POST** /marketing/v3/transactional/smtp-tokens | Create a SMTP API token.
[**PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPassword**](PublicSmtpTokensApi.md#postmarketingv3transactionalsmtptokenstokenidpasswordresetresetpassword) | **POST** /marketing/v3/transactional/smtp-tokens/{tokenId}/password-reset | Reset the password of an existing token.


<a name="deletemarketingv3transactionalsmtptokenstokenidarchivetoken"></a>
# **DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveToken**
> void DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveToken (string tokenId)

Delete a single token by ID.

Delete a single token by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicSmtpTokensApi(config);
            var tokenId = "tokenId_example";  // string | Identifier generated when a token is created.

            try
            {
                // Delete a single token by ID.
                apiInstance.DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveToken(tokenId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSmtpTokensApi.DeleteMarketingV3TransactionalSmtpTokensTokenIdArchiveToken: " + e.Message );
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
 **tokenId** | **string**| Identifier generated when a token is created. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketingv3transactionalsmtptokensgettokenspage"></a>
# **GetMarketingV3TransactionalSmtpTokensGetTokensPage**
> CollectionResponseSmtpApiTokenView GetMarketingV3TransactionalSmtpTokensGetTokensPage (string campaignName = null, string emailCampaignId = null, string after = null, int? limit = null)

Query SMTP API tokens by campaign name or an emailCampaignId.

Query multiple SMTP API tokens by campaign name or a single token by emailCampaignId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetMarketingV3TransactionalSmtpTokensGetTokensPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicSmtpTokensApi(config);
            var campaignName = "campaignName_example";  // string | A name for the campaign tied to the SMTP API token. (optional) 
            var emailCampaignId = "emailCampaignId_example";  // string | Identifier assigned to the campaign provided during the token creation. (optional) 
            var after = "after_example";  // string | Starting point to get the next set of results. (optional) 
            var limit = 56;  // int? | Maximum number of tokens to return. (optional) 

            try
            {
                // Query SMTP API tokens by campaign name or an emailCampaignId.
                CollectionResponseSmtpApiTokenView result = apiInstance.GetMarketingV3TransactionalSmtpTokensGetTokensPage(campaignName, emailCampaignId, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSmtpTokensApi.GetMarketingV3TransactionalSmtpTokensGetTokensPage: " + e.Message );
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
 **campaignName** | **string**| A name for the campaign tied to the SMTP API token. | [optional] 
 **emailCampaignId** | **string**| Identifier assigned to the campaign provided during the token creation. | [optional] 
 **after** | **string**| Starting point to get the next set of results. | [optional] 
 **limit** | **int?**| Maximum number of tokens to return. | [optional] 

### Return type

[**CollectionResponseSmtpApiTokenView**](CollectionResponseSmtpApiTokenView.md)

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

<a name="getmarketingv3transactionalsmtptokenstokenidgettokenbyid"></a>
# **GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenById**
> SmtpApiTokenView GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenById (string tokenId)

Query a single token by ID.

Query a single token by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicSmtpTokensApi(config);
            var tokenId = "tokenId_example";  // string | Identifier generated when a token is created.

            try
            {
                // Query a single token by ID.
                SmtpApiTokenView result = apiInstance.GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenById(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSmtpTokensApi.GetMarketingV3TransactionalSmtpTokensTokenIdGetTokenById: " + e.Message );
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
 **tokenId** | **string**| Identifier generated when a token is created. | 

### Return type

[**SmtpApiTokenView**](SmtpApiTokenView.md)

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

<a name="postmarketingv3transactionalsmtptokenscreatetoken"></a>
# **PostMarketingV3TransactionalSmtpTokensCreateToken**
> SmtpApiTokenView PostMarketingV3TransactionalSmtpTokensCreateToken (SmtpApiTokenRequestEgg smtpApiTokenRequestEgg = null)

Create a SMTP API token.

Create a SMTP API token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3TransactionalSmtpTokensCreateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicSmtpTokensApi(config);
            var smtpApiTokenRequestEgg = new SmtpApiTokenRequestEgg(); // SmtpApiTokenRequestEgg | A request object that includes the campaign name tied to the token and whether contacts should be created for recipients of emails. (optional) 

            try
            {
                // Create a SMTP API token.
                SmtpApiTokenView result = apiInstance.PostMarketingV3TransactionalSmtpTokensCreateToken(smtpApiTokenRequestEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSmtpTokensApi.PostMarketingV3TransactionalSmtpTokensCreateToken: " + e.Message );
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
 **smtpApiTokenRequestEgg** | [**SmtpApiTokenRequestEgg**](SmtpApiTokenRequestEgg.md)| A request object that includes the campaign name tied to the token and whether contacts should be created for recipients of emails. | [optional] 

### Return type

[**SmtpApiTokenView**](SmtpApiTokenView.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmarketingv3transactionalsmtptokenstokenidpasswordresetresetpassword"></a>
# **PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPassword**
> SmtpApiTokenView PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPassword (string tokenId)

Reset the password of an existing token.

Allows the creation of a replacement password for a given token. Once the password is successfully reset, the old password for the token will be invalid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicSmtpTokensApi(config);
            var tokenId = "tokenId_example";  // string | Identifier generated when a token is created.

            try
            {
                // Reset the password of an existing token.
                SmtpApiTokenView result = apiInstance.PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPassword(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSmtpTokensApi.PostMarketingV3TransactionalSmtpTokensTokenIdPasswordResetResetPassword: " + e.Message );
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
 **tokenId** | **string**| Identifier generated when a token is created. | 

### Return type

[**SmtpApiTokenView**](SmtpApiTokenView.md)

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

