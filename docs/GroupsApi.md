# HubSpot.NET.Api.GroupsApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchive**](GroupsApi.md#deletecrmv3propertiesobjecttypegroupsgroupnamearchive) | **DELETE** /crm/v3/properties/{objectType}/groups/{groupName} | Archive a property group
[**GetCrmV3PropertiesObjectTypeGroupsGetAll**](GroupsApi.md#getcrmv3propertiesobjecttypegroupsgetall) | **GET** /crm/v3/properties/{objectType}/groups | Read all property groups
[**GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByName**](GroupsApi.md#getcrmv3propertiesobjecttypegroupsgroupnamegetbyname) | **GET** /crm/v3/properties/{objectType}/groups/{groupName} | Read a property group
[**PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdate**](GroupsApi.md#patchcrmv3propertiesobjecttypegroupsgroupnameupdate) | **PATCH** /crm/v3/properties/{objectType}/groups/{groupName} | Update a property group
[**PostCrmV3PropertiesObjectTypeGroupsCreate**](GroupsApi.md#postcrmv3propertiesobjecttypegroupscreate) | **POST** /crm/v3/properties/{objectType}/groups | Create a property group


<a name="deletecrmv3propertiesobjecttypegroupsgroupnamearchive"></a>
# **DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchive**
> void DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchive (string objectType, string groupName)

Archive a property group

Move a property group identified by {groupName} to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GroupsApi(config);
            var objectType = "objectType_example";  // string | 
            var groupName = "groupName_example";  // string | 

            try
            {
                // Archive a property group
                apiInstance.DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchive(objectType, groupName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteCrmV3PropertiesObjectTypeGroupsGroupNameArchive: " + e.Message );
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
 **groupName** | **string**|  | 

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

<a name="getcrmv3propertiesobjecttypegroupsgetall"></a>
# **GetCrmV3PropertiesObjectTypeGroupsGetAll**
> CollectionResponsePropertyGroup GetCrmV3PropertiesObjectTypeGroupsGetAll (string objectType)

Read all property groups

Read all existing property groups for the specified object type and HubSpot account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypeGroupsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GroupsApi(config);
            var objectType = "objectType_example";  // string | 

            try
            {
                // Read all property groups
                CollectionResponsePropertyGroup result = apiInstance.GetCrmV3PropertiesObjectTypeGroupsGetAll(objectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetCrmV3PropertiesObjectTypeGroupsGetAll: " + e.Message );
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

[**CollectionResponsePropertyGroup**](CollectionResponsePropertyGroup.md)

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

<a name="getcrmv3propertiesobjecttypegroupsgroupnamegetbyname"></a>
# **GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByName**
> PropertyGroup GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByName (string objectType, string groupName)

Read a property group

Read a property group identified by {groupName}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GroupsApi(config);
            var objectType = "objectType_example";  // string | 
            var groupName = "groupName_example";  // string | 

            try
            {
                // Read a property group
                PropertyGroup result = apiInstance.GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByName(objectType, groupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetCrmV3PropertiesObjectTypeGroupsGroupNameGetByName: " + e.Message );
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
 **groupName** | **string**|  | 

### Return type

[**PropertyGroup**](PropertyGroup.md)

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

<a name="patchcrmv3propertiesobjecttypegroupsgroupnameupdate"></a>
# **PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdate**
> PropertyGroup PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdate (string objectType, string groupName, PropertyGroupUpdate propertyGroupUpdate)

Update a property group

Perform a partial update of a property group identified by {groupName}. Provided fields will be overwritten.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GroupsApi(config);
            var objectType = "objectType_example";  // string | 
            var groupName = "groupName_example";  // string | 
            var propertyGroupUpdate = new PropertyGroupUpdate(); // PropertyGroupUpdate | 

            try
            {
                // Update a property group
                PropertyGroup result = apiInstance.PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdate(objectType, groupName, propertyGroupUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.PatchCrmV3PropertiesObjectTypeGroupsGroupNameUpdate: " + e.Message );
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
 **groupName** | **string**|  | 
 **propertyGroupUpdate** | [**PropertyGroupUpdate**](PropertyGroupUpdate.md)|  | 

### Return type

[**PropertyGroup**](PropertyGroup.md)

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

<a name="postcrmv3propertiesobjecttypegroupscreate"></a>
# **PostCrmV3PropertiesObjectTypeGroupsCreate**
> PropertyGroup PostCrmV3PropertiesObjectTypeGroupsCreate (string objectType, PropertyGroupCreate propertyGroupCreate)

Create a property group

Create and return a copy of a new property group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeGroupsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GroupsApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyGroupCreate = new PropertyGroupCreate(); // PropertyGroupCreate | 

            try
            {
                // Create a property group
                PropertyGroup result = apiInstance.PostCrmV3PropertiesObjectTypeGroupsCreate(objectType, propertyGroupCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.PostCrmV3PropertiesObjectTypeGroupsCreate: " + e.Message );
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
 **propertyGroupCreate** | [**PropertyGroupCreate**](PropertyGroupCreate.md)|  | 

### Return type

[**PropertyGroup**](PropertyGroup.md)

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

