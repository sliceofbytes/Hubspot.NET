# HubSpot.NET.Api.SettingsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmV3ExtensionsCallingAppIdSettingsArchive**](SettingsApi.md#deletecrmv3extensionscallingappidsettingsarchive) | **DELETE** /crm/v3/extensions/calling/{appId}/settings | Delete calling settings
[**DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive**](SettingsApi.md#deletecrmv3extensionsvideoconferencingsettingsappidarchive) | **DELETE** /crm/v3/extensions/videoconferencing/settings/{appId} | Delete settings
[**DeleteWebhooksV3AppIdSettingsClear**](SettingsApi.md#deletewebhooksv3appidsettingsclear) | **DELETE** /webhooks/v3/{appId}/settings | 
[**GetCrmV3ExtensionsAccountingSettingsAppIdGetById**](SettingsApi.md#getcrmv3extensionsaccountingsettingsappidgetbyid) | **GET** /crm/v3/extensions/accounting/settings/{appId} | Get URL settings
[**GetCrmV3ExtensionsCallingAppIdSettingsGetById**](SettingsApi.md#getcrmv3extensionscallingappidsettingsgetbyid) | **GET** /crm/v3/extensions/calling/{appId}/settings | Get calling settings
[**GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById**](SettingsApi.md#getcrmv3extensionsvideoconferencingsettingsappidgetbyid) | **GET** /crm/v3/extensions/videoconferencing/settings/{appId} | Get settings
[**GetMarketingV3MarketingEventsAppIdSettings**](SettingsApi.md#getmarketingv3marketingeventsappidsettings) | **GET** /marketing/v3/marketing-events/{appId}/settings | Retrieve the application settings
[**GetWebhooksV3AppIdSettingsGetAll**](SettingsApi.md#getwebhooksv3appidsettingsgetall) | **GET** /webhooks/v3/{appId}/settings | 
[**PatchCrmV3ExtensionsCallingAppIdSettingsUpdate**](SettingsApi.md#patchcrmv3extensionscallingappidsettingsupdate) | **PATCH** /crm/v3/extensions/calling/{appId}/settings | Update settings
[**PostCrmV3ExtensionsCallingAppIdSettingsCreate**](SettingsApi.md#postcrmv3extensionscallingappidsettingscreate) | **POST** /crm/v3/extensions/calling/{appId}/settings | Configure a calling extension
[**PostMarketingV3MarketingEventsAppIdSettings**](SettingsApi.md#postmarketingv3marketingeventsappidsettings) | **POST** /marketing/v3/marketing-events/{appId}/settings | Update the application settings
[**PutCrmV3ExtensionsAccountingSettingsAppIdReplace**](SettingsApi.md#putcrmv3extensionsaccountingsettingsappidreplace) | **PUT** /crm/v3/extensions/accounting/settings/{appId} | Add/Update URL Settings
[**PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace**](SettingsApi.md#putcrmv3extensionsvideoconferencingsettingsappidreplace) | **PUT** /crm/v3/extensions/videoconferencing/settings/{appId} | Update settings
[**PutWebhooksV3AppIdSettingsConfigure**](SettingsApi.md#putwebhooksv3appidsettingsconfigure) | **PUT** /webhooks/v3/{appId}/settings | 


<a name="deletecrmv3extensionscallingappidsettingsarchive"></a>
# **DeleteCrmV3ExtensionsCallingAppIdSettingsArchive**
> void DeleteCrmV3ExtensionsCallingAppIdSettingsArchive (int appId)

Delete calling settings

Deletes this calling extension. This will remove your service as an option for all connected accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Delete calling settings
                apiInstance.DeleteCrmV3ExtensionsCallingAppIdSettingsArchive(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsCallingAppIdSettingsArchive: " + e.Message );
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

<a name="deletecrmv3extensionsvideoconferencingsettingsappidarchive"></a>
# **DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive**
> void DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive (int appId)

Delete settings

Deletes the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Delete settings
                apiInstance.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive: " + e.Message );
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
 **appId** | **int**| The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. | 

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

<a name="deletewebhooksv3appidsettingsclear"></a>
# **DeleteWebhooksV3AppIdSettingsClear**
> void DeleteWebhooksV3AppIdSettingsClear (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteWebhooksV3AppIdSettingsClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 

            try
            {
                apiInstance.DeleteWebhooksV3AppIdSettingsClear(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteWebhooksV3AppIdSettingsClear: " + e.Message );
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
 **appId** | **int**|  | 

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

<a name="getcrmv3extensionsaccountingsettingsappidgetbyid"></a>
# **GetCrmV3ExtensionsAccountingSettingsAppIdGetById**
> AccountingAppSettings GetCrmV3ExtensionsAccountingSettingsAppIdGetById (int appId)

Get URL settings

Returns the URL settings for an accounting app with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Get URL settings
                AccountingAppSettings result = apiInstance.GetCrmV3ExtensionsAccountingSettingsAppIdGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsAccountingSettingsAppIdGetById: " + e.Message );
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
 **appId** | **int**| The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. | 

### Return type

[**AccountingAppSettings**](AccountingAppSettings.md)

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

<a name="getcrmv3extensionscallingappidsettingsgetbyid"></a>
# **GetCrmV3ExtensionsCallingAppIdSettingsGetById**
> CallingSettingsResponse GetCrmV3ExtensionsCallingAppIdSettingsGetById (int appId)

Get calling settings

Returns the calling extension settings configured for your app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsCallingAppIdSettingsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Get calling settings
                CallingSettingsResponse result = apiInstance.GetCrmV3ExtensionsCallingAppIdSettingsGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsCallingAppIdSettingsGetById: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 

### Return type

[**CallingSettingsResponse**](CallingSettingsResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcrmv3extensionsvideoconferencingsettingsappidgetbyid"></a>
# **GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById**
> ExternalSettings GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById (int appId)

Get settings

Return the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Get settings
                ExternalSettings result = apiInstance.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById: " + e.Message );
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
 **appId** | **int**| The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. | 

### Return type

[**ExternalSettings**](ExternalSettings.md)

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

<a name="getmarketingv3marketingeventsappidsettings"></a>
# **GetMarketingV3MarketingEventsAppIdSettings**
> EventDetailSettings GetMarketingV3MarketingEventsAppIdSettings (int appId)

Retrieve the application settings

Retrieve the current settings for the application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetMarketingV3MarketingEventsAppIdSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The id of the application to retrieve the settings for.

            try
            {
                // Retrieve the application settings
                EventDetailSettings result = apiInstance.GetMarketingV3MarketingEventsAppIdSettings(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetMarketingV3MarketingEventsAppIdSettings: " + e.Message );
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
 **appId** | **int**| The id of the application to retrieve the settings for. | 

### Return type

[**EventDetailSettings**](EventDetailSettings.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksv3appidsettingsgetall"></a>
# **GetWebhooksV3AppIdSettingsGetAll**
> SettingsResponse GetWebhooksV3AppIdSettingsGetAll (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetWebhooksV3AppIdSettingsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 

            try
            {
                SettingsResponse result = apiInstance.GetWebhooksV3AppIdSettingsGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetWebhooksV3AppIdSettingsGetAll: " + e.Message );
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
 **appId** | **int**|  | 

### Return type

[**SettingsResponse**](SettingsResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcrmv3extensionscallingappidsettingsupdate"></a>
# **PatchCrmV3ExtensionsCallingAppIdSettingsUpdate**
> CallingSettingsResponse PatchCrmV3ExtensionsCallingAppIdSettingsUpdate (int appId, SettingsPatchRequest settingsPatchRequest)

Update settings

Updates existing calling extension settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3ExtensionsCallingAppIdSettingsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var settingsPatchRequest = new SettingsPatchRequest(); // SettingsPatchRequest | Updated details for the settings.

            try
            {
                // Update settings
                CallingSettingsResponse result = apiInstance.PatchCrmV3ExtensionsCallingAppIdSettingsUpdate(appId, settingsPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PatchCrmV3ExtensionsCallingAppIdSettingsUpdate: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **settingsPatchRequest** | [**SettingsPatchRequest**](SettingsPatchRequest.md)| Updated details for the settings. | 

### Return type

[**CallingSettingsResponse**](CallingSettingsResponse.md)

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

<a name="postcrmv3extensionscallingappidsettingscreate"></a>
# **PostCrmV3ExtensionsCallingAppIdSettingsCreate**
> CallingSettingsResponse PostCrmV3ExtensionsCallingAppIdSettingsCreate (int appId, SettingsRequest settingsRequest)

Configure a calling extension

Used to set the menu label, target iframe URL, and dimensions for your calling extension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ExtensionsCallingAppIdSettingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the target app.
            var settingsRequest = new SettingsRequest(); // SettingsRequest | Settings state to create with.

            try
            {
                // Configure a calling extension
                CallingSettingsResponse result = apiInstance.PostCrmV3ExtensionsCallingAppIdSettingsCreate(appId, settingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PostCrmV3ExtensionsCallingAppIdSettingsCreate: " + e.Message );
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
 **appId** | **int**| The ID of the target app. | 
 **settingsRequest** | [**SettingsRequest**](SettingsRequest.md)| Settings state to create with. | 

### Return type

[**CallingSettingsResponse**](CallingSettingsResponse.md)

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

<a name="postmarketingv3marketingeventsappidsettings"></a>
# **PostMarketingV3MarketingEventsAppIdSettings**
> EventDetailSettings PostMarketingV3MarketingEventsAppIdSettings (int appId, EventDetailSettingsUrl eventDetailSettingsUrl)

Update the application settings

Create or update the current settings for the application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsAppIdSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The id of the application to update the settings for.
            var eventDetailSettingsUrl = new EventDetailSettingsUrl(); // EventDetailSettingsUrl | The new application settings

            try
            {
                // Update the application settings
                EventDetailSettings result = apiInstance.PostMarketingV3MarketingEventsAppIdSettings(appId, eventDetailSettingsUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PostMarketingV3MarketingEventsAppIdSettings: " + e.Message );
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
 **appId** | **int**| The id of the application to update the settings for. | 
 **eventDetailSettingsUrl** | [**EventDetailSettingsUrl**](EventDetailSettingsUrl.md)| The new application settings | 

### Return type

[**EventDetailSettings**](EventDetailSettings.md)

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

<a name="putcrmv3extensionsaccountingsettingsappidreplace"></a>
# **PutCrmV3ExtensionsAccountingSettingsAppIdReplace**
> void PutCrmV3ExtensionsAccountingSettingsAppIdReplace (int appId, AccountingAppSettings accountingAppSettings)

Add/Update URL Settings

Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the `https` protocol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCrmV3ExtensionsAccountingSettingsAppIdReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.
            var accountingAppSettings = new AccountingAppSettings(); // AccountingAppSettings | 

            try
            {
                // Add/Update URL Settings
                apiInstance.PutCrmV3ExtensionsAccountingSettingsAppIdReplace(appId, accountingAppSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsAccountingSettingsAppIdReplace: " + e.Message );
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
 **appId** | **int**| The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. | 
 **accountingAppSettings** | [**AccountingAppSettings**](AccountingAppSettings.md)|  | 

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

<a name="putcrmv3extensionsvideoconferencingsettingsappidreplace"></a>
# **PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace**
> ExternalSettings PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace (int appId, ExternalSettings externalSettings)

Update settings

Updates the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.
            var externalSettings = new ExternalSettings(); // ExternalSettings | 

            try
            {
                // Update settings
                ExternalSettings result = apiInstance.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace(appId, externalSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace: " + e.Message );
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
 **appId** | **int**| The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. | 
 **externalSettings** | [**ExternalSettings**](ExternalSettings.md)|  | 

### Return type

[**ExternalSettings**](ExternalSettings.md)

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

<a name="putwebhooksv3appidsettingsconfigure"></a>
# **PutWebhooksV3AppIdSettingsConfigure**
> SettingsResponse PutWebhooksV3AppIdSettingsConfigure (int appId, SettingsChangeRequest settingsChangeRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutWebhooksV3AppIdSettingsConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 
            var settingsChangeRequest = new SettingsChangeRequest(); // SettingsChangeRequest | 

            try
            {
                SettingsResponse result = apiInstance.PutWebhooksV3AppIdSettingsConfigure(appId, settingsChangeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutWebhooksV3AppIdSettingsConfigure: " + e.Message );
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
 **appId** | **int**|  | 
 **settingsChangeRequest** | [**SettingsChangeRequest**](SettingsChangeRequest.md)|  | 

### Return type

[**SettingsResponse**](SettingsResponse.md)

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

