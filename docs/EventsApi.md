# HubSpot.NET.Api.EventsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventsV3EventsGetPage**](EventsApi.md#geteventsv3eventsgetpage) | **GET** /events/v3/events | Returns a collection of events matching a query.
[**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventiddetailgetdetailbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId}/detail | Gets the detailTemplate as rendered
[**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventidgetbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId} | Gets the event
[**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventidrendergetrenderbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId}/render | Renders the header or detail as HTML
[**PostIntegratorsTimelineV3EventsBatchCreateCreateBatch**](EventsApi.md#postintegratorstimelinev3eventsbatchcreatecreatebatch) | **POST** /crm/v3/timeline/events/batch/create | Creates multiple events
[**PostIntegratorsTimelineV3EventsCreate**](EventsApi.md#postintegratorstimelinev3eventscreate) | **POST** /crm/v3/timeline/events | Create a single event


<a name="geteventsv3eventsgetpage"></a>
# **GetEventsV3EventsGetPage**
> CollectionResponseExternalUnifiedEvent GetEventsV3EventsGetPage (DateTimeOffset? occurredAfter = null, DateTimeOffset? occurredBefore = null, string objectType = null, long? objectId = null, string eventType = null, string after = null, string before = null, int? limit = null, List<string> sort = null)

Returns a collection of events matching a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetEventsV3EventsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var occurredAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The starting time as an ISO 8601 timestamp. (optional) 
            var occurredBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The ending time as an ISO 8601 timestamp. (optional) 
            var objectType = "objectType_example";  // string | The type of object being selected. Valid values are hubspot named object types (e.g. `contact`). (optional) 
            var objectId = 789L;  // long? | The id of the selected object. If not present, then the `objectProperty` parameter is required. (optional) 
            var eventType = "eventType_example";  // string | Limits the response to the specified event type.  For example `&eventType=e_visited_page` returns only `e_visited_page` events.  If not present all event types are returned. (optional) 
            var after = "after_example";  // string | An additional parameter that may be used to get the next `limit` set of results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of events to return, defaults to 20. (optional) 
            var sort = new List<string>(); // List<string> | Selects the sort field and order. Defaults to ascending, prefix with `-` for descending order. `occurredAt` is the only field supported for sorting. (optional) 

            try
            {
                // Returns a collection of events matching a query.
                CollectionResponseExternalUnifiedEvent result = apiInstance.GetEventsV3EventsGetPage(occurredAfter, occurredBefore, objectType, objectId, eventType, after, before, limit, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsV3EventsGetPage: " + e.Message );
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
 **occurredAfter** | **DateTimeOffset?**| The starting time as an ISO 8601 timestamp. | [optional] 
 **occurredBefore** | **DateTimeOffset?**| The ending time as an ISO 8601 timestamp. | [optional] 
 **objectType** | **string**| The type of object being selected. Valid values are hubspot named object types (e.g. &#x60;contact&#x60;). | [optional] 
 **objectId** | **long?**| The id of the selected object. If not present, then the &#x60;objectProperty&#x60; parameter is required. | [optional] 
 **eventType** | **string**| Limits the response to the specified event type.  For example &#x60;&amp;eventType&#x3D;e_visited_page&#x60; returns only &#x60;e_visited_page&#x60; events.  If not present all event types are returned. | [optional] 
 **after** | **string**| An additional parameter that may be used to get the next &#x60;limit&#x60; set of results. | [optional] 
 **before** | **string**|  | [optional] 
 **limit** | **int?**| The maximum number of events to return, defaults to 20. | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Selects the sort field and order. Defaults to ascending, prefix with &#x60;-&#x60; for descending order. &#x60;occurredAt&#x60; is the only field supported for sorting. | [optional] 

### Return type

[**CollectionResponseExternalUnifiedEvent**](CollectionResponseExternalUnifiedEvent.md)

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

<a name="getintegratorstimelinev3eventseventtemplateideventiddetailgetdetailbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById**
> EventDetail GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById (string eventTemplateId, string eventId)

Gets the detailTemplate as rendered

This will take the `detailTemplate` from the event template and return an object rendering the specified event. If the template references `extraData` that isn't found in the event, it will be ignored and we'll render without it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.

            try
            {
                // Gets the detailTemplate as rendered
                EventDetail result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById(eventTemplateId, eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById: " + e.Message );
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
 **eventId** | **string**| The event ID. | 

### Return type

[**EventDetail**](EventDetail.md)

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

<a name="getintegratorstimelinev3eventseventtemplateideventidgetbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById**
> TimelineEventResponse GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById (string eventTemplateId, string eventId)

Gets the event

This returns the previously created event. It contains all existing info for the event, but not necessarily the CRM object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.

            try
            {
                // Gets the event
                TimelineEventResponse result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById(eventTemplateId, eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById: " + e.Message );
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
 **eventId** | **string**| The event ID. | 

### Return type

[**TimelineEventResponse**](TimelineEventResponse.md)

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

<a name="getintegratorstimelinev3eventseventtemplateideventidrendergetrenderbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById**
> string GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById (string eventTemplateId, string eventId, bool? detail = null)

Renders the header or detail as HTML

This will take either the `headerTemplate` or `detailTemplate` from the event template and render for the specified event as HTML. If the template references `extraData` that isn't found in the event, it will be ignored and we'll render without it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.
            var detail = true;  // bool? | Set to 'true', we want to render the `detailTemplate` instead of the `headerTemplate`. (optional) 

            try
            {
                // Renders the header or detail as HTML
                string result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById(eventTemplateId, eventId, detail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById: " + e.Message );
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
 **eventId** | **string**| The event ID. | 
 **detail** | **bool?**| Set to &#39;true&#39;, we want to render the &#x60;detailTemplate&#x60; instead of the &#x60;headerTemplate&#x60;. | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postintegratorstimelinev3eventsbatchcreatecreatebatch"></a>
# **PostIntegratorsTimelineV3EventsBatchCreateCreateBatch**
> BatchResponseTimelineEventResponse PostIntegratorsTimelineV3EventsBatchCreateCreateBatch (BatchInputTimelineEvent batchInputTimelineEvent)

Creates multiple events

Creates multiple instances of timeline events based on an event template. Once created, these event are immutable on the object timeline and cannot be modified. If the event template was configured to update object properties via `objectPropertyName`, this call will also attempt to updates those properties, or add them if they don't exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3EventsBatchCreateCreateBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var batchInputTimelineEvent = new BatchInputTimelineEvent(); // BatchInputTimelineEvent | The timeline event definition.

            try
            {
                // Creates multiple events
                BatchResponseTimelineEventResponse result = apiInstance.PostIntegratorsTimelineV3EventsBatchCreateCreateBatch(batchInputTimelineEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsBatchCreateCreateBatch: " + e.Message );
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
 **batchInputTimelineEvent** | [**BatchInputTimelineEvent**](BatchInputTimelineEvent.md)| The timeline event definition. | 

### Return type

[**BatchResponseTimelineEventResponse**](BatchResponseTimelineEventResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postintegratorstimelinev3eventscreate"></a>
# **PostIntegratorsTimelineV3EventsCreate**
> TimelineEventResponse PostIntegratorsTimelineV3EventsCreate (TimelineEvent timelineEvent)

Create a single event

Creates an instance of a timeline event based on an event template. Once created, this event is immutable on the object timeline and cannot be modified. If the event template was configured to update object properties via `objectPropertyName`, this call will also attempt to updates those properties, or add them if they don't exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3EventsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new EventsApi(config);
            var timelineEvent = new TimelineEvent(); // TimelineEvent | The timeline event definition.

            try
            {
                // Create a single event
                TimelineEventResponse result = apiInstance.PostIntegratorsTimelineV3EventsCreate(timelineEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsCreate: " + e.Message );
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
 **timelineEvent** | [**TimelineEvent**](TimelineEvent.md)| The timeline event definition. | 

### Return type

[**TimelineEventResponse**](TimelineEventResponse.md)

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

