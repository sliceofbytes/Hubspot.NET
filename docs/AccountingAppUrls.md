# HubSpot.NET.Model.AccountingAppUrls
The URL endpoints that HubSpot will send requests to an external accounting system for certain actions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GetInvoiceUrl** | **string** | A URL that specifies the endpoint where invoices can be retrieved. | 
**SearchCustomerUrl** | **string** | A URL that specifies the endpoint where a customer search can be performed. | 
**GetInvoicePdfUrl** | **string** | A URL that specifies the endpoint where an invoice PDF can be retrieved. | 
**CustomerUrlTemplate** | **string** | A template URL that indicates the endpoint where a customer can be fetched by ID. Note that ${CUSTOMER_ID} in this URL will be replaced by the actual customer ID. For example: https://myapp.com/api/customers/${CUSTOMER_ID} | 
**ProductUrlTemplate** | **string** | A template URL that indicates the endpoint where a product can be fetched by ID. Note that ${PRODUCT_ID} in this URL will be replaced by the actual product ID. For example: https://myapp.com/api/products/${PRODUCT_ID} | 
**InvoiceUrlTemplate** | **string** | A template URL that indicates the endpoint where an invoice can be fetched by ID. Note that ${INVOICE_ID} in this URL will be replaced by the actual invoice ID. For example: https://myapp.com/api/invoices/${INVOICE_ID} | 
**CreateInvoiceUrl** | **string** | A URL that specifies the endpoint where an invoices can be created. | [optional] 
**SearchInvoiceUrl** | **string** | A URL that specifies the endpoint where an invoice search can be performed. | [optional] 
**SearchProductUrl** | **string** | A URL that specifies the endpoint where a product search can be performed. | [optional] 
**GetTermsUrl** | **string** | A URL that specifies the endpoint where payment terms can be retrieved. | [optional] 
**CreateCustomerUrl** | **string** | A URL that specifies the endpoint where a new customer can be created. | [optional] 
**SearchTaxUrl** | **string** | A URL that specifies the endpoint where a tax search can be performed. | [optional] 
**ExchangeRateUrl** | **string** | A URL that specifies the endpoint where exchange rates can be queried. | [optional] 
**SearchUrl** | **string** |  | [optional] 
**SearchCountUrl** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

