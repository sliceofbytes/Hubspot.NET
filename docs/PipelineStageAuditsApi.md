# HubSpot.NET.Api.PipelineStageAuditsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAudit**](PipelineStageAuditsApi.md#getcrmv3pipelinesobjecttypepipelineidstagesstageidaudit) | **GET** /crm/v3/pipelines/{objectType}/{pipelineId}/stages/{stageId}/audit | Return an audit of all changes to the pipeline stage


<a name="getcrmv3pipelinesobjecttypepipelineidstagesstageidaudit"></a>
# **GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAudit**
> CollectionResponsePublicAuditInfoNoPaging GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAudit (string objectType, string pipelineId, string stageId)

Return an audit of all changes to the pipeline stage

Return a reverse chronological list of all mutations that have occurred on the pipeline stage identified by `{stageId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAuditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineStageAuditsApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 
            var stageId = "stageId_example";  // string | 

            try
            {
                // Return an audit of all changes to the pipeline stage
                CollectionResponsePublicAuditInfoNoPaging result = apiInstance.GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAudit(objectType, pipelineId, stageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineStageAuditsApi.GetCrmV3PipelinesObjectTypePipelineIdStagesStageIdAudit: " + e.Message );
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

[**CollectionResponsePublicAuditInfoNoPaging**](CollectionResponsePublicAuditInfoNoPaging.md)

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

