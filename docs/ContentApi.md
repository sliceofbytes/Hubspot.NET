# HubSpot.NET.Api.ContentApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCmsV3SourceCodeEnvironmentContentPath**](ContentApi.md#deletecmsv3sourcecodeenvironmentcontentpath) | **DELETE** /cms/v3/source-code/{environment}/content/{path} | Delete a file
[**GetCmsV3SourceCodeEnvironmentContentPath**](ContentApi.md#getcmsv3sourcecodeenvironmentcontentpath) | **GET** /cms/v3/source-code/{environment}/content/{path} | Download a file
[**PostCmsV3SourceCodeEnvironmentContentPath**](ContentApi.md#postcmsv3sourcecodeenvironmentcontentpath) | **POST** /cms/v3/source-code/{environment}/content/{path} | Create a file
[**PutCmsV3SourceCodeEnvironmentContentPath**](ContentApi.md#putcmsv3sourcecodeenvironmentcontentpath) | **PUT** /cms/v3/source-code/{environment}/content/{path} | Create or update a file


<a name="deletecmsv3sourcecodeenvironmentcontentpath"></a>
# **DeleteCmsV3SourceCodeEnvironmentContentPath**
> void DeleteCmsV3SourceCodeEnvironmentContentPath (string environment, string path)

Delete a file

Deletes the file at the specified path in the specified environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCmsV3SourceCodeEnvironmentContentPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new ContentApi(config);
            var environment = "environment_example";  // string | The environment of the file (\"draft\" or \"published\").
            var path = "path_example";  // string | The file system location of the file.

            try
            {
                // Delete a file
                apiInstance.DeleteCmsV3SourceCodeEnvironmentContentPath(environment, path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.DeleteCmsV3SourceCodeEnvironmentContentPath: " + e.Message );
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

<a name="getcmsv3sourcecodeenvironmentcontentpath"></a>
# **GetCmsV3SourceCodeEnvironmentContentPath**
> Error GetCmsV3SourceCodeEnvironmentContentPath (string environment, string path)

Download a file

Downloads the byte contents of the file at the specified path in the specified environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3SourceCodeEnvironmentContentPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new ContentApi(config);
            var environment = "environment_example";  // string | The environment of the file (\"draft\" or \"published\").
            var path = "path_example";  // string | The file system location of the file.

            try
            {
                // Download a file
                Error result = apiInstance.GetCmsV3SourceCodeEnvironmentContentPath(environment, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.GetCmsV3SourceCodeEnvironmentContentPath: " + e.Message );
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

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3sourcecodeenvironmentcontentpath"></a>
# **PostCmsV3SourceCodeEnvironmentContentPath**
> AssetFileMetadata PostCmsV3SourceCodeEnvironmentContentPath (string environment, string path, System.IO.Stream file = null)

Create a file

Creates a file at the specified path in the specified environment. Accepts multipart/form-data content type. Throws an error if a file already exists at the specified path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3SourceCodeEnvironmentContentPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new ContentApi(config);
            var environment = "environment_example";  // string | The environment of the file (\"draft\" or \"published\").
            var path = "path_example";  // string | The file system location of the file.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The file to upload. (optional) 

            try
            {
                // Create a file
                AssetFileMetadata result = apiInstance.PostCmsV3SourceCodeEnvironmentContentPath(environment, path, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.PostCmsV3SourceCodeEnvironmentContentPath: " + e.Message );
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
 **file** | **System.IO.Stream****System.IO.Stream**| The file to upload. | [optional] 

### Return type

[**AssetFileMetadata**](AssetFileMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcmsv3sourcecodeenvironmentcontentpath"></a>
# **PutCmsV3SourceCodeEnvironmentContentPath**
> AssetFileMetadata PutCmsV3SourceCodeEnvironmentContentPath (string environment, string path, System.IO.Stream file = null)

Create or update a file

Upserts a file at the specified path in the specified environment. Accepts multipart/form-data content type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCmsV3SourceCodeEnvironmentContentPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new ContentApi(config);
            var environment = "environment_example";  // string | The environment of the file (\"draft\" or \"published\").
            var path = "path_example";  // string | The file system location of the file.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The file to upload. (optional) 

            try
            {
                // Create or update a file
                AssetFileMetadata result = apiInstance.PutCmsV3SourceCodeEnvironmentContentPath(environment, path, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.PutCmsV3SourceCodeEnvironmentContentPath: " + e.Message );
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
 **file** | **System.IO.Stream****System.IO.Stream**| The file to upload. | [optional] 

### Return type

[**AssetFileMetadata**](AssetFileMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

