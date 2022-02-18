# HubSpot.NET.Api.TemplatesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchive**](TemplatesApi.md#deleteintegratorstimelinev3appideventtemplateseventtemplateidarchive) | **DELETE** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId} | Deletes an event template for the app
[**GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetById**](TemplatesApi.md#getintegratorstimelinev3appideventtemplateseventtemplateidgetbyid) | **GET** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId} | Gets a specific event template for your app
[**GetIntegratorsTimelineV3AppIdEventTemplatesGetAll**](TemplatesApi.md#getintegratorstimelinev3appideventtemplatesgetall) | **GET** /crm/v3/timeline/{appId}/event-templates | List all event templates for your app
[**PostIntegratorsTimelineV3AppIdEventTemplatesCreate**](TemplatesApi.md#postintegratorstimelinev3appideventtemplatescreate) | **POST** /crm/v3/timeline/{appId}/event-templates | Create an event template for your app
[**PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdate**](TemplatesApi.md#putintegratorstimelinev3appideventtemplateseventtemplateidupdate) | **PUT** /crm/v3/timeline/{appId}/event-templates/{eventTemplateId} | Update an existing event template


<a name="deleteintegratorstimelinev3appideventtemplateseventtemplateidarchive"></a>
# **DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchive**
> void DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchive (string eventTemplateId, int appId)

Deletes an event template for the app

This will delete the event template. All associated events will be removed from search results and the timeline UI.  This action can't be undone, so it's highly recommended that you stop using any associated events before deleting a template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Deletes an event template for the app
                apiInstance.DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchive(eventTemplateId, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdArchive: " + e.Message );
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

<a name="getintegratorstimelinev3appideventtemplateseventtemplateidgetbyid"></a>
# **GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetById**
> TimelineEventTemplate GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetById (string eventTemplateId, int appId)

Gets a specific event template for your app

View the current state of a specific template and its tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Gets a specific event template for your app
                TimelineEventTemplate result = apiInstance.GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetById(eventTemplateId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdGetById: " + e.Message );
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

### Return type

[**TimelineEventTemplate**](TimelineEventTemplate.md)

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

<a name="getintegratorstimelinev3appideventtemplatesgetall"></a>
# **GetIntegratorsTimelineV3AppIdEventTemplatesGetAll**
> CollectionResponseTimelineEventTemplateNoPaging GetIntegratorsTimelineV3AppIdEventTemplatesGetAll (int appId)

List all event templates for your app

Use this to list all event templates owned by your app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3AppIdEventTemplatesGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // List all event templates for your app
                CollectionResponseTimelineEventTemplateNoPaging result = apiInstance.GetIntegratorsTimelineV3AppIdEventTemplatesGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetIntegratorsTimelineV3AppIdEventTemplatesGetAll: " + e.Message );
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

[**CollectionResponseTimelineEventTemplateNoPaging**](CollectionResponseTimelineEventTemplateNoPaging.md)

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

<a name="postintegratorstimelinev3appideventtemplatescreate"></a>
# **PostIntegratorsTimelineV3AppIdEventTemplatesCreate**
> TimelineEventTemplate PostIntegratorsTimelineV3AppIdEventTemplatesCreate (int appId, TimelineEventTemplateCreateRequest timelineEventTemplateCreateRequest)

Create an event template for your app

Event templates define the general structure for a custom timeline event. This includes formatted copy for its heading and details, as well as any custom property definitions. The event could be something like viewing a video, registering for a webinar, or filling out a survey. A single app can define multiple event templates.  Event templates will be created for contacts by default, but they can be created for companies, tickets, and deals as well.  Each event template contains its own set of tokens and `Markdown` templates. These tokens can be associated with any CRM object properties via the `objectPropertyName` field to fully build out CRM objects.  You must create an event template before you can create events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3AppIdEventTemplatesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var appId = 56;  // int | The ID of the target app.
            var timelineEventTemplateCreateRequest = new TimelineEventTemplateCreateRequest(); // TimelineEventTemplateCreateRequest | The new event template definition.

            try
            {
                // Create an event template for your app
                TimelineEventTemplate result = apiInstance.PostIntegratorsTimelineV3AppIdEventTemplatesCreate(appId, timelineEventTemplateCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostIntegratorsTimelineV3AppIdEventTemplatesCreate: " + e.Message );
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
 **timelineEventTemplateCreateRequest** | [**TimelineEventTemplateCreateRequest**](TimelineEventTemplateCreateRequest.md)| The new event template definition. | 

### Return type

[**TimelineEventTemplate**](TimelineEventTemplate.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putintegratorstimelinev3appideventtemplateseventtemplateidupdate"></a>
# **PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdate**
> TimelineEventTemplate PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdate (string eventTemplateId, int appId, TimelineEventTemplateUpdateRequest timelineEventTemplateUpdateRequest)

Update an existing event template

Updates an existing template and its tokens. This is primarily used to update the headerTemplate/detailTemplate, and those changes will take effect for existing events.  You can also update or replace all the tokens in the template here instead of doing individual API calls on the `/tokens` endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var appId = 56;  // int | The ID of the target app.
            var timelineEventTemplateUpdateRequest = new TimelineEventTemplateUpdateRequest(); // TimelineEventTemplateUpdateRequest | The updated event template definition.

            try
            {
                // Update an existing event template
                TimelineEventTemplate result = apiInstance.PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdate(eventTemplateId, appId, timelineEventTemplateUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PutIntegratorsTimelineV3AppIdEventTemplatesEventTemplateIdUpdate: " + e.Message );
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
 **timelineEventTemplateUpdateRequest** | [**TimelineEventTemplateUpdateRequest**](TimelineEventTemplateUpdateRequest.md)| The updated event template definition. | 

### Return type

[**TimelineEventTemplate**](TimelineEventTemplate.md)

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

