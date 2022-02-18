# HubSpot.NET.Api.InvoiceApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById**](InvoiceApi.md#getcrmv3extensionsaccountinginvoiceinvoiceidgetbyid) | **GET** /crm/v3/extensions/accounting/invoice/{invoiceId} | Get invoice data
[**PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate**](InvoiceApi.md#patchcrmv3extensionsaccountinginvoiceinvoiceidupdate) | **PATCH** /crm/v3/extensions/accounting/invoice/{invoiceId} | Update an invoice
[**PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment**](InvoiceApi.md#postcrmv3extensionsaccountinginvoiceinvoiceidpaymentcreatepayment) | **POST** /crm/v3/extensions/accounting/invoice/{invoiceId}/payment | Records an invoice payment


<a name="getcrmv3extensionsaccountinginvoiceinvoiceidgetbyid"></a>
# **GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById**
> InvoiceReadResponse GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById (string invoiceId, string accountId)

Get invoice data

Returns invoice data for an Accounting account from the specified ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new InvoiceApi(config);
            var invoiceId = "invoiceId_example";  // string | The ID of the invoice. This is the invoice ID from the external accounting system.
            var accountId = "accountId_example";  // string | The ID of the account that the invoice belongs to. This is the account ID from the external accounting system.

            try
            {
                // Get invoice data
                InvoiceReadResponse result = apiInstance.GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById(invoiceId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById: " + e.Message );
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
 **invoiceId** | **string**| The ID of the invoice. This is the invoice ID from the external accounting system. | 
 **accountId** | **string**| The ID of the account that the invoice belongs to. This is the account ID from the external accounting system. | 

### Return type

[**InvoiceReadResponse**](InvoiceReadResponse.md)

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

<a name="patchcrmv3extensionsaccountinginvoiceinvoiceidupdate"></a>
# **PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate**
> InvoiceUpdateResponse PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate (string invoiceId, string accountId, InvoiceUpdateRequest invoiceUpdateRequest)

Update an invoice

Updates an Invoice by the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new InvoiceApi(config);
            var invoiceId = "invoiceId_example";  // string | The ID of the invoice. This is the invoice ID from the external accounting system.
            var accountId = "accountId_example";  // string | The ID of the account that the invoice belongs to. This is the account ID from the external accounting system.
            var invoiceUpdateRequest = new InvoiceUpdateRequest(); // InvoiceUpdateRequest | The invoice data to update

            try
            {
                // Update an invoice
                InvoiceUpdateResponse result = apiInstance.PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate(invoiceId, accountId, invoiceUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate: " + e.Message );
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
 **invoiceId** | **string**| The ID of the invoice. This is the invoice ID from the external accounting system. | 
 **accountId** | **string**| The ID of the account that the invoice belongs to. This is the account ID from the external accounting system. | 
 **invoiceUpdateRequest** | [**InvoiceUpdateRequest**](InvoiceUpdateRequest.md)| The invoice data to update | 

### Return type

[**InvoiceUpdateResponse**](InvoiceUpdateResponse.md)

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

<a name="postcrmv3extensionsaccountinginvoiceinvoiceidpaymentcreatepayment"></a>
# **PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment**
> InvoiceUpdateResponse PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment (string invoiceId, InvoiceCreatePaymentRequest invoiceCreatePaymentRequest, string accountId = null)

Records an invoice payment

Records an payment against an invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new InvoiceApi(config);
            var invoiceId = "invoiceId_example";  // string | The ID of the invoice. This is the invoice ID from the external accounting system.
            var invoiceCreatePaymentRequest = new InvoiceCreatePaymentRequest(); // InvoiceCreatePaymentRequest | The payment information
            var accountId = "accountId_example";  // string | The ID of the account that the invoice belongs to. This is the account ID from the external accounting system. (optional) 

            try
            {
                // Records an invoice payment
                InvoiceUpdateResponse result = apiInstance.PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment(invoiceId, invoiceCreatePaymentRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment: " + e.Message );
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
 **invoiceId** | **string**| The ID of the invoice. This is the invoice ID from the external accounting system. | 
 **invoiceCreatePaymentRequest** | [**InvoiceCreatePaymentRequest**](InvoiceCreatePaymentRequest.md)| The payment information | 
 **accountId** | **string**| The ID of the account that the invoice belongs to. This is the account ID from the external accounting system. | [optional] 

### Return type

[**InvoiceUpdateResponse**](InvoiceUpdateResponse.md)

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

