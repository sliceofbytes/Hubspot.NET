# HubSpot.NET.Api.SearchApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketingV3MarketingEventsEventsSearch**](SearchApi.md#getmarketingv3marketingeventseventssearch) | **GET** /marketing/v3/marketing-events/events/search | Search for marketing events
[**PostCrmV3ObjectsCompaniesSearchDoSearch**](SearchApi.md#postcrmv3objectscompaniessearchdosearch) | **POST** /crm/v3/objects/companies/search | 
[**PostCrmV3ObjectsContactsSearchDoSearch**](SearchApi.md#postcrmv3objectscontactssearchdosearch) | **POST** /crm/v3/objects/contacts/search | 
[**PostCrmV3ObjectsDealsSearchDoSearch**](SearchApi.md#postcrmv3objectsdealssearchdosearch) | **POST** /crm/v3/objects/deals/search | 
[**PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch**](SearchApi.md#postcrmv3objectsfeedbacksubmissionssearchdosearch) | **POST** /crm/v3/objects/feedback_submissions/search | 
[**PostCrmV3ObjectsLineItemsSearchDoSearch**](SearchApi.md#postcrmv3objectslineitemssearchdosearch) | **POST** /crm/v3/objects/line_items/search | 
[**PostCrmV3ObjectsObjectTypeSearchDoSearch**](SearchApi.md#postcrmv3objectsobjecttypesearchdosearch) | **POST** /crm/v3/objects/{objectType}/search | 
[**PostCrmV3ObjectsProductsSearchDoSearch**](SearchApi.md#postcrmv3objectsproductssearchdosearch) | **POST** /crm/v3/objects/products/search | 
[**PostCrmV3ObjectsQuotesSearchDoSearch**](SearchApi.md#postcrmv3objectsquotessearchdosearch) | **POST** /crm/v3/objects/quotes/search | 
[**PostCrmV3ObjectsTicketsSearchDoSearch**](SearchApi.md#postcrmv3objectsticketssearchdosearch) | **POST** /crm/v3/objects/tickets/search | 


<a name="getmarketingv3marketingeventseventssearch"></a>
# **GetMarketingV3MarketingEventsEventsSearch**
> CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging GetMarketingV3MarketingEventsEventsSearch (string q)

Search for marketing events

Search for marketing events that have an event id that starts with the query string

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetMarketingV3MarketingEventsEventsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var q = "q_example";  // string | The partial event id to search for

            try
            {
                // Search for marketing events
                CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging result = apiInstance.GetMarketingV3MarketingEventsEventsSearch(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetMarketingV3MarketingEventsEventsSearch: " + e.Message );
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
 **q** | **string**| The partial event id to search for | 

### Return type

[**CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging**](CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging.md)

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

<a name="postcrmv3objectscompaniessearchdosearch"></a>
# **PostCrmV3ObjectsCompaniesSearchDoSearch**
> CollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsCompaniesSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                CollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsCompaniesSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsCompaniesSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**CollectionResponseWithTotalSimplePublicObjectForwardPaging**](CollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectscontactssearchdosearch"></a>
# **PostCrmV3ObjectsContactsSearchDoSearch**
> ContactsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsContactsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsContactsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                ContactsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsContactsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsContactsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**ContactsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](ContactsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsdealssearchdosearch"></a>
# **PostCrmV3ObjectsDealsSearchDoSearch**
> DealsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsDealsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                DealsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsDealsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsDealsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**DealsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](DealsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsfeedbacksubmissionssearchdosearch"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch**
> FeedbackSubmissionsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                FeedbackSubmissionsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**FeedbackSubmissionsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](FeedbackSubmissionsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectslineitemssearchdosearch"></a>
# **PostCrmV3ObjectsLineItemsSearchDoSearch**
> LineItemsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsLineItemsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                LineItemsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsLineItemsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsLineItemsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**LineItemsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](LineItemsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsobjecttypesearchdosearch"></a>
# **PostCrmV3ObjectsObjectTypeSearchDoSearch**
> ObjectsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsObjectTypeSearchDoSearch (string objectType, PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var objectType = "objectType_example";  // string | 
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                ObjectsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsObjectTypeSearchDoSearch(objectType, publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsObjectTypeSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**ObjectsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](ObjectsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsproductssearchdosearch"></a>
# **PostCrmV3ObjectsProductsSearchDoSearch**
> CollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsProductsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsProductsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                CollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsProductsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsProductsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**CollectionResponseWithTotalSimplePublicObjectForwardPaging**](CollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsquotessearchdosearch"></a>
# **PostCrmV3ObjectsQuotesSearchDoSearch**
> QuotesCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsQuotesSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsQuotesSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                QuotesCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsQuotesSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsQuotesSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**QuotesCollectionResponseWithTotalSimplePublicObjectForwardPaging**](QuotesCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

<a name="postcrmv3objectsticketssearchdosearch"></a>
# **PostCrmV3ObjectsTicketsSearchDoSearch**
> TicketsCollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsTicketsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ObjectsTicketsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                TicketsCollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsTicketsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsTicketsSearchDoSearch: " + e.Message );
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
 **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md)|  | 

### Return type

[**TicketsCollectionResponseWithTotalSimplePublicObjectForwardPaging**](TicketsCollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

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

