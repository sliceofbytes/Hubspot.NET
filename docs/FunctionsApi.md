# HubSpot.NET.Api.FunctionsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionType**](FunctionsApi.md#deleteautomationv4actionsappiddefinitionidfunctionsfunctiontypearchivebyfunctiontype) | **DELETE** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType} | Delete a custom action function
[**DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchive**](FunctionsApi.md#deleteautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidarchive) | **DELETE** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType}/{functionId} | Delete a custom action function
[**GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetById**](FunctionsApi.md#getautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidgetbyid) | **GET** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType}/{functionId} | Get a custom action function
[**GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionType**](FunctionsApi.md#getautomationv4actionsappiddefinitionidfunctionsfunctiontypegetbyfunctiontype) | **GET** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType} | Get a custom action function
[**GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPage**](FunctionsApi.md#getautomationv4actionsappiddefinitionidfunctionsgetpage) | **GET** /automation/v4/actions/{appId}/{definitionId}/functions | Get all custom action functions
[**PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionType**](FunctionsApi.md#putautomationv4actionsappiddefinitionidfunctionsfunctiontypecreateorreplacebyfunctiontype) | **PUT** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType} | Create or replace a custom action function
[**PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplace**](FunctionsApi.md#putautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidcreateorreplace) | **PUT** /automation/v4/actions/{appId}/{definitionId}/functions/{functionType}/{functionId} | Create or replace a custom action function


<a name="deleteautomationv4actionsappiddefinitionidfunctionsfunctiontypearchivebyfunctiontype"></a>
# **DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionType**
> void DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionType (string definitionId, string functionType, int appId)

Delete a custom action function

Delete a function for a custom workflow action. This will remove the function itself as well as removing the association between the function and the custom action. This can't be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var appId = 56;  // int | 

            try
            {
                // Delete a custom action function
                apiInstance.DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionType(definitionId, functionType, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeArchiveByFunctionType: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
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

<a name="deleteautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidarchive"></a>
# **DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchive**
> void DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchive (string definitionId, string functionType, string functionId, int appId)

Delete a custom action function

Delete a function for a custom workflow action. This will remove the function itself as well as removing the association between the function and the custom action. This can't be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var functionId = "functionId_example";  // string | The ID qualifier for the function. This is used to specify which input field a function is associated with for `PRE_FETCH_OPTIONS` and `POST_FETCH_OPTIONS` function types.
            var appId = 56;  // int | 

            try
            {
                // Delete a custom action function
                apiInstance.DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchive(definitionId, functionType, functionId, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.DeleteAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdArchive: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
 **functionId** | **string**| The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types. | 
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

<a name="getautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidgetbyid"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetById**
> ActionFunction GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetById (string definitionId, string functionType, string functionId, int appId)

Get a custom action function

Returns the given function for a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var functionId = "functionId_example";  // string | The ID qualifier for the function. This is used to specify which input field a function is associated with for `PRE_FETCH_OPTIONS` and `POST_FETCH_OPTIONS` function types.
            var appId = 56;  // int | 

            try
            {
                // Get a custom action function
                ActionFunction result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetById(definitionId, functionType, functionId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdGetById: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
 **functionId** | **string**| The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types. | 
 **appId** | **int**|  | 

### Return type

[**ActionFunction**](ActionFunction.md)

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

<a name="getautomationv4actionsappiddefinitionidfunctionsfunctiontypegetbyfunctiontype"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionType**
> ActionFunction GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionType (string definitionId, string functionType, int appId)

Get a custom action function

Returns the given function for a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var appId = 56;  // int | 

            try
            {
                // Get a custom action function
                ActionFunction result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionType(definitionId, functionType, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeGetByFunctionType: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
 **appId** | **int**|  | 

### Return type

[**ActionFunction**](ActionFunction.md)

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

<a name="getautomationv4actionsappiddefinitionidfunctionsgetpage"></a>
# **GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPage**
> CollectionResponseActionFunctionIdentifierNoPaging GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPage (string definitionId, int appId)

Get all custom action functions

Returns a list of all functions that are associated with the given custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var appId = 56;  // int | 

            try
            {
                // Get all custom action functions
                CollectionResponseActionFunctionIdentifierNoPaging result = apiInstance.GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPage(definitionId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetAutomationV4ActionsAppIdDefinitionIdFunctionsGetPage: " + e.Message );
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

[**CollectionResponseActionFunctionIdentifierNoPaging**](CollectionResponseActionFunctionIdentifierNoPaging.md)

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

<a name="putautomationv4actionsappiddefinitionidfunctionsfunctiontypecreateorreplacebyfunctiontype"></a>
# **PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionType**
> ActionFunctionIdentifier PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionType (string definitionId, string functionType, int appId, string body)

Create or replace a custom action function

Creates or replaces a function for a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var appId = 56;  // int | 
            var body = "body_example";  // string | The function source code. Must be valid JavaScript code.

            try
            {
                // Create or replace a custom action function
                ActionFunctionIdentifier result = apiInstance.PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionType(definitionId, functionType, appId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeCreateOrReplaceByFunctionType: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
 **appId** | **int**|  | 
 **body** | **string**| The function source code. Must be valid JavaScript code. | 

### Return type

[**ActionFunctionIdentifier**](ActionFunctionIdentifier.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putautomationv4actionsappiddefinitionidfunctionsfunctiontypefunctionidcreateorreplace"></a>
# **PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplace**
> ActionFunctionIdentifier PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplace (string definitionId, string functionType, string functionId, int appId, string body)

Create or replace a custom action function

Creates or replaces a function for a custom workflow action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new FunctionsApi(config);
            var definitionId = "definitionId_example";  // string | The ID of the custom workflow action.
            var functionType = "PRE_ACTION_EXECUTION";  // string | The type of function. This determines when the function will be called.
            var functionId = "functionId_example";  // string | The ID qualifier for the function. This is used to specify which input field a function is associated with for `PRE_FETCH_OPTIONS` and `POST_FETCH_OPTIONS` function types.
            var appId = 56;  // int | 
            var body = "body_example";  // string | The function source code. Must be valid JavaScript code.

            try
            {
                // Create or replace a custom action function
                ActionFunctionIdentifier result = apiInstance.PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplace(definitionId, functionType, functionId, appId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.PutAutomationV4ActionsAppIdDefinitionIdFunctionsFunctionTypeFunctionIdCreateOrReplace: " + e.Message );
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
 **functionType** | **string**| The type of function. This determines when the function will be called. | 
 **functionId** | **string**| The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types. | 
 **appId** | **int**|  | 
 **body** | **string**| The function source code. Must be valid JavaScript code. | 

### Return type

[**ActionFunctionIdentifier**](ActionFunctionIdentifier.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

