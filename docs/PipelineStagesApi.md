# HubSpot.NET.Api.PipelineStagesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchive**](PipelineStagesApi.md#deletecrmv3pipelinesobjecttypepipelineidstagesstageidarchive) | **DELETE** /crm/v3/pipelines/{objectType}/{pipelineId}/stages/{stageId} | Archive a pipeline stage
[**GetCrmV3PipelinesObjectTypePipelineIdStagesGetAll**](PipelineStagesApi.md#getcrmv3pipelinesobjecttypepipelineidstagesgetall) | **GET** /crm/v3/pipelines/{objectType}/{pipelineId}/stages | Return all stages of a pipeline
[**GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetById**](PipelineStagesApi.md#getcrmv3pipelinesobjecttypepipelineidstagesstageidgetbyid) | **GET** /crm/v3/pipelines/{objectType}/{pipelineId}/stages/{stageId} | Return a pipeline stage by ID
[**PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdate**](PipelineStagesApi.md#patchcrmv3pipelinesobjecttypepipelineidstagesstageidupdate) | **PATCH** /crm/v3/pipelines/{objectType}/{pipelineId}/stages/{stageId} | Update a pipeline stage
[**PostCrmV3PipelinesObjectTypePipelineIdStagesCreate**](PipelineStagesApi.md#postcrmv3pipelinesobjecttypepipelineidstagescreate) | **POST** /crm/v3/pipelines/{objectType}/{pipelineId}/stages | Create a pipeline stage
[**PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplace**](PipelineStagesApi.md#putcrmv3pipelinesobjecttypepipelineidstagesstageidreplace) | **PUT** /crm/v3/pipelines/{objectType}/{pipelineId}/stages/{stageId} | Replace a pipeline stage


<a name="deletecrmv3pipelinesobjecttypepipelineidstagesstageidarchive"></a>
# **DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchive**
> void DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchive (string objectType, string pipelineId, string stageId)

Archive a pipeline stage

Archive the pipeline stage identified by `{stageId}` associated with the pipeline identified by `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var stageId = "stageId_example";  // string | 

            try
            {
                // Archive a pipeline stage
                apiInstance.DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchive(objectType, pipelineId, stageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.DeleteCrmV3PipelinesObjectTypePipelineIdStagesStageIdArchive: " + e.Message );
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
 **stageId** | **string**|  | 

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

<a name="getcrmv3pipelinesobjecttypepipelineidstagesgetall"></a>
# **GetCrmV3PipelinesObjectTypePipelineIdStagesGetAll**
> CollectionResponsePipelineStageNoPaging GetCrmV3PipelinesObjectTypePipelineIdStagesGetAll (string objectType, string pipelineId, bool? archived = null)

Return all stages of a pipeline

Return all the stages associated with the pipeline identified by `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypePipelineIdStagesGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Return all stages of a pipeline
                CollectionResponsePipelineStageNoPaging result = apiInstance.GetCrmV3PipelinesObjectTypePipelineIdStagesGetAll(objectType, pipelineId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.GetCrmV3PipelinesObjectTypePipelineIdStagesGetAll: " + e.Message );
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

[**CollectionResponsePipelineStageNoPaging**](CollectionResponsePipelineStageNoPaging.md)

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

<a name="getcrmv3pipelinesobjecttypepipelineidstagesstageidgetbyid"></a>
# **GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetById**
> PipelineStage GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetById (string objectType, string pipelineId, string stageId, bool? archived = null)

Return a pipeline stage by ID

Return the stage identified by `{stageId}` associated with the pipeline identified by `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var stageId = "stageId_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Return a pipeline stage by ID
                PipelineStage result = apiInstance.GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetById(objectType, pipelineId, stageId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdGetById: " + e.Message );
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
 **stageId** | **string**|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**PipelineStage**](PipelineStage.md)

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

<a name="patchcrmv3pipelinesobjecttypepipelineidstagesstageidupdate"></a>
# **PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdate**
> PipelineStage PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdate (string objectType, string pipelineId, string stageId, PipelineStagePatchInput pipelineStagePatchInput, bool? archived = null)

Update a pipeline stage

Perform a partial update of the pipeline stage identified by `{stageId}` associated with the pipeline identified by `{pipelineId}`. Any properties not included in this update will keep their existing values. The updated stage will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var stageId = "stageId_example";  // string | 
            var pipelineStagePatchInput = new PipelineStagePatchInput(); // PipelineStagePatchInput | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Update a pipeline stage
                PipelineStage result = apiInstance.PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdate(objectType, pipelineId, stageId, pipelineStagePatchInput, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.PatchCrmV3PipelinesObjectTypePipelineIdStagesStageIdUpdate: " + e.Message );
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
 **stageId** | **string**|  | 
 **pipelineStagePatchInput** | [**PipelineStagePatchInput**](PipelineStagePatchInput.md)|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**PipelineStage**](PipelineStage.md)

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

<a name="postcrmv3pipelinesobjecttypepipelineidstagescreate"></a>
# **PostCrmV3PipelinesObjectTypePipelineIdStagesCreate**
> PipelineStage PostCrmV3PipelinesObjectTypePipelineIdStagesCreate (string objectType, string pipelineId, PipelineStageInput pipelineStageInput)

Create a pipeline stage

Create a new stage associated with the pipeline identified by `{pipelineId}`. The entire stage object, including its unique ID, will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3PipelinesObjectTypePipelineIdStagesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var pipelineStageInput = new PipelineStageInput(); // PipelineStageInput | 

            try
            {
                // Create a pipeline stage
                PipelineStage result = apiInstance.PostCrmV3PipelinesObjectTypePipelineIdStagesCreate(objectType, pipelineId, pipelineStageInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.PostCrmV3PipelinesObjectTypePipelineIdStagesCreate: " + e.Message );
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
 **pipelineStageInput** | [**PipelineStageInput**](PipelineStageInput.md)|  | 

### Return type

[**PipelineStage**](PipelineStage.md)

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

<a name="putcrmv3pipelinesobjecttypepipelineidstagesstageidreplace"></a>
# **PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplace**
> PipelineStage PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplace (string objectType, string pipelineId, string stageId, PipelineStageInput pipelineStageInput)

Replace a pipeline stage

Replace all the properties of an existing pipeline stage with the values provided. The updated stage will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStagesApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var stageId = "stageId_example";  // string | 
            var pipelineStageInput = new PipelineStageInput(); // PipelineStageInput | 

            try
            {
                // Replace a pipeline stage
                PipelineStage result = apiInstance.PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplace(objectType, pipelineId, stageId, pipelineStageInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStagesApi.PutCrmV3PipelinesObjectTypePipelineIdStagesStageIdReplace: " + e.Message );
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
 **stageId** | **string**|  | 
 **pipelineStageInput** | [**PipelineStageInput**](PipelineStageInput.md)|  | 

### Return type

[**PipelineStage**](PipelineStage.md)

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

