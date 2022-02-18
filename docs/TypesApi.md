# HubSpot.NET.Api.TypesApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll**](TypesApi.md#getcrmv3associationsfromobjecttypetoobjecttypetypesgetall) | **GET** /crm/v3/associations/{fromObjectType}/{toObjectType}/types | List association types


<a name="getcrmv3associationsfromobjecttypetoobjecttypetypesgetall"></a>
# **GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll**
> CollectionResponsePublicAssociationDefiniton GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll (string fromObjectType, string toObjectType)

List association types

List all the valid association types available between two object types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new TypesApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 

            try
            {
                // List association types
                CollectionResponsePublicAssociationDefiniton result = apiInstance.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll(fromObjectType, toObjectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TypesApi.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll: " + e.Message );
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
 **fromObjectType** | **string**|  | 
 **toObjectType** | **string**|  | 

### Return type

[**CollectionResponsePublicAssociationDefiniton**](CollectionResponsePublicAssociationDefiniton.md)

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

