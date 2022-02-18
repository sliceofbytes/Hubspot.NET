# HubSpot.NET.Api.MetadataApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCmsV3SourceCodeEnvironmentMetadataPath**](MetadataApi.md#getcmsv3sourcecodeenvironmentmetadatapath) | **GET** /cms/v3/source-code/{environment}/metadata/{path} | Get the metadata for a file


<a name="getcmsv3sourcecodeenvironmentmetadatapath"></a>
# **GetCmsV3SourceCodeEnvironmentMetadataPath**
> AssetFileMetadata GetCmsV3SourceCodeEnvironmentMetadataPath (string environment, string path)

Get the metadata for a file

Gets the metadata object for the file at the specified path in the specified environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3SourceCodeEnvironmentMetadataPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new MetadataApi(config);
            var environment = "environment_example";  // string | The environment of the file (\"draft\" or \"published\").
            var path = "path_example";  // string | The file system location of the file.

            try
            {
                // Get the metadata for a file
                AssetFileMetadata result = apiInstance.GetCmsV3SourceCodeEnvironmentMetadataPath(environment, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCmsV3SourceCodeEnvironmentMetadataPath: " + e.Message );
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
 **environment** | **string**| The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;). | 
 **path** | **string**| The file system location of the file. | 

### Return type

[**AssetFileMetadata**](AssetFileMetadata.md)

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

