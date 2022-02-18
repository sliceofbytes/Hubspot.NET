# HubSpot.NET.Api.PublicObjectSchemasApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurge**](PublicObjectSchemasApi.md#deletecrmobjectschemasv3schemasobjecttypepurgepurge) | **DELETE** /crm/v3/schemas/{objectType}/purge | 


<a name="deletecrmobjectschemasv3schemasobjecttypepurgepurge"></a>
# **DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurge**
> void DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurge (string objectType)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new PublicObjectSchemasApi(config);
            var objectType = "objectType_example";  // string | 

            try
            {
                apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurge(objectType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicObjectSchemasApi.DeleteCrmObjectSchemasV3SchemasObjectTypePurgePurge: " + e.Message );
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

