# HubSpot.NET.Api.CoreApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmObjectSchemasV3SchemasObjectTypeArchive**](CoreApi.md#deletecrmobjectschemasv3schemasobjecttypearchive) | **DELETE** /crm/v3/schemas/{objectType} | Delete a schema
[**DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation**](CoreApi.md#deletecrmobjectschemasv3schemasobjecttypeassociationsassociationidentifierarchiveassociation) | **DELETE** /crm/v3/schemas/{objectType}/associations/{associationIdentifier} | Remove an association
[**DeleteCrmV3PropertiesObjectTypePropertyNameArchive**](CoreApi.md#deletecrmv3propertiesobjecttypepropertynamearchive) | **DELETE** /crm/v3/properties/{objectType}/{propertyName} | Archive a property
[**GetCrmObjectSchemasV3SchemasGetAll**](CoreApi.md#getcrmobjectschemasv3schemasgetall) | **GET** /crm/v3/schemas | Get all schemas
[**GetCrmObjectSchemasV3SchemasObjectTypeGetById**](CoreApi.md#getcrmobjectschemasv3schemasobjecttypegetbyid) | **GET** /crm/v3/schemas/{objectType} | Get an existing schema
[**GetCrmV3ImportsGetPage**](CoreApi.md#getcrmv3importsgetpage) | **GET** /crm/v3/imports/ | Get active imports
[**GetCrmV3ImportsImportIdGetById**](CoreApi.md#getcrmv3importsimportidgetbyid) | **GET** /crm/v3/imports/{importId} | Get the information on any import
[**GetCrmV3PropertiesObjectTypeGetAll**](CoreApi.md#getcrmv3propertiesobjecttypegetall) | **GET** /crm/v3/properties/{objectType} | Read all properties
[**GetCrmV3PropertiesObjectTypePropertyNameGetByName**](CoreApi.md#getcrmv3propertiesobjecttypepropertynamegetbyname) | **GET** /crm/v3/properties/{objectType}/{propertyName} | Read a property
[**PatchCrmObjectSchemasV3SchemasObjectTypeUpdate**](CoreApi.md#patchcrmobjectschemasv3schemasobjecttypeupdate) | **PATCH** /crm/v3/schemas/{objectType} | Update a schema
[**PatchCrmV3PropertiesObjectTypePropertyNameUpdate**](CoreApi.md#patchcrmv3propertiesobjecttypepropertynameupdate) | **PATCH** /crm/v3/properties/{objectType}/{propertyName} | Update a property
[**PostCrmObjectSchemasV3SchemasCreate**](CoreApi.md#postcrmobjectschemasv3schemascreate) | **POST** /crm/v3/schemas | Create a new schema
[**PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation**](CoreApi.md#postcrmobjectschemasv3schemasobjecttypeassociationscreateassociation) | **POST** /crm/v3/schemas/{objectType}/associations | Create an association
[**PostCrmV3ImportsCreate**](CoreApi.md#postcrmv3importscreate) | **POST** /crm/v3/imports/ | Start a new import
[**PostCrmV3ImportsImportIdCancelCancel**](CoreApi.md#postcrmv3importsimportidcancelcancel) | **POST** /crm/v3/imports/{importId}/cancel | Cancel an active import
[**PostCrmV3PropertiesObjectTypeCreate**](CoreApi.md#postcrmv3propertiesobjecttypecreate) | **POST** /crm/v3/properties/{objectType} | Create a property


<a name="deletecrmobjectschemasv3schemasobjecttypearchive"></a>
# **DeleteCrmObjectSchemasV3SchemasObjectTypeArchive**
> void DeleteCrmObjectSchemasV3SchemasObjectTypeArchive (string objectType, bool? archived = null)

Delete a schema

Deletes a schema. Any existing records of this schema must be deleted **first**. Otherwise this call will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmObjectSchemasV3SchemasObjectTypeArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Delete a schema
                apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeArchive(objectType, archived);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeArchive: " + e.Message );
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
 **objectType** | **string**| Fully qualified name or object type ID of your schema. | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

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

<a name="deletecrmobjectschemasv3schemasobjecttypeassociationsassociationidentifierarchiveassociation"></a>
# **DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation**
> void DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation (string objectType, string associationIdentifier)

Remove an association

Removes an existing association from a schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var associationIdentifier = "associationIdentifier_example";  // string | Unique ID of the association to remove.

            try
            {
                // Remove an association
                apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation(objectType, associationIdentifier);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation: " + e.Message );
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
 **objectType** | **string**| Fully qualified name or object type ID of your schema. | 
 **associationIdentifier** | **string**| Unique ID of the association to remove. | 

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

<a name="deletecrmv3propertiesobjecttypepropertynamearchive"></a>
# **DeleteCrmV3PropertiesObjectTypePropertyNameArchive**
> void DeleteCrmV3PropertiesObjectTypePropertyNameArchive (string objectType, string propertyName)

Archive a property

Move a property identified by {propertyName} to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3PropertiesObjectTypePropertyNameArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 

            try
            {
                // Archive a property
                apiInstance.DeleteCrmV3PropertiesObjectTypePropertyNameArchive(objectType, propertyName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmV3PropertiesObjectTypePropertyNameArchive: " + e.Message );
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
 **propertyName** | **string**|  | 

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

<a name="getcrmobjectschemasv3schemasgetall"></a>
# **GetCrmObjectSchemasV3SchemasGetAll**
> CollectionResponseObjectSchemaNoPaging GetCrmObjectSchemasV3SchemasGetAll (bool? archived = null)

Get all schemas

Returns all object schemas that have been defined for your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmObjectSchemasV3SchemasGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Get all schemas
                CollectionResponseObjectSchemaNoPaging result = apiInstance.GetCrmObjectSchemasV3SchemasGetAll(archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasGetAll: " + e.Message );
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
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**CollectionResponseObjectSchemaNoPaging**](CollectionResponseObjectSchemaNoPaging.md)

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

<a name="getcrmobjectschemasv3schemasobjecttypegetbyid"></a>
# **GetCrmObjectSchemasV3SchemasObjectTypeGetById**
> ObjectSchema GetCrmObjectSchemasV3SchemasObjectTypeGetById (string objectType)

Get an existing schema

Returns an existing object schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmObjectSchemasV3SchemasObjectTypeGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.

            try
            {
                // Get an existing schema
                ObjectSchema result = apiInstance.GetCrmObjectSchemasV3SchemasObjectTypeGetById(objectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasObjectTypeGetById: " + e.Message );
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
 **objectType** | **string**| Fully qualified name or object type ID of your schema. | 

### Return type

[**ObjectSchema**](ObjectSchema.md)

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

<a name="getcrmv3importsgetpage"></a>
# **GetCrmV3ImportsGetPage**
> CollectionResponsePublicImportResponse GetCrmV3ImportsGetPage (string after = null, string before = null, int? limit = null)

Get active imports

Returns a paged list of active imports for this account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ImportsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of results to display per page. (optional) 

            try
            {
                // Get active imports
                CollectionResponsePublicImportResponse result = apiInstance.GetCrmV3ImportsGetPage(after, before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsGetPage: " + e.Message );
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
 **after** | **string**| The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional] 
 **before** | **string**|  | [optional] 
 **limit** | **int?**| The maximum number of results to display per page. | [optional] 

### Return type

[**CollectionResponsePublicImportResponse**](CollectionResponsePublicImportResponse.md)

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

<a name="getcrmv3importsimportidgetbyid"></a>
# **GetCrmV3ImportsImportIdGetById**
> PublicImportResponse GetCrmV3ImportsImportIdGetById (long importId)

Get the information on any import

A complete summary of an import record, including any updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ImportsImportIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var importId = 789L;  // long | 

            try
            {
                // Get the information on any import
                PublicImportResponse result = apiInstance.GetCrmV3ImportsImportIdGetById(importId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsImportIdGetById: " + e.Message );
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
 **importId** | **long**|  | 

### Return type

[**PublicImportResponse**](PublicImportResponse.md)

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

<a name="getcrmv3propertiesobjecttypegetall"></a>
# **GetCrmV3PropertiesObjectTypeGetAll**
> CollectionResponseProperty GetCrmV3PropertiesObjectTypeGetAll (string objectType, bool? archived = null)

Read all properties

Read all existing properties for the specified object type and HubSpot account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypeGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read all properties
                CollectionResponseProperty result = apiInstance.GetCrmV3PropertiesObjectTypeGetAll(objectType, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypeGetAll: " + e.Message );
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
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**CollectionResponseProperty**](CollectionResponseProperty.md)

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

<a name="getcrmv3propertiesobjecttypepropertynamegetbyname"></a>
# **GetCrmV3PropertiesObjectTypePropertyNameGetByName**
> PropertiesProperty GetCrmV3PropertiesObjectTypePropertyNameGetByName (string objectType, string propertyName, bool? archived = null)

Read a property

Read a property identified by {propertyName}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypePropertyNameGetByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read a property
                PropertiesProperty result = apiInstance.GetCrmV3PropertiesObjectTypePropertyNameGetByName(objectType, propertyName, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypePropertyNameGetByName: " + e.Message );
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
 **propertyName** | **string**|  | 
 **archived** | **bool?**| Whether to return only results that have been archived. | [optional] [default to false]

### Return type

[**PropertiesProperty**](PropertiesProperty.md)

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

<a name="patchcrmobjectschemasv3schemasobjecttypeupdate"></a>
# **PatchCrmObjectSchemasV3SchemasObjectTypeUpdate**
> ObjectTypeDefinition PatchCrmObjectSchemasV3SchemasObjectTypeUpdate (string objectType, ObjectTypeDefinitionPatch objectTypeDefinitionPatch)

Update a schema

Update the details for an existing object schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmObjectSchemasV3SchemasObjectTypeUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var objectTypeDefinitionPatch = new ObjectTypeDefinitionPatch(); // ObjectTypeDefinitionPatch | Attributes to update in your schema.

            try
            {
                // Update a schema
                ObjectTypeDefinition result = apiInstance.PatchCrmObjectSchemasV3SchemasObjectTypeUpdate(objectType, objectTypeDefinitionPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PatchCrmObjectSchemasV3SchemasObjectTypeUpdate: " + e.Message );
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
 **objectType** | **string**| Fully qualified name or object type ID of your schema. | 
 **objectTypeDefinitionPatch** | [**ObjectTypeDefinitionPatch**](ObjectTypeDefinitionPatch.md)| Attributes to update in your schema. | 

### Return type

[**ObjectTypeDefinition**](ObjectTypeDefinition.md)

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

<a name="patchcrmv3propertiesobjecttypepropertynameupdate"></a>
# **PatchCrmV3PropertiesObjectTypePropertyNameUpdate**
> PropertiesProperty PatchCrmV3PropertiesObjectTypePropertyNameUpdate (string objectType, string propertyName, PropertyUpdate propertyUpdate)

Update a property

Perform a partial update of a property identified by {propertyName}. Provided fields will be overwritten.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3PropertiesObjectTypePropertyNameUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 
            var propertyUpdate = new PropertyUpdate(); // PropertyUpdate | 

            try
            {
                // Update a property
                PropertiesProperty result = apiInstance.PatchCrmV3PropertiesObjectTypePropertyNameUpdate(objectType, propertyName, propertyUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PatchCrmV3PropertiesObjectTypePropertyNameUpdate: " + e.Message );
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
 **propertyName** | **string**|  | 
 **propertyUpdate** | [**PropertyUpdate**](PropertyUpdate.md)|  | 

### Return type

[**PropertiesProperty**](PropertiesProperty.md)

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

<a name="postcrmobjectschemasv3schemascreate"></a>
# **PostCrmObjectSchemasV3SchemasCreate**
> ObjectSchema PostCrmObjectSchemasV3SchemasCreate (ObjectSchemaEgg objectSchemaEgg)

Create a new schema

Define a new object schema, along with custom properties and associations. The entire object schema, including its object type ID, properties, and associations will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmObjectSchemasV3SchemasCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectSchemaEgg = new ObjectSchemaEgg(); // ObjectSchemaEgg | Object schema definition, including properties and associations.

            try
            {
                // Create a new schema
                ObjectSchema result = apiInstance.PostCrmObjectSchemasV3SchemasCreate(objectSchemaEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasCreate: " + e.Message );
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
 **objectSchemaEgg** | [**ObjectSchemaEgg**](ObjectSchemaEgg.md)| Object schema definition, including properties and associations. | 

### Return type

[**ObjectSchema**](ObjectSchema.md)

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

<a name="postcrmobjectschemasv3schemasobjecttypeassociationscreateassociation"></a>
# **PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation**
> AssociationDefinition PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation (string objectType, AssociationDefinitionEgg associationDefinitionEgg)

Create an association

Defines a new association between the primary schema's object type and other object types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var associationDefinitionEgg = new AssociationDefinitionEgg(); // AssociationDefinitionEgg | Attributes that define the association.

            try
            {
                // Create an association
                AssociationDefinition result = apiInstance.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation(objectType, associationDefinitionEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation: " + e.Message );
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
 **objectType** | **string**| Fully qualified name or object type ID of your schema. | 
 **associationDefinitionEgg** | [**AssociationDefinitionEgg**](AssociationDefinitionEgg.md)| Attributes that define the association. | 

### Return type

[**AssociationDefinition**](AssociationDefinition.md)

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

<a name="postcrmv3importscreate"></a>
# **PostCrmV3ImportsCreate**
> PublicImportResponse PostCrmV3ImportsCreate (System.IO.Stream files = null, string importRequest = null)

Start a new import

Begins importing data from the specified file resources. This uploads the corresponding file and uses the import request object to convert rows in the files to objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ImportsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var files = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | A list of files containing the data to import (optional) 
            var importRequest = "importRequest_example";  // string | JSON formatted metadata about the import. This includes a name for the import and the column mappings for each file. See the overview tab for more on the required format. (optional) 

            try
            {
                // Start a new import
                PublicImportResponse result = apiInstance.PostCrmV3ImportsCreate(files, importRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsCreate: " + e.Message );
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
 **files** | **System.IO.Stream****System.IO.Stream**| A list of files containing the data to import | [optional] 
 **importRequest** | **string**| JSON formatted metadata about the import. This includes a name for the import and the column mappings for each file. See the overview tab for more on the required format. | [optional] 

### Return type

[**PublicImportResponse**](PublicImportResponse.md)

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

<a name="postcrmv3importsimportidcancelcancel"></a>
# **PostCrmV3ImportsImportIdCancelCancel**
> ActionResponse PostCrmV3ImportsImportIdCancelCancel (long importId)

Cancel an active import

This allows a developer to cancel an active import.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ImportsImportIdCancelCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var importId = 789L;  // long | 

            try
            {
                // Cancel an active import
                ActionResponse result = apiInstance.PostCrmV3ImportsImportIdCancelCancel(importId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsImportIdCancelCancel: " + e.Message );
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
 **importId** | **long**|  | 

### Return type

[**ActionResponse**](ActionResponse.md)

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

<a name="postcrmv3propertiesobjecttypecreate"></a>
# **PostCrmV3PropertiesObjectTypeCreate**
> PropertiesProperty PostCrmV3PropertiesObjectTypeCreate (string objectType, PropertyCreate propertyCreate)

Create a property

Create and return a copy of a new property for the specified object type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyCreate = new PropertyCreate(); // PropertyCreate | 

            try
            {
                // Create a property
                PropertiesProperty result = apiInstance.PostCrmV3PropertiesObjectTypeCreate(objectType, propertyCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3PropertiesObjectTypeCreate: " + e.Message );
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
 **propertyCreate** | [**PropertyCreate**](PropertyCreate.md)|  | 

### Return type

[**PropertiesProperty**](PropertiesProperty.md)

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

