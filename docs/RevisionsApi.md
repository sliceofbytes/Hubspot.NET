# HubSpot.NET.Api.RevisionsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPage**](RevisionsApi.md#getautomationv4actionsappiddefinitionidrevisionsgetpage) | **GET** /automation/v4/actions/{appId}/{definitionId}/revisions | Get all revisions for a custom action
[**GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetById**](RevisionsApi.md#getautomationv4actionsappiddefinitionidrevisionsrevisionidgetbyid) | **GET** /automation/v4/actions/{appId}/{definitionId}/revisions/{revisionId} | Get a revision for a custom action


<a name="getautomationv4actionsappiddefinitionidrevisionsgetpage"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPage**
> CollectionResponseActionRevisionForwardPaging GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPage (string definitionId, int appId, int? limit = null, string after = null)

Get all revisions for a custom action

Returns a list of revisions for a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new RevisionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action
            var appId = 56;  // int | 
            var limit = 56;  // int? | Maximum number of results per page. (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 

            try
            {
                // Get all revisions for a custom action
                CollectionResponseActionRevisionForwardPaging result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPage(definitionId, appId, limit, after);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RevisionsApi.GetAutomationV4ActionsAppIdDefinitionIdRevisionsGetPage: " + e.Message );
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
 **definitionId** | **string**| The ID of the custom workflow action | 
 **appId** | **int**|  | 
 **limit** | **int?**| Maximum number of results per page. | [optional] 
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 

### Return type

[**CollectionResponseActionRevisionForwardPaging**](CollectionResponseActionRevisionForwardPaging.md)

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

<a name="getautomationv4actionsappiddefinitionidrevisionsrevisionidgetbyid"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetById**
> ActionRevision GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetById (string definitionId, string revisionId, int appId)

Get a revision for a custom action

Returns the given version of a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new RevisionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var revisionId = "revisionId_example";  // string | The version of the custom workflow action.
            var appId = 56;  // int | 

            try
            {
                // Get a revision for a custom action
                ActionRevision result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetById(definitionId, revisionId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RevisionsApi.GetAutomationV4ActionsAppIdDefinitionIdRevisionsRevisionIdGetById: " + e.Message );
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
 **definitionId** | **string**| The ID of the custom workflow action. | 
 **revisionId** | **string**| The version of the custom workflow action. | 
 **appId** | **int**|  | 

### Return type

[**ActionRevision**](ActionRevision.md)

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

