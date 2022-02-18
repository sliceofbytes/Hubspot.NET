# HubSpot.NET.Api.RowsBatchApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsbatchreadbatchreadtablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/batch/read | Get a set of rows
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchclonebatchclonedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/clone | Clone rows in batch
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchcreatebatchcreatedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/create | Create rows in batch
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchpurgebatchpurgedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/purge | Permanently deletes rows
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchreadbatchreaddrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/read | Get a set of rows from draft table
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchreplacebatchreplacedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/replace | Replace rows in batch in draft table
[**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchupdatebatchupdatedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/update | Update rows in batch in draft table


<a name="postcmsv3hubdbtablestableidornamerowsbatchreadbatchreadtablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRows (string tableIdOrName, HubdbBatchInputString hubdbBatchInputString)

Get a set of rows

Returns rows in the `published` version of the specified table, given a set of row ids. **Note:** This endpoint can be accessed without any authentication if the table is set to be allowed for public access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to query.
            var hubdbBatchInputString = new HubdbBatchInputString(); // HubdbBatchInputString | The JSON array of row ids

            try
            {
                // Get a set of rows
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRows(tableIdOrName, hubdbBatchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadBatchReadTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table to query. | 
 **hubdbBatchInputString** | [**HubdbBatchInputString**](HubdbBatchInputString.md)| The JSON array of row ids | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchclonebatchclonedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRows (string tableIdOrName, HubdbBatchInputString hubdbBatchInputString)

Clone rows in batch

Clones rows in the `draft` version of the specified table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var hubdbBatchInputString = new HubdbBatchInputString(); // HubdbBatchInputString | The JSON array of row ids

            try
            {
                // Clone rows in batch
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRows(tableIdOrName, hubdbBatchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneBatchCloneDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **hubdbBatchInputString** | [**HubdbBatchInputString**](HubdbBatchInputString.md)| The JSON array of row ids | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchcreatebatchcreatedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRows (string tableIdOrName, BatchInputHubDbTableRowV3Request batchInputHubDbTableRowV3Request)

Create rows in batch

Creates rows in the `draft` version of the specified table, given an array of row objects. See the overview section for more details with an example.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputHubDbTableRowV3Request = new BatchInputHubDbTableRowV3Request(); // BatchInputHubDbTableRowV3Request | JSON array of row objects

            try
            {
                // Create rows in batch
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRows(tableIdOrName, batchInputHubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateBatchCreateDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **batchInputHubDbTableRowV3Request** | [**BatchInputHubDbTableRowV3Request**](BatchInputHubDbTableRowV3Request.md)| JSON array of row objects | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchpurgebatchpurgedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRows**
> void PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRows (string tableIdOrName, HubdbBatchInputString hubdbBatchInputString)

Permanently deletes rows

Permanently deletes rows from the `draft` version of the table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var hubdbBatchInputString = new HubdbBatchInputString(); // HubdbBatchInputString | JSON array of row ids.

            try
            {
                // Permanently deletes rows
                apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRows(tableIdOrName, hubdbBatchInputString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgeBatchPurgeDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **hubdbBatchInputString** | [**HubdbBatchInputString**](HubdbBatchInputString.md)| JSON array of row ids. | 

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchreadbatchreaddrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRows (string tableIdOrName, HubdbBatchInputString hubdbBatchInputString)

Get a set of rows from draft table

Returns rows in the `draft` version of the specified table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var hubdbBatchInputString = new HubdbBatchInputString(); // HubdbBatchInputString | JSON array of row ids.

            try
            {
                // Get a set of rows from draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRows(tableIdOrName, hubdbBatchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadBatchReadDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **hubdbBatchInputString** | [**HubdbBatchInputString**](HubdbBatchInputString.md)| JSON array of row ids. | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchreplacebatchreplacedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRows (string tableIdOrName, BatchInputHubDbTableRowV3Request batchInputHubDbTableRowV3Request)

Replace rows in batch in draft table

Replaces multiple rows as a batch in the `draft` version of the table. See the endpoint `PUT /tables/{tableIdOrName}/rows/{rowId}/draft` for details on updating a single row.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputHubDbTableRowV3Request = new BatchInputHubDbTableRowV3Request(); // BatchInputHubDbTableRowV3Request | JSON array of row objects.

            try
            {
                // Replace rows in batch in draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRows(tableIdOrName, batchInputHubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceBatchReplaceDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **batchInputHubDbTableRowV3Request** | [**BatchInputHubDbTableRowV3Request**](BatchInputHubDbTableRowV3Request.md)| JSON array of row objects. | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

<a name="postcmsv3hubdbtablestableidornamerowsdraftbatchupdatebatchupdatedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRows (string tableIdOrName, HubdbBatchInputJsonNode hubdbBatchInputJsonNode)

Update rows in batch in draft table

Updates multiple rows as a batch in the `draft` version of the table. See the endpoint `PATCH /tables/{tableIdOrName}/rows/{rowId}/draft` for details on updating a single row.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var hubdbBatchInputJsonNode = new HubdbBatchInputJsonNode(); // HubdbBatchInputJsonNode | JSON array of row objects.

            try
            {
                // Update rows in batch in draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRows(tableIdOrName, hubdbBatchInputJsonNode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateBatchUpdateDraftTableRows: " + e.Message );
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
 **tableIdOrName** | **string**| The ID or name of the table | 
 **hubdbBatchInputJsonNode** | [**HubdbBatchInputJsonNode**](HubdbBatchInputJsonNode.md)| JSON array of row objects. | 

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

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

