# HubSpot.NET.Model.InvoiceReadResponse
The invoice data stored in HubSpot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalInvoiceNumber** | **string** | The invoice number. Note that this is _not_ the ID of the invoice, but the number that the billed customer will see. | [optional] 
**TotalAmountBilled** | **decimal** | The total amount that this invoice is for. | 
**BalanceDue** | **decimal** | The remaining balance due for the invoice. | 
**CurrencyCode** | **string** | The ISO 4217 currency code that represents the currency of the invoice. | 
**DueDate** | **DateTimeOffset** | The due date of the invoice | 
**ExternalRecipientId** | **string** | The id of the customer in the external accounting system that the invoice was sent to. | 
**ReceivedByRecipientDate** | **long** | The datetime that that invoice was sent to the customer. | [optional] 
**ExternalCreateDateTime** | **long** | The datetime that the invoice was created in the external accounting system. | [optional] 
**IsVoided** | **bool** | Indicated is the invoice has been voided or not. | 
**CreatedAt** | **DateTimeOffset** | The datetime that the invoice was created in HubSpot. | 
**UpdatedAt** | **DateTimeOffset** | The datetime that the invoice was last updated in HubSpot. | 
**ArchivedAt** | **DateTimeOffset** |  | [optional] 
**Archived** | **bool** |  | 
**ExternalAccountId** | **string** | The id of the account in the external accounting system that this invoice is related to. | 
**InvoiceStatus** | **string** | The status of the invoice | 
**Id** | **string** | The id of this invoice in the external accounting system. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

