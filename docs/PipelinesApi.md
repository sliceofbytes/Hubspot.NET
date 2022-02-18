# HubSpot.NET.Api.PipelinesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmV3PipelinesObjectTypePipelineIdArchive**](PipelinesApi.md#deletecrmv3pipelinesobjecttypepipelineidarchive) | **DELETE** /crm/v3/pipelines/{objectType}/{pipelineId} | Archive a pipeline
[**GetCrmV3PipelinesObjectTypeGetAll**](PipelinesApi.md#getcrmv3pipelinesobjecttypegetall) | **GET** /crm/v3/pipelines/{objectType} | Retrieve all pipelines
[**GetCrmV3PipelinesObjectTypePipelineIdGetById**](PipelinesApi.md#getcrmv3pipelinesobjecttypepipelineidgetbyid) | **GET** /crm/v3/pipelines/{objectType}/{pipelineId} | Return a pipeline by ID
[**PatchCrmV3PipelinesObjectTypePipelineIdUpdate**](PipelinesApi.md#patchcrmv3pipelinesobjecttypepipelineidupdate) | **PATCH** /crm/v3/pipelines/{objectType}/{pipelineId} | Update a pipeline
[**PostCrmV3PipelinesObjectTypeCreate**](PipelinesApi.md#postcrmv3pipelinesobjecttypecreate) | **POST** /crm/v3/pipelines/{objectType} | Create a pipeline
[**PutCrmV3PipelinesObjectTypePipelineIdReplace**](PipelinesApi.md#putcrmv3pipelinesobjecttypepipelineidreplace) | **PUT** /crm/v3/pipelines/{objectType}/{pipelineId} | Replace a pipeline


<a name="deletecrmv3pipelinesobjecttypepipelineidarchive"></a>
# **DeleteCrmV3PipelinesObjectTypePipelineIdArchive**
> void DeleteCrmV3PipelinesObjectTypePipelineIdArchive (string objectType, string pipelineId, bool? validateReferencesBeforeDelete = null)

Archive a pipeline

Archive the pipeline identified by `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3PipelinesObjectTypePipelineIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var validateReferencesBeforeDelete = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Archive a pipeline
                apiInstance.DeleteCrmV3PipelinesObjectTypePipelineIdArchive(objectType, pipelineId, validateReferencesBeforeDelete);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.DeleteCrmV3PipelinesObjectTypePipelineIdArchive: " + e.Message );
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
 **objectType** | **string**|  | 
 **pipelineId** | **string**|  | 
 **validateReferencesBeforeDelete** | **bool?**|  | [optional] [default to false]

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

<a name="getcrmv3pipelinesobjecttypegetall"></a>
# **GetCrmV3PipelinesObjectTypeGetAll**
> CollectionResponsePipelineNoPaging GetCrmV3PipelinesObjectTypeGetAll (string objectType, bool? archived = null)

Retrieve all pipelines

Return all pipelines for the object type specified by `{objectType}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypeGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Retrieve all pipelines
                CollectionResponsePipelineNoPaging result = apiInstance.GetCrmV3PipelinesObjectTypeGetAll(objectType, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GetCrmV3PipelinesObjectTypeGetAll: " + e.Message );
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
 **objectType** | **string**|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**CollectionResponsePipelineNoPaging**](CollectionResponsePipelineNoPaging.md)

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

<a name="getcrmv3pipelinesobjecttypepipelineidgetbyid"></a>
# **GetCrmV3PipelinesObjectTypePipelineIdGetById**
> Pipeline GetCrmV3PipelinesObjectTypePipelineIdGetById (string objectType, string pipelineId, bool? archived = null)

Return a pipeline by ID

Return a single pipeline object identified by its unique `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypePipelineIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Return a pipeline by ID
                Pipeline result = apiInstance.GetCrmV3PipelinesObjectTypePipelineIdGetById(objectType, pipelineId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GetCrmV3PipelinesObjectTypePipelineIdGetById: " + e.Message );
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
 **objectType** | **string**|  | 
 **pipelineId** | **string**|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**Pipeline**](Pipeline.md)

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

<a name="patchcrmv3pipelinesobjecttypepipelineidupdate"></a>
# **PatchCrmV3PipelinesObjectTypePipelineIdUpdate**
> Pipeline PatchCrmV3PipelinesObjectTypePipelineIdUpdate (string objectType, string pipelineId, PipelinePatchInput pipelinePatchInput, bool? archived = null, bool? validateReferencesBeforeDelete = null)

Update a pipeline

Perform a partial update of the pipeline identified by `{pipelineId}`. The updated pipeline will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3PipelinesObjectTypePipelineIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var pipelinePatchInput = new PipelinePatchInput(); // PipelinePatchInput | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var validateReferencesBeforeDelete = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Update a pipeline
                Pipeline result = apiInstance.PatchCrmV3PipelinesObjectTypePipelineIdUpdate(objectType, pipelineId, pipelinePatchInput, archived, validateReferencesBeforeDelete);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.PatchCrmV3PipelinesObjectTypePipelineIdUpdate: " + e.Message );
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
 **objectType** | **string**|  | 
 **pipelineId** | **string**|  | 
 **pipelinePatchInput** | [**PipelinePatchInput**](PipelinePatchInput.md)|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]
 **validateReferencesBeforeDelete** | **bool?**|  | [optional] [default to false]

### Return type

[**Pipeline**](Pipeline.md)

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

<a name="postcrmv3pipelinesobjecttypecreate"></a>
# **PostCrmV3PipelinesObjectTypeCreate**
> Pipeline PostCrmV3PipelinesObjectTypeCreate (string objectType, PipelineInput pipelineInput)

Create a pipeline

Create a new pipeline with the provided property values. The entire pipeline object, including its unique ID, will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3PipelinesObjectTypeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineInput = new PipelineInput(); // PipelineInput | 

            try
            {
                // Create a pipeline
                Pipeline result = apiInstance.PostCrmV3PipelinesObjectTypeCreate(objectType, pipelineInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.PostCrmV3PipelinesObjectTypeCreate: " + e.Message );
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
 **objectType** | **string**|  | 
 **pipelineInput** | [**PipelineInput**](PipelineInput.md)|  | 

### Return type

[**Pipeline**](Pipeline.md)

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

<a name="putcrmv3pipelinesobjecttypepipelineidreplace"></a>
# **PutCrmV3PipelinesObjectTypePipelineIdReplace**
> Pipeline PutCrmV3PipelinesObjectTypePipelineIdReplace (string objectType, string pipelineId, PipelineInput pipelineInput, bool? validateReferencesBeforeDelete = null)

Replace a pipeline

Replace all the properties of an existing pipeline with the values provided. This will overwrite any existing pipeline stages. The updated pipeline will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCrmV3PipelinesObjectTypePipelineIdReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelinesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var pipelineInput = new PipelineInput(); // PipelineInput | 
            var validateReferencesBeforeDelete = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Replace a pipeline
                Pipeline result = apiInstance.PutCrmV3PipelinesObjectTypePipelineIdReplace(objectType, pipelineId, pipelineInput, validateReferencesBeforeDelete);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.PutCrmV3PipelinesObjectTypePipelineIdReplace: " + e.Message );
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
 **objectType** | **string**|  | 
 **pipelineId** | **string**|  | 
 **pipelineInput** | [**PipelineInput**](PipelineInput.md)|  | 
 **validateReferencesBeforeDelete** | **bool?**|  | [optional] [default to false]

### Return type

[**Pipeline**](Pipeline.md)

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

