# HubSpot.NET.Model.AccountingExtensionInvoice
Representation of an invoice in the external accounting system.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDue** | **decimal** | The total amount due. | 
**Balance** | **decimal** | The remaining outstanding balance due. | [optional] 
**DueDate** | **DateTimeOffset** | The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd) | 
**InvoiceNumber** | **string** | The invoice number | [optional] 
**CustomerId** | **string** | The ID of the customer that this invoice is for. | [optional] 
**Currency** | **string** | The ISO 4217 currency code that represents the currency of this invoice. | 
**InvoiceLink** | **string** | A link to the invoice in the external accounting system. | 
**CustomerName** | **string** | The name of the customer that this invoice is for. | 
**Status** | **string** | The currency status of the invoice. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

