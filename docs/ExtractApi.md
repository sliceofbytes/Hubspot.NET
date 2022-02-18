# HubSpot.NET.Api.ExtractApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCmsV3SourceCodeExtractPath**](ExtractApi.md#postcmsv3sourcecodeextractpath) | **POST** /cms/v3/source-code/extract/{path} | Extracts a zip file


<a name="postcmsv3sourcecodeextractpath"></a>
# **PostCmsV3SourceCodeExtractPath**
> void PostCmsV3SourceCodeExtractPath (string path)

Extracts a zip file

Extracts a zip file in the file system. The zip file will be extracted in-place and not be deleted automatically.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3SourceCodeExtractPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new ExtractApi(config);
            var path = "path_example";  // string | The file system location of the zip file.

            try
            {
                // Extracts a zip file
                apiInstance.PostCmsV3SourceCodeExtractPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.PostCmsV3SourceCodeExtractPath: " + e.Message );
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
 **path** | **string**| The file system location of the zip file. | 

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

