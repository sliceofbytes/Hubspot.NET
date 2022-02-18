# HubSpot.NET.Model.InvoiceUpdateRequest
The invoice data to update in HubSpot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalInvoiceNumber** | **string** |  | [optional] 
**CurrencyCode** | **string** | The ISO 4217 currency code that represents the currency used in the invoice to bill the recipient | [optional] 
**DueDate** | **DateTimeOffset** | The ISO-8601 due date of the invoice. | [optional] 
**ExternalRecipientId** | **string** | The ID of the invoice recipient. This is the recipient ID from the external accounting system. | [optional] 
**ReceivedByRecipientDate** | **long** |  | [optional] 
**IsVoided** | **bool** | States if the invoice is voided or not. | [optional] 
**ReceivedByCustomerDate** | **string** | The ISO-8601 datetime of when the customer received the invoice. | [optional] 
**InvoiceNumber** | **string** | The number / name of the invoice. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

