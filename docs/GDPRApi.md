# HubSpot.NET.Api.GDPRApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCrmV3ObjectsContactsGdprDelete**](GDPRApi.md#postcrmv3objectscontactsgdprdelete) | **POST** /crm/v3/objects/contacts/gdpr-delete | GDPR DELETE
[**PostCrmV3ObjectsObjectTypeGdprDelete**](GDPRApi.md#postcrmv3objectsobjecttypegdprdelete) | **POST** /crm/v3/objects/{objectType}/gdpr-delete | GDPR DELETE


<a name="postcrmv3objectscontactsgdprdelete"></a>
# **PostCrmV3ObjectsContactsGdprDelete**
> void PostCrmV3ObjectsContactsGdprDelete (PublicGdprDeleteInput publicGdprDeleteInput)

GDPR DELETE

Permanently delete a contact and all associated content to follow GDPR. Use optional property 'idProperty' set to 'email' to identify contact by email address. If email address is not found, the email address will be added to a blocklist and prevent it from being used in the future.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsContactsGdprDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GDPRApi(config);
            var publicGdprDeleteInput = new PublicGdprDeleteInput(); // PublicGdprDeleteInput | 

            try
            {
                // GDPR DELETE
                apiInstance.PostCrmV3ObjectsContactsGdprDelete(publicGdprDeleteInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsContactsGdprDelete: " + e.Message );
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
 **publicGdprDeleteInput** | [**PublicGdprDeleteInput**](PublicGdprDeleteInput.md)|  | 

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

<a name="postcrmv3objectsobjecttypegdprdelete"></a>
# **PostCrmV3ObjectsObjectTypeGdprDelete**
> void PostCrmV3ObjectsObjectTypeGdprDelete (string objectType, PublicGdprDeleteInput publicGdprDeleteInput)

GDPR DELETE

Permanently delete a contact and all associated content to follow GDPR. Use optional property 'idProperty' set to 'email' to identify contact by email address. If email address is not found, the email address will be added to a blocklist and prevent it from being used in the future.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeGdprDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new GDPRApi(config);
            var objectType = "objectType_example";  // string | 
            var publicGdprDeleteInput = new PublicGdprDeleteInput(); // PublicGdprDeleteInput | 

            try
            {
                // GDPR DELETE
                apiInstance.PostCrmV3ObjectsObjectTypeGdprDelete(objectType, publicGdprDeleteInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsObjectTypeGdprDelete: " + e.Message );
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
 **publicGdprDeleteInput** | [**PublicGdprDeleteInput**](PublicGdprDeleteInput.md)|  | 

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

