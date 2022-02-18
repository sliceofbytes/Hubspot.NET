# HubSpot.NET.Api.BlogTagsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCmsV3BlogsTagsObjectIdArchive**](BlogTagsApi.md#deletecmsv3blogstagsobjectidarchive) | **DELETE** /cms/v3/blogs/tags/{objectId} | Delete a Blog Tag
[**GetCmsV3BlogsTagsGetPage**](BlogTagsApi.md#getcmsv3blogstagsgetpage) | **GET** /cms/v3/blogs/tags | Get all Blog Tags
[**GetCmsV3BlogsTagsObjectIdGetById**](BlogTagsApi.md#getcmsv3blogstagsobjectidgetbyid) | **GET** /cms/v3/blogs/tags/{objectId} | Retrieve a Blog Tag
[**PatchCmsV3BlogsTagsObjectIdUpdate**](BlogTagsApi.md#patchcmsv3blogstagsobjectidupdate) | **PATCH** /cms/v3/blogs/tags/{objectId} | Update a Blog Tag
[**PostCmsV3BlogsTagsBatchArchiveArchiveBatch**](BlogTagsApi.md#postcmsv3blogstagsbatcharchivearchivebatch) | **POST** /cms/v3/blogs/tags/batch/archive | Delete a batch of Blog Tags
[**PostCmsV3BlogsTagsBatchCreateCreateBatch**](BlogTagsApi.md#postcmsv3blogstagsbatchcreatecreatebatch) | **POST** /cms/v3/blogs/tags/batch/create | Create a batch of Blog Tags
[**PostCmsV3BlogsTagsBatchReadReadBatch**](BlogTagsApi.md#postcmsv3blogstagsbatchreadreadbatch) | **POST** /cms/v3/blogs/tags/batch/read | Retrieve a batch of Blog Tags
[**PostCmsV3BlogsTagsBatchUpdateUpdateBatch**](BlogTagsApi.md#postcmsv3blogstagsbatchupdateupdatebatch) | **POST** /cms/v3/blogs/tags/batch/update | Update a batch of Blog Tags
[**PostCmsV3BlogsTagsCreate**](BlogTagsApi.md#postcmsv3blogstagscreate) | **POST** /cms/v3/blogs/tags | Create a new Blog Tag
[**PostCmsV3BlogsTagsMultiLanguageAttachToLangGroup**](BlogTagsApi.md#postcmsv3blogstagsmultilanguageattachtolanggroup) | **POST** /cms/v3/blogs/tags/multi-language/attach-to-lang-group | Attach a Blog Tag to a multi-language group
[**PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariation**](BlogTagsApi.md#postcmsv3blogstagsmultilanguagecreatelanguagevariation) | **POST** /cms/v3/blogs/tags/multi-language/create-language-variation | Create a new language variation
[**PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroup**](BlogTagsApi.md#postcmsv3blogstagsmultilanguagedetachfromlanggroup) | **POST** /cms/v3/blogs/tags/multi-language/detach-from-lang-group | Detach a Blog Tag from a multi-language group
[**PostCmsV3BlogsTagsMultiLanguageUpdateLanguages**](BlogTagsApi.md#postcmsv3blogstagsmultilanguageupdatelanguages) | **POST** /cms/v3/blogs/tags/multi-language/update-languages | Update languages of multi-language group
[**PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimary**](BlogTagsApi.md#putcmsv3blogstagsmultilanguagesetnewlangprimary) | **PUT** /cms/v3/blogs/tags/multi-language/set-new-lang-primary | Set a new primary language


<a name="deletecmsv3blogstagsobjectidarchive"></a>
# **DeleteCmsV3BlogsTagsObjectIdArchive**
> void DeleteCmsV3BlogsTagsObjectIdArchive (string objectId, bool? archived = null)

Delete a Blog Tag

Delete the Blog Tag object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCmsV3BlogsTagsObjectIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var objectId = "objectId_example";  // string | The Blog Tag id.
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Delete a Blog Tag
                apiInstance.DeleteCmsV3BlogsTagsObjectIdArchive(objectId, archived);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.DeleteCmsV3BlogsTagsObjectIdArchive: " + e.Message );
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
 **objectId** | **string**| The Blog Tag id. | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] 

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

<a name="getcmsv3blogstagsgetpage"></a>
# **GetCmsV3BlogsTagsGetPage**
> CollectionResponseWithTotalTagForwardPaging GetCmsV3BlogsTagsGetPage (DateTimeOffset? createdAt = null, DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null, DateTimeOffset? updatedAt = null, DateTimeOffset? updatedAfter = null, DateTimeOffset? updatedBefore = null, List<string> sort = null, string after = null, int? limit = null, bool? archived = null)

Get all Blog Tags

Get the list of blog tags. Supports paging and filtering. This method would be useful for an integration that examined these models and used an external service to suggest edits. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3BlogsTagsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags created at exactly the specified time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags created after the specified time. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags created before the specified time. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags last updated at exactly the specified time. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags last updated after the specified time. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return Blog Tags last updated before the specified time. (optional) 
            var sort = new List<string>(); // List<string> | Specifies which fields to use for sorting results. Valid fields are `name`, `createdAt`, `updatedAt`, `createdBy`, `updatedBy`. `createdAt` will be used by default. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 100. (optional) 
            var archived = true;  // bool? | Specifies whether to return deleted Blog Tags. Defaults to `false`. (optional) 

            try
            {
                // Get all Blog Tags
                CollectionResponseWithTotalTagForwardPaging result = apiInstance.GetCmsV3BlogsTagsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.GetCmsV3BlogsTagsGetPage: " + e.Message );
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
 **createdAt** | **DateTimeOffset?**| Only return Blog Tags created at exactly the specified time. | [optional] 
 **createdAfter** | **DateTimeOffset?**| Only return Blog Tags created after the specified time. | [optional] 
 **createdBefore** | **DateTimeOffset?**| Only return Blog Tags created before the specified time. | [optional] 
 **updatedAt** | **DateTimeOffset?**| Only return Blog Tags last updated at exactly the specified time. | [optional] 
 **updatedAfter** | **DateTimeOffset?**| Only return Blog Tags last updated after the specified time. | [optional] 
 **updatedBefore** | **DateTimeOffset?**| Only return Blog Tags last updated before the specified time. | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Specifies which fields to use for sorting results. Valid fields are &#x60;name&#x60;, &#x60;createdAt&#x60;, &#x60;updatedAt&#x60;, &#x60;createdBy&#x60;, &#x60;updatedBy&#x60;. &#x60;createdAt&#x60; will be used by default. | [optional] 
 **after** | **string**| The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **limit** | **int?**| The maximum number of results to return. Default is 100. | [optional] 
 **archived** | **bool?**| Specifies whether to return deleted Blog Tags. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**CollectionResponseWithTotalTagForwardPaging**](CollectionResponseWithTotalTagForwardPaging.md)

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

<a name="getcmsv3blogstagsobjectidgetbyid"></a>
# **GetCmsV3BlogsTagsObjectIdGetById**
> Tag GetCmsV3BlogsTagsObjectIdGetById (string objectId, bool? archived = null)

Retrieve a Blog Tag

Retrieve the Blog Tag object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3BlogsTagsObjectIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var objectId = "objectId_example";  // string | The Blog Tag id.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Tags. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a Blog Tag
                Tag result = apiInstance.GetCmsV3BlogsTagsObjectIdGetById(objectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.GetCmsV3BlogsTagsObjectIdGetById: " + e.Message );
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
 **objectId** | **string**| The Blog Tag id. | 
 **archived** | **bool?**| Specifies whether to return deleted Blog Tags. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**Tag**](Tag.md)

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

<a name="patchcmsv3blogstagsobjectidupdate"></a>
# **PatchCmsV3BlogsTagsObjectIdUpdate**
> Tag PatchCmsV3BlogsTagsObjectIdUpdate (string objectId, Tag tag, bool? archived = null)

Update a Blog Tag

Sparse updates a single Blog Tag object identified by the id in the path. All the column values need not be specified. Only the that need to be modified can be specified. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCmsV3BlogsTagsObjectIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var objectId = "objectId_example";  // string | The Blog Tag id.
            var tag = new Tag(); // Tag | The JSON representation of the updated Blog Tag.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Tags. Defaults to `false`. (optional) 

            try
            {
                // Update a Blog Tag
                Tag result = apiInstance.PatchCmsV3BlogsTagsObjectIdUpdate(objectId, tag, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PatchCmsV3BlogsTagsObjectIdUpdate: " + e.Message );
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
 **objectId** | **string**| The Blog Tag id. | 
 **tag** | [**Tag**](Tag.md)| The JSON representation of the updated Blog Tag. | 
 **archived** | **bool?**| Specifies whether to update deleted Blog Tags. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**Tag**](Tag.md)

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

<a name="postcmsv3blogstagsbatcharchivearchivebatch"></a>
# **PostCmsV3BlogsTagsBatchArchiveArchiveBatch**
> void PostCmsV3BlogsTagsBatchArchiveArchiveBatch (BatchInputString batchInputString)

Delete a batch of Blog Tags

Delete the Blog Tag objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsBatchArchiveArchiveBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Tag ids.

            try
            {
                // Delete a batch of Blog Tags
                apiInstance.PostCmsV3BlogsTagsBatchArchiveArchiveBatch(batchInputString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsBatchArchiveArchiveBatch: " + e.Message );
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
 **batchInputString** | [**BatchInputString**](BatchInputString.md)| The JSON array of Blog Tag ids. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagsbatchcreatecreatebatch"></a>
# **PostCmsV3BlogsTagsBatchCreateCreateBatch**
> BatchResponseTag PostCmsV3BlogsTagsBatchCreateCreateBatch (BatchInputTag batchInputTag)

Create a batch of Blog Tags

Create the Blog Tag objects detailed in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsBatchCreateCreateBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var batchInputTag = new BatchInputTag(); // BatchInputTag | The JSON array of new Blog Tags to create.

            try
            {
                // Create a batch of Blog Tags
                BatchResponseTag result = apiInstance.PostCmsV3BlogsTagsBatchCreateCreateBatch(batchInputTag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsBatchCreateCreateBatch: " + e.Message );
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
 **batchInputTag** | [**BatchInputTag**](BatchInputTag.md)| The JSON array of new Blog Tags to create. | 

### Return type

[**BatchResponseTag**](BatchResponseTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagsbatchreadreadbatch"></a>
# **PostCmsV3BlogsTagsBatchReadReadBatch**
> BatchResponseTag PostCmsV3BlogsTagsBatchReadReadBatch (BatchInputString batchInputString, bool? archived = null)

Retrieve a batch of Blog Tags

Retrieve the Blog Tag objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsBatchReadReadBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Tag ids.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Tags. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a batch of Blog Tags
                BatchResponseTag result = apiInstance.PostCmsV3BlogsTagsBatchReadReadBatch(batchInputString, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsBatchReadReadBatch: " + e.Message );
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
 **batchInputString** | [**BatchInputString**](BatchInputString.md)| The JSON array of Blog Tag ids. | 
 **archived** | **bool?**| Specifies whether to return deleted Blog Tags. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**BatchResponseTag**](BatchResponseTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagsbatchupdateupdatebatch"></a>
# **PostCmsV3BlogsTagsBatchUpdateUpdateBatch**
> BatchResponseTag PostCmsV3BlogsTagsBatchUpdateUpdateBatch (BatchInputJsonNode batchInputJsonNode, bool? archived = null)

Update a batch of Blog Tags

Update the Blog Tag objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsBatchUpdateUpdateBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var batchInputJsonNode = new BatchInputJsonNode(); // BatchInputJsonNode | A JSON array of the JSON representations of the updated Blog Tags.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Tags. Defaults to `false`. (optional) 

            try
            {
                // Update a batch of Blog Tags
                BatchResponseTag result = apiInstance.PostCmsV3BlogsTagsBatchUpdateUpdateBatch(batchInputJsonNode, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsBatchUpdateUpdateBatch: " + e.Message );
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
 **batchInputJsonNode** | [**BatchInputJsonNode**](BatchInputJsonNode.md)| A JSON array of the JSON representations of the updated Blog Tags. | 
 **archived** | **bool?**| Specifies whether to update deleted Blog Tags. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**BatchResponseTag**](BatchResponseTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagscreate"></a>
# **PostCmsV3BlogsTagsCreate**
> Tag PostCmsV3BlogsTagsCreate (Tag tag)

Create a new Blog Tag

Create a new Blog Tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var tag = new Tag(); // Tag | The JSON representation of a new Blog Tag.

            try
            {
                // Create a new Blog Tag
                Tag result = apiInstance.PostCmsV3BlogsTagsCreate(tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsCreate: " + e.Message );
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
 **tag** | [**Tag**](Tag.md)| The JSON representation of a new Blog Tag. | 

### Return type

[**Tag**](Tag.md)

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

<a name="postcmsv3blogstagsmultilanguageattachtolanggroup"></a>
# **PostCmsV3BlogsTagsMultiLanguageAttachToLangGroup**
> Error PostCmsV3BlogsTagsMultiLanguageAttachToLangGroup (AttachToLangPrimaryRequestVNext attachToLangPrimaryRequestVNext)

Attach a Blog Tag to a multi-language group

Attach a Blog Tag to a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsMultiLanguageAttachToLangGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var attachToLangPrimaryRequestVNext = new AttachToLangPrimaryRequestVNext(); // AttachToLangPrimaryRequestVNext | The JSON representation of the AttachToLangPrimaryRequest object.

            try
            {
                // Attach a Blog Tag to a multi-language group
                Error result = apiInstance.PostCmsV3BlogsTagsMultiLanguageAttachToLangGroup(attachToLangPrimaryRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsMultiLanguageAttachToLangGroup: " + e.Message );
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
 **attachToLangPrimaryRequestVNext** | [**AttachToLangPrimaryRequestVNext**](AttachToLangPrimaryRequestVNext.md)| The JSON representation of the AttachToLangPrimaryRequest object. | 

### Return type

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagsmultilanguagecreatelanguagevariation"></a>
# **PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariation**
> Tag PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariation (TagCloneRequestVNext tagCloneRequestVNext)

Create a new language variation

Create a new language variation from an existing Blog Tag

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var tagCloneRequestVNext = new TagCloneRequestVNext(); // TagCloneRequestVNext | The JSON representation of the ContentLanguageCloneRequest object.

            try
            {
                // Create a new language variation
                Tag result = apiInstance.PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariation(tagCloneRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsMultiLanguageCreateLanguageVariation: " + e.Message );
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
 **tagCloneRequestVNext** | [**TagCloneRequestVNext**](TagCloneRequestVNext.md)| The JSON representation of the ContentLanguageCloneRequest object. | 

### Return type

[**Tag**](Tag.md)

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

<a name="postcmsv3blogstagsmultilanguagedetachfromlanggroup"></a>
# **PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroup**
> Error PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroup (DetachFromLangGroupRequestVNext detachFromLangGroupRequestVNext)

Detach a Blog Tag from a multi-language group

Detach a Blog Tag from a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var detachFromLangGroupRequestVNext = new DetachFromLangGroupRequestVNext(); // DetachFromLangGroupRequestVNext | The JSON representation of the DetachFromLangGroupRequest object.

            try
            {
                // Detach a Blog Tag from a multi-language group
                Error result = apiInstance.PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroup(detachFromLangGroupRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsMultiLanguageDetachFromLangGroup: " + e.Message );
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
 **detachFromLangGroupRequestVNext** | [**DetachFromLangGroupRequestVNext**](DetachFromLangGroupRequestVNext.md)| The JSON representation of the DetachFromLangGroupRequest object. | 

### Return type

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcmsv3blogstagsmultilanguageupdatelanguages"></a>
# **PostCmsV3BlogsTagsMultiLanguageUpdateLanguages**
> Error PostCmsV3BlogsTagsMultiLanguageUpdateLanguages (UpdateLanguagesRequestVNext updateLanguagesRequestVNext)

Update languages of multi-language group

Explicitly set new languages for each Blog Tag in a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3BlogsTagsMultiLanguageUpdateLanguagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var updateLanguagesRequestVNext = new UpdateLanguagesRequestVNext(); // UpdateLanguagesRequestVNext | The JSON representation of the UpdateLanguagesRequest object.

            try
            {
                // Update languages of multi-language group
                Error result = apiInstance.PostCmsV3BlogsTagsMultiLanguageUpdateLanguages(updateLanguagesRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PostCmsV3BlogsTagsMultiLanguageUpdateLanguages: " + e.Message );
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
 **updateLanguagesRequestVNext** | [**UpdateLanguagesRequestVNext**](UpdateLanguagesRequestVNext.md)| The JSON representation of the UpdateLanguagesRequest object. | 

### Return type

[**Error**](Error.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcmsv3blogstagsmultilanguagesetnewlangprimary"></a>
# **PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimary**
> void PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimary (SetNewLanguagePrimaryRequestVNext setNewLanguagePrimaryRequestVNext)

Set a new primary language

Set a Blog Tag as the primary language of a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new BlogTagsApi(config);
            var setNewLanguagePrimaryRequestVNext = new SetNewLanguagePrimaryRequestVNext(); // SetNewLanguagePrimaryRequestVNext | The JSON representation of the SetNewLanguagePrimaryRequest object.

            try
            {
                // Set a new primary language
                apiInstance.PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimary(setNewLanguagePrimaryRequestVNext);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogTagsApi.PutCmsV3BlogsTagsMultiLanguageSetNewLangPrimary: " + e.Message );
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
 **setNewLanguagePrimaryRequestVNext** | [**SetNewLanguagePrimaryRequestVNext**](SetNewLanguagePrimaryRequestVNext.md)| The JSON representation of the SetNewLanguagePrimaryRequest object. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

