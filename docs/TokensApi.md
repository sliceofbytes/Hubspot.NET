# HubSpot.NET.Api.TokensApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchive**](TokensApi.md#deleteintegratorstimelinev3appideventtemplateseventtemplateidtokenstokennamearchive) | **DELETE** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId}/tokens/{tokenName} | Removes a token from the event template
[**PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreate**](TokensApi.md#postintegratorstimelinev3appideventtemplateseventtemplateidtokenscreate) | **POST** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId}/tokens | Adds a token to an existing event template
[**PostOauthV1TokenCreateToken**](TokensApi.md#postoauthv1tokencreatetoken) | **POST** /oauth/v1/token | 
[**PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdate**](TokensApi.md#putintegratorstimelinev3appideventtemplateseventtemplateidtokenstokennameupdate) | **PUT** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId}/tokens/{tokenName} | Updates an existing token on an event template


<a name="deleteintegratorstimelinev3appideventtemplateseventtemplateidtokenstokennamearchive"></a>
# **DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchive**
> void DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchive (string eventTemplateId, string tokenName, int appId)

Removes a token from the event template

This will remove the token from an existing template. Existing events and CRM objects will still retain the token and its mapped object properties, but new ones will not.  The timeline will still display this property for older CRM objects if it's still referenced in the template `Markdown`. New events will not.  Any lists or reports referencing deleted tokens will no longer return new contacts, but old ones will still exist in the lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TokensApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var tokenName = "tokenName_example";  // string | The token name.
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Removes a token from the event template
                apiInstance.DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchive(eventTemplateId, tokenName, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameArchive: " + e.Message );
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
 **eventTemplateId** | **string**| The event template ID. | 
 **tokenName** | **string**| The token name. | 
 **appId** | **int**| The ID of the target app. | 

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

<a name="postintegratorstimelinev3appideventtemplateseventtemplateidtokenscreate"></a>
# **PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreate**
> TimelineEventTemplateToken PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreate (string eventTemplateId, int appId, TimelineEventTemplateToken timelineEventTemplateToken)

Adds a token to an existing event template

Once you've defined an event template, it's likely that you'll want to define tokens for it as well. You can do this on the event template itself or update individual tokens here.  Event type tokens allow you to attach custom data to events displayed in a timeline or used for list segmentation.  You can also use `objectPropertyName` to associate any CRM object properties. This will allow you to fully build out CRM objects.  Token names should be unique across the template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TokensApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var appId = 56;  // int | The ID of the target app.
            var timelineEventTemplateToken = new TimelineEventTemplateToken(); // TimelineEventTemplateToken | The new token definition.

            try
            {
                // Adds a token to an existing event template
                TimelineEventTemplateToken result = apiInstance.PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreate(eventTemplateId, appId, timelineEventTemplateToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.PostIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensCreate: " + e.Message );
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
 **eventTemplateId** | **string**| The event template ID. | 
 **appId** | **int**| The ID of the target app. | 
 **timelineEventTemplateToken** | [**TimelineEventTemplateToken**](TimelineEventTemplateToken.md)| The new token definition. | 

### Return type

[**TimelineEventTemplateToken**](TimelineEventTemplateToken.md)

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

<a name="postoauthv1tokencreatetoken"></a>
# **PostOauthV1TokenCreateToken**
> TokenResponseIF PostOauthV1TokenCreateToken (string grantType = null, string code = null, string redirectUri = null, string clientId = null, string clientSecret = null, string refreshToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostOauthV1TokenCreateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TokensApi(config);
            var grantType = "authorization_code";  // string |  (optional) 
            var code = "code_example";  // string |  (optional) 
            var redirectUri = "redirectUri_example";  // string |  (optional) 
            var clientId = "clientId_example";  // string |  (optional) 
            var clientSecret = "clientSecret_example";  // string |  (optional) 
            var refreshToken = "refreshToken_example";  // string |  (optional) 

            try
            {
                TokenResponseIF result = apiInstance.PostOauthV1TokenCreateToken(grantType, code, redirectUri, clientId, clientSecret, refreshToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.PostOauthV1TokenCreateToken: " + e.Message );
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
 **grantType** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 
 **redirectUri** | **string**|  | [optional] 
 **clientId** | **string**|  | [optional] 
 **clientSecret** | **string**|  | [optional] 
 **refreshToken** | **string**|  | [optional] 

### Return type

[**TokenResponseIF**](TokenResponseIF.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putintegratorstimelinev3appideventtemplateseventtemplateidtokenstokennameupdate"></a>
# **PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdate**
> TimelineEventTemplateToken PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdate (string eventTemplateId, string tokenName, int appId, TimelineEventTemplateTokenUpdateRequest timelineEventTemplateTokenUpdateRequest)

Updates an existing token on an event template

This will update the existing token on an event template. Name and type can't be changed on existing tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TokensApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var tokenName = "tokenName_example";  // string | The token name.
            var appId = 56;  // int | The ID of the target app.
            var timelineEventTemplateTokenUpdateRequest = new TimelineEventTemplateTokenUpdateRequest(); // TimelineEventTemplateTokenUpdateRequest | The updated token definition.

            try
            {
                // Updates an existing token on an event template
                TimelineEventTemplateToken result = apiInstance.PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdate(eventTemplateId, tokenName, appId, timelineEventTemplateTokenUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdTokensTokenNameUpdate: " + e.Message );
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
 **eventTemplateId** | **string**| The event template ID. | 
 **tokenName** | **string**| The token name. | 
 **appId** | **int**| The ID of the target app. | 
 **timelineEventTemplateTokenUpdateRequest** | [**TimelineEventTemplateTokenUpdateRequest**](TimelineEventTemplateTokenUpdateRequest.md)| The updated token definition. | 

### Return type

[**TimelineEventTemplateToken**](TimelineEventTemplateToken.md)

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

