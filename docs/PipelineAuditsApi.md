# HubSpot.NET.Api.PipelineAuditsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3PipelinesObjectTypePipelineIdAudit**](PipelineAuditsApi.md#getcrmv3pipelinesobjecttypepipelineidaudit) | **GET** /crm/v3/pipelines/{objectType}/{pipelineId}/audit | Return an audit of all changes to the pipeline


<a name="getcrmv3pipelinesobjecttypepipelineidaudit"></a>
# **GetCrmV3PipelinesObjectTypePipelineIdAudit**
> CollectionResponsePublicAuditInfoNoPaging GetCrmV3PipelinesObjectTypePipelineIdAudit (string objectType, string pipelineId)

Return an audit of all changes to the pipeline

Return a reverse chronological list of all mutations that have occurred on the pipeline identified by `{pipelineId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PipelinesObjectTypePipelineIdAuditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PipelineAuditsApi(config);
            var objectType = "objectType_example";  // string | 
            var pipelineId = "pipelineId_example";  // string | 

            try
            {
                // Return an audit of all changes to the pipeline
                CollectionResponsePublicAuditInfoNoPaging result = apiInstance.GetCrmV3PipelinesObjectTypePipelineIdAudit(objectType, pipelineId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineAuditsApi.GetCrmV3PipelinesObjectTypePipelineIdAudit: " + e.Message );
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

