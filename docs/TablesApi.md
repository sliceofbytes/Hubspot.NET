# HubSpot.NET.Api.TablesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCmsV3HubdbTablesTableIdOrNameArchiveTable**](TablesApi.md#deletecmsv3hubdbtablestableidornamearchivetable) | **DELETE** /cms/v3/hubdb/tables/{tableIdOrName} | Archive a table
[**GetCmsV3HubdbTablesDraftGetAllDraftTables**](TablesApi.md#getcmsv3hubdbtablesdraftgetalldrafttables) | **GET** /cms/v3/hubdb/tables/draft | Return all draft tables
[**GetCmsV3HubdbTablesGetAllTables**](TablesApi.md#getcmsv3hubdbtablesgetalltables) | **GET** /cms/v3/hubdb/tables | Get all published tables
[**GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTable**](TablesApi.md#getcmsv3hubdbtablestableidornamedraftexportexportdrafttable) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/draft/export | Export a draft table
[**GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsById**](TablesApi.md#getcmsv3hubdbtablestableidornamedraftgetdrafttabledetailsbyid) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/draft | Get details for a draft table
[**GetCmsV3HubdbTablesTableIdOrNameExportExportTable**](TablesApi.md#getcmsv3hubdbtablestableidornameexportexporttable) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/export | Export a published version of a table
[**GetCmsV3HubdbTablesTableIdOrNameGetTableDetails**](TablesApi.md#getcmsv3hubdbtablestableidornamegettabledetails) | **GET** /cms/v3/hubdb/tables/{tableIdOrName} | Get details for a published table
[**PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTable**](TablesApi.md#patchcmsv3hubdbtablestableidornamedraftupdatedrafttable) | **PATCH** /cms/v3/hubdb/tables/{tableIdOrName}/draft | Update an existing table
[**PostCmsV3HubdbTablesCreateTable**](TablesApi.md#postcmsv3hubdbtablescreatetable) | **POST** /cms/v3/hubdb/tables | Create a new table
[**PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTable**](TablesApi.md#postcmsv3hubdbtablestableidornamedraftcloneclonedrafttable) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/draft/clone | Clone a table
[**PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTable**](TablesApi.md#postcmsv3hubdbtablestableidornamedraftimportimportdrafttable) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/draft/import | Import data into draft table
[**PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTable**](TablesApi.md#postcmsv3hubdbtablestableidornamedraftpublishpublishdrafttable) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/draft/publish | Publish a table from draft
[**PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTable**](TablesApi.md#postcmsv3hubdbtablestableidornamedraftresetresetdrafttable) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/draft/reset | Reset a draft table
[**PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTable**](TablesApi.md#postcmsv3hubdbtablestableidornameunpublishunpublishtable) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/unpublish | Unpublish a table


<a name="deletecmsv3hubdbtablestableidornamearchivetable"></a>
# **DeleteCmsV3HubdbTablesTableIdOrNameArchiveTable**
> void DeleteCmsV3HubdbTablesTableIdOrNameArchiveTable (string tableIdOrName)

Archive a table

Archive (soft delete) an existing HubDB table. This archives both the published and draft versions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCmsV3HubdbTablesTableIdOrNameArchiveTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to archive.

            try
            {
                // Archive a table
                apiInstance.DeleteCmsV3HubdbTablesTableIdOrNameArchiveTable(tableIdOrName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.DeleteCmsV3HubdbTablesTableIdOrNameArchiveTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to archive. | 

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

<a name="getcmsv3hubdbtablesdraftgetalldrafttables"></a>
# **GetCmsV3HubdbTablesDraftGetAllDraftTables**
> CollectionResponseWithTotalHubDbTableV3ForwardPaging GetCmsV3HubdbTablesDraftGetAllDraftTables (List<string> sort = null, string after = null, int? limit = null, DateTimeOffset? createdAt = null, DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null, DateTimeOffset? updatedAt = null, DateTimeOffset? updatedAfter = null, DateTimeOffset? updatedBefore = null, bool? archived = null)

Return all draft tables

Returns the details for each draft table defined in the specified account, including column definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesDraftGetAllDraftTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var sort = new List<string>(); // List<string> | Specifies which fields to use for sorting results. Valid fields are `name`, `createdAt`, `updatedAt`, `createdBy`, `updatedBy`. `createdAt` will be used by default. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 1000. (optional) 
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created at exactly the specified time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created after the specified time. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created before the specified time. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated at exactly the specified time. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated after the specified time. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated before the specified time. (optional) 
            var archived = true;  // bool? | Specifies whether to return archived tables. Defaults to `false`. (optional) 

            try
            {
                // Return all draft tables
                CollectionResponseWithTotalHubDbTableV3ForwardPaging result = apiInstance.GetCmsV3HubdbTablesDraftGetAllDraftTables(sort, after, limit, createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesDraftGetAllDraftTables: " + e.Message );
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
 **sort** | [**List&lt;string&gt;**](string.md)| Specifies which fields to use for sorting results. Valid fields are &#x60;name&#x60;, &#x60;createdAt&#x60;, &#x60;updatedAt&#x60;, &#x60;createdBy&#x60;, &#x60;updatedBy&#x60;. &#x60;createdAt&#x60; will be used by default. | [optional] 
 **after** | **string**| The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **limit** | **int?**| The maximum number of results to return. Default is 1000. | [optional] 
 **createdAt** | **DateTimeOffset?**| Only return tables created at exactly the specified time. | [optional] 
 **createdAfter** | **DateTimeOffset?**| Only return tables created after the specified time. | [optional] 
 **createdBefore** | **DateTimeOffset?**| Only return tables created before the specified time. | [optional] 
 **updatedAt** | **DateTimeOffset?**| Only return tables last updated at exactly the specified time. | [optional] 
 **updatedAfter** | **DateTimeOffset?**| Only return tables last updated after the specified time. | [optional] 
 **updatedBefore** | **DateTimeOffset?**| Only return tables last updated before the specified time. | [optional] 
 **archived** | **bool?**| Specifies whether to return archived tables. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**CollectionResponseWithTotalHubDbTableV3ForwardPaging**](CollectionResponseWithTotalHubDbTableV3ForwardPaging.md)

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

<a name="getcmsv3hubdbtablesgetalltables"></a>
# **GetCmsV3HubdbTablesGetAllTables**
> CollectionResponseWithTotalHubDbTableV3ForwardPaging GetCmsV3HubdbTablesGetAllTables (List<string> sort = null, string after = null, int? limit = null, DateTimeOffset? createdAt = null, DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null, DateTimeOffset? updatedAt = null, DateTimeOffset? updatedAfter = null, DateTimeOffset? updatedBefore = null, bool? archived = null)

Get all published tables

Returns the details for the `published` version of each table defined in an account, including column definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesGetAllTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var sort = new List<string>(); // List<string> | Specifies which fields to use for sorting results. Valid fields are `name`, `createdAt`, `updatedAt`, `createdBy`, `updatedBy`. `createdAt` will be used by default. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 1000. (optional) 
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created at exactly the specified time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created after the specified time. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables created before the specified time. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated at exactly the specified time. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated after the specified time. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Only return tables last updated before the specified time. (optional) 
            var archived = true;  // bool? | Specifies whether to return archived tables. Defaults to `false`. (optional) 

            try
            {
                // Get all published tables
                CollectionResponseWithTotalHubDbTableV3ForwardPaging result = apiInstance.GetCmsV3HubdbTablesGetAllTables(sort, after, limit, createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesGetAllTables: " + e.Message );
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
 **sort** | [**List&lt;string&gt;**](string.md)| Specifies which fields to use for sorting results. Valid fields are &#x60;name&#x60;, &#x60;createdAt&#x60;, &#x60;updatedAt&#x60;, &#x60;createdBy&#x60;, &#x60;updatedBy&#x60;. &#x60;createdAt&#x60; will be used by default. | [optional] 
 **after** | **string**| The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **limit** | **int?**| The maximum number of results to return. Default is 1000. | [optional] 
 **createdAt** | **DateTimeOffset?**| Only return tables created at exactly the specified time. | [optional] 
 **createdAfter** | **DateTimeOffset?**| Only return tables created after the specified time. | [optional] 
 **createdBefore** | **DateTimeOffset?**| Only return tables created before the specified time. | [optional] 
 **updatedAt** | **DateTimeOffset?**| Only return tables last updated at exactly the specified time. | [optional] 
 **updatedAfter** | **DateTimeOffset?**| Only return tables last updated after the specified time. | [optional] 
 **updatedBefore** | **DateTimeOffset?**| Only return tables last updated before the specified time. | [optional] 
 **archived** | **bool?**| Specifies whether to return archived tables. Defaults to &#x60;false&#x60;. | [optional] 

### Return type

[**CollectionResponseWithTotalHubDbTableV3ForwardPaging**](CollectionResponseWithTotalHubDbTableV3ForwardPaging.md)

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

<a name="getcmsv3hubdbtablestableidornamedraftexportexportdrafttable"></a>
# **GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTable**
> System.IO.Stream GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTable (string tableIdOrName, string format = null)

Export a draft table

Exports the `draft` version of a table to CSV / EXCEL format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to export.
            var format = "format_example";  // string | The file format to export. Possible values include `CSV`, `XLSX`, and `XLS`. (optional) 

            try
            {
                // Export a draft table
                System.IO.Stream result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTable(tableIdOrName, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesTableIdOrNameDraftExportExportDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to export. | 
 **format** | **string**| The file format to export. Possible values include &#x60;CSV&#x60;, &#x60;XLSX&#x60;, and &#x60;XLS&#x60;. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ms-excel, text/csv, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcmsv3hubdbtablestableidornamedraftgetdrafttabledetailsbyid"></a>
# **GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsById**
> HubDbTableV3 GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsById (string tableIdOrName, bool? archived = null, bool? includeForeignIds = null)

Get details for a draft table

Get the details for the `draft` version of a specific HubDB table. This will include the definitions for the columns in the table and the number of rows in the table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to return.
            var archived = true;  // bool? | Set this to `true` to return an archived table. Defaults to `false`. (optional) 
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the result. (optional) 

            try
            {
                // Get details for a draft table
                HubDbTableV3 result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsById(tableIdOrName, archived, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesTableIdOrNameDraftGetDraftTableDetailsById: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to return. | 
 **archived** | **bool?**| Set this to &#x60;true&#x60; to return an archived table. Defaults to &#x60;false&#x60;. | [optional] 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the result. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="getcmsv3hubdbtablestableidornameexportexporttable"></a>
# **GetCmsV3HubdbTablesTableIdOrNameExportExportTable**
> System.IO.Stream GetCmsV3HubdbTablesTableIdOrNameExportExportTable (string tableIdOrName, string format = null)

Export a published version of a table

Exports the `published` version of a table to CSV / EXCEL format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameExportExportTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to export.
            var format = "format_example";  // string | The file format to export. Possible values include `CSV`, `XLSX`, and `XLS`. (optional) 

            try
            {
                // Export a published version of a table
                System.IO.Stream result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameExportExportTable(tableIdOrName, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesTableIdOrNameExportExportTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to export. | 
 **format** | **string**| The file format to export. Possible values include &#x60;CSV&#x60;, &#x60;XLSX&#x60;, and &#x60;XLS&#x60;. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ms-excel, text/csv, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcmsv3hubdbtablestableidornamegettabledetails"></a>
# **GetCmsV3HubdbTablesTableIdOrNameGetTableDetails**
> HubDbTableV3 GetCmsV3HubdbTablesTableIdOrNameGetTableDetails (string tableIdOrName, bool? archived = null, bool? includeForeignIds = null)

Get details for a published table

Returns the details for the `published` version of the specified table. This will include the definitions for the columns in the table and the number of rows in the table.  **Note:** This endpoint can be accessed without any authentication if the table is set to be allowed for public access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameGetTableDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to return.
            var archived = true;  // bool? | Set this to `true` to return details for an archived table. Defaults to `false`. (optional) 
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the result. (optional) 

            try
            {
                // Get details for a published table
                HubDbTableV3 result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameGetTableDetails(tableIdOrName, archived, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.GetCmsV3HubdbTablesTableIdOrNameGetTableDetails: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to return. | 
 **archived** | **bool?**| Set this to &#x60;true&#x60; to return details for an archived table. Defaults to &#x60;false&#x60;. | [optional] 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the result. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="patchcmsv3hubdbtablestableidornamedraftupdatedrafttable"></a>
# **PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTable**
> HubDbTableV3 PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTable (string tableIdOrName, HubDbTableV3Request hubDbTableV3Request, bool? archived = null, bool? includeForeignIds = null)

Update an existing table

Update an existing HubDB table. You can use this endpoint to add or remove columns to the table as well as restore an archived table. Tables updated using the endpoint will only modify the `draft` verion of the table. Use `publish` endpoint to push all the changes to the `published` version. To restore a table, include the query parameter `archived=true` and `\"archived\": false` in the json body. **Note:** You need to include all the columns in the input when you are adding/removing/updating a column. If you do not include an already existing column in the request, it will be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to update.
            var hubDbTableV3Request = new HubDbTableV3Request(); // HubDbTableV3Request | The JSON schema for the table being updated.
            var archived = true;  // bool? | Specifies whether to return archived tables. Defaults to `false`. (optional) 
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the result. (optional) 

            try
            {
                // Update an existing table
                HubDbTableV3 result = apiInstance.PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTable(tableIdOrName, hubDbTableV3Request, archived, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PatchCmsV3HubdbTablesTableIdOrNameDraftUpdateDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to update. | 
 **hubDbTableV3Request** | [**HubDbTableV3Request**](HubDbTableV3Request.md)| The JSON schema for the table being updated. | 
 **archived** | **bool?**| Specifies whether to return archived tables. Defaults to &#x60;false&#x60;. | [optional] 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the result. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="postcmsv3hubdbtablescreatetable"></a>
# **PostCmsV3HubdbTablesCreateTable**
> HubDbTableV3 PostCmsV3HubdbTablesCreateTable (HubDbTableV3Request hubDbTableV3Request)

Create a new table

Creates a new draft HubDB table given a JSON schema. The table name and label should be unique for each account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesCreateTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var hubDbTableV3Request = new HubDbTableV3Request(); // HubDbTableV3Request | The JSON schema for the table being created.

            try
            {
                // Create a new table
                HubDbTableV3 result = apiInstance.PostCmsV3HubdbTablesCreateTable(hubDbTableV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesCreateTable: " + e.Message );
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
 **hubDbTableV3Request** | [**HubDbTableV3Request**](HubDbTableV3Request.md)| The JSON schema for the table being created. | 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="postcmsv3hubdbtablestableidornamedraftcloneclonedrafttable"></a>
# **PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTable**
> HubDbTableV3 PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTable (string tableIdOrName, HubDbTableCloneRequest hubDbTableCloneRequest)

Clone a table

Clone an existing HubDB table. The `newName` and `newLabel` of the new table can be sent as JSON in the `body` parameter. This will create the cloned table as a `draft`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to clone.
            var hubDbTableCloneRequest = new HubDbTableCloneRequest(); // HubDbTableCloneRequest | JSON object with the properties newName and newLabel. You can set copyRows to false to clone the table with copying rows and default is true.

            try
            {
                // Clone a table
                HubDbTableV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTable(tableIdOrName, hubDbTableCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesTableIdOrNameDraftCloneCloneDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to clone. | 
 **hubDbTableCloneRequest** | [**HubDbTableCloneRequest**](HubDbTableCloneRequest.md)| JSON object with the properties newName and newLabel. You can set copyRows to false to clone the table with copying rows and default is true. | 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="postcmsv3hubdbtablestableidornamedraftimportimportdrafttable"></a>
# **PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTable**
> ImportResult PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTable (string tableIdOrName, string config = null, System.IO.Stream file = null)

Import data into draft table

Import the contents of a CSV file into an existing HubDB table. The data will always be imported into the `draft` version of the table. Use `/publish` endpoint to push these changes to `published` version. This endpoint takes a multi-part POST request. The first part will be a set of JSON-formatted options for the import and you can specify this with the name as `config`.  The second part will be the CSV file you want to import and you can specify this with the name as `file`. Refer the [overview section](https://developers.hubspot.com/docs/api/cms/hubdb#importing-tables) to check the details and format of the JSON-formatted options for the import.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID of the destination table where data will be imported.
            var config = "config_example";  // string | Configuration for the import in JSON format as described above. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The source CSV file to be imported. (optional) 

            try
            {
                // Import data into draft table
                ImportResult result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTable(tableIdOrName, config, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesTableIdOrNameDraftImportImportDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID of the destination table where data will be imported. | 
 **config** | **string**| Configuration for the import in JSON format as described above. | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**| The source CSV file to be imported. | [optional] 

### Return type

[**ImportResult**](ImportResult.md)

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

<a name="postcmsv3hubdbtablestableidornamedraftpublishpublishdrafttable"></a>
# **PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTable**
> HubDbTableV3 PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTable (string tableIdOrName, bool? includeForeignIds = null)

Publish a table from draft

Publishes the table by copying the data and table schema changes from draft version to the published version, meaning any website pages using data from the table will be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to publish.
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the response. (optional) 

            try
            {
                // Publish a table from draft
                HubDbTableV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTable(tableIdOrName, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesTableIdOrNameDraftPublishPublishDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to publish. | 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the response. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="postcmsv3hubdbtablestableidornamedraftresetresetdrafttable"></a>
# **PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTable**
> HubDbTableV3 PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTable (string tableIdOrName, bool? includeForeignIds = null)

Reset a draft table

Replaces the data in the `draft` version of the table with values from the `published` version. Any unpublished changes in the `draft` will be lost after this call is made.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to reset.
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the response. (optional) 

            try
            {
                // Reset a draft table
                HubDbTableV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTable(tableIdOrName, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesTableIdOrNameDraftResetResetDraftTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to reset. | 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the response. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

<a name="postcmsv3hubdbtablestableidornameunpublishunpublishtable"></a>
# **PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTable**
> HubDbTableV3 PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTable (string tableIdOrName, bool? includeForeignIds = null)

Unpublish a table

Unpublishes the table, meaning any website pages using data from the table will not render any data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TablesApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to publish.
            var includeForeignIds = true;  // bool? | Set this to `true` to populate foreign ID values in the response. (optional) 

            try
            {
                // Unpublish a table
                HubDbTableV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTable(tableIdOrName, includeForeignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TablesApi.PostCmsV3HubdbTablesTableIdOrNameUnpublishUnpublishTable: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to publish. | 
 **includeForeignIds** | **bool?**| Set this to &#x60;true&#x60; to populate foreign ID values in the response. | [optional] 

### Return type

[**HubDbTableV3**](HubDbTableV3.md)

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

