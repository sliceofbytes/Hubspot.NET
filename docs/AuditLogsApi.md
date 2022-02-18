# HubSpot.NET.Api.AuditLogsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCmsV3AuditLogsGetPage**](AuditLogsApi.md#getcmsv3auditlogsgetpage) | **GET** /cms/v3/audit-logs/ | Query audit logs


<a name="getcmsv3auditlogsgetpage"></a>
# **GetCmsV3AuditLogsGetPage**
> CollectionResponsePublicAuditLog GetCmsV3AuditLogsGetPage (List<string> objectId = null, List<string> userId = null, string after = null, string before = null, List<string> sort = null, List<string> eventType = null, int? limit = null, List<string> objectType = null)

Query audit logs

Returns audit logs based on filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3AuditLogsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new AuditLogsApi(config);
            var objectId = new List<string>(); // List<string> | Comma separated list of object ids to filter by. (optional) 
            var userId = new List<string>(); // List<string> | Comma separated list of user ids to filter by. (optional) 
            var after = "after_example";  // string | Timestamp after which audit logs will be returned (optional) 
            var before = "before_example";  // string | Timestamp before which audit logs will be returned (optional) 
            var sort = new List<string>(); // List<string> | The sort direction for the audit logs. (Can only sort by timestamp). (optional) 
            var eventType = new List<string>(); // List<string> | Comma separated list of event types to filter by (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED). (optional) 
            var limit = 56;  // int? | The number of logs to return. (optional) 
            var objectType = new List<string>(); // List<string> | Comma separated list of object types to filter by (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.) (optional) 

            try
            {
                // Query audit logs
                CollectionResponsePublicAuditLog result = apiInstance.GetCmsV3AuditLogsGetPage(objectId, userId, after, before, sort, eventType, limit, objectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditLogsApi.GetCmsV3AuditLogsGetPage: " + e.Message );
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
 **objectId** | [**List&lt;string&gt;**](string.md)| Comma separated list of object ids to filter by. | [optional] 
 **userId** | [**List&lt;string&gt;**](string.md)| Comma separated list of user ids to filter by. | [optional] 
 **after** | **string**| Timestamp after which audit logs will be returned | [optional] 
 **before** | **string**| Timestamp before which audit logs will be returned | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| The sort direction for the audit logs. (Can only sort by timestamp). | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Comma separated list of event types to filter by (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED). | [optional] 
 **limit** | **int?**| The number of logs to return. | [optional] 
 **objectType** | [**List&lt;string&gt;**](string.md)| Comma separated list of object types to filter by (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.) | [optional] 

### Return type

[**CollectionResponsePublicAuditLog**](CollectionResponsePublicAuditLog.md)

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

