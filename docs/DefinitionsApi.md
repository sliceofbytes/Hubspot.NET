# HubSpot.NET.Api.DefinitionsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAutomationV4ActionsAppIdDefinitionIdArchive**](DefinitionsApi.md#deleteautomationv4actionsappiddefinitionidarchive) | **DELETE** /automation/v4/actions/{appId}/{definitionId} | Archive a custom action
[**GetAutomationV4ActionsAppIdDefinitionIdGetById**](DefinitionsApi.md#getautomationv4actionsappiddefinitionidgetbyid) | **GET** /automation/v4/actions/{appId}/{definitionId} | Get a custom action
[**GetAutomationV4ActionsAppIdGetPage**](DefinitionsApi.md#getautomationv4actionsappidgetpage) | **GET** /automation/v4/actions/{appId} | Get all custom actions
[**PatchAutomationV4ActionsAppIdDefinitionIdUpdate**](DefinitionsApi.md#patchautomationv4actionsappiddefinitionidupdate) | **PATCH** /automation/v4/actions/{appId}/{definitionId} | Update a custom action
[**PostAutomationV4ActionsAppIdCreate**](DefinitionsApi.md#postautomationv4actionsappidcreate) | **POST** /automation/v4/actions/{appId} | Create new custom action


<a name="deleteautomationv4actionsappiddefinitionidarchive"></a>
# **DeleteAutomationV4ActionsAppIdDefinitionIdArchive**
> void DeleteAutomationV4ActionsAppIdDefinitionIdArchive (string definitionId, int appId)

Archive a custom action

Archives a single custom workflow action with the specified ID. Workflows that currently use this custom action will stop attempting to execute the action, and all future executions will be marked as a failure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteAutomationV4ActionsAppIdDefinitionIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new DefinitionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var appId = 56;  // int | 

            try
            {
                // Archive a custom action
                apiInstance.DeleteAutomationV4ActionsAppIdDefinitionIdArchive(definitionId, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.DeleteAutomationV4ActionsAppIdDefinitionIdArchive: " + e.Message );
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

<a name="getautomationv4actionsappiddefinitionidgetbyid"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdGetById**
> ExtensionActionDefinition GetAutomationV4ActionsAppIdDefinitionIdGetById (string definitionId, int appId, bool? archived = null)

Get a custom action

Returns a single custom workflow action with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new DefinitionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var appId = 56;  // int | 
            var archived = false;  // bool? | Whether to include archived custom actions. (optional)  (default to false)

            try
            {
                // Get a custom action
                ExtensionActionDefinition result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdGetById(definitionId, appId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.GetAutomationV4ActionsAppIdDefinitionIdGetById: " + e.Message );
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
 **appId** | **int**|  | 
 **archived** | **bool?**| Whether to include archived custom actions. | [optional] [default to false]

### Return type

[**ExtensionActionDefinition**](ExtensionActionDefinition.md)

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

<a name="getautomationv4actionsappidgetpage"></a>
# **GetAutomationV4ActionsAppIdGetPage**
> CollectionResponseExtensionActionDefinitionForwardPaging GetAutomationV4ActionsAppIdGetPage (int appId, int? limit = null, string after = null, bool? archived = null)

Get all custom actions

Returns a list of all custom workflow actions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new DefinitionsApi(config);
            var appId = 56;  // int | 
            var limit = 56;  // int? | Maximum number of results per page. (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var archived = false;  // bool? | Whether to include archived custom actions. (optional)  (default to false)

            try
            {
                // Get all custom actions
                CollectionResponseExtensionActionDefinitionForwardPaging result = apiInstance.GetAutomationV4ActionsAppIdGetPage(appId, limit, after, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.GetAutomationV4ActionsAppIdGetPage: " + e.Message );
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
 **limit** | **int?**| Maximum number of results per page. | [optional] 
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **archived** | **bool?**| Whether to include archived custom actions. | [optional] [default to false]

### Return type

[**CollectionResponseExtensionActionDefinitionForwardPaging**](CollectionResponseExtensionActionDefinitionForwardPaging.md)

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

<a name="patchautomationv4actionsappiddefinitionidupdate"></a>
# **PatchAutomationV4ActionsAppIdDefinitionIdUpdate**
> ExtensionActionDefinition PatchAutomationV4ActionsAppIdDefinitionIdUpdate (string definitionId, int appId, ExtensionActionDefinitionPatch extensionActionDefinitionPatch)

Update a custom action

Updates a custom workflow action with new values for the specified fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchAutomationV4ActionsAppIdDefinitionIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new DefinitionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var appId = 56;  // int | 
            var extensionActionDefinitionPatch = new ExtensionActionDefinitionPatch(); // ExtensionActionDefinitionPatch | The custom workflow action fields to be updated.

            try
            {
                // Update a custom action
                ExtensionActionDefinition result = apiInstance.PatchAutomationV4ActionsAppIdDefinitionIdUpdate(definitionId, appId, extensionActionDefinitionPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.PatchAutomationV4ActionsAppIdDefinitionIdUpdate: " + e.Message );
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
 **appId** | **int**|  | 
 **extensionActionDefinitionPatch** | [**ExtensionActionDefinitionPatch**](ExtensionActionDefinitionPatch.md)| The custom workflow action fields to be updated. | 

### Return type

[**ExtensionActionDefinition**](ExtensionActionDefinition.md)

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

<a name="postautomationv4actionsappidcreate"></a>
# **PostAutomationV4ActionsAppIdCreate**
> ExtensionActionDefinition PostAutomationV4ActionsAppIdCreate (int appId, ExtensionActionDefinitionInput extensionActionDefinitionInput)

Create new custom action

Creates a new custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostAutomationV4ActionsAppIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new DefinitionsApi(config);
            var appId = 56;  // int | 
            var extensionActionDefinitionInput = new ExtensionActionDefinitionInput(); // ExtensionActionDefinitionInput | The custom workflow action to create.

            try
            {
                // Create new custom action
                ExtensionActionDefinition result = apiInstance.PostAutomationV4ActionsAppIdCreate(appId, extensionActionDefinitionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.PostAutomationV4ActionsAppIdCreate: " + e.Message );
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
 **extensionActionDefinitionInput** | [**ExtensionActionDefinitionInput**](ExtensionActionDefinitionInput.md)| The custom workflow action to create. | 

### Return type

[**ExtensionActionDefinition**](ExtensionActionDefinition.md)

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

