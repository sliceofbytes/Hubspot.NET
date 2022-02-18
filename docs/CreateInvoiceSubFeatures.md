# HubSpot.NET.Model.CreateInvoiceSubFeatures
Lists the individual aspects of creating invoices that are enabled for the integration, as part of the create invoice flow in HubSpot.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateCustomer** | **bool** | Indicates if a new customer can be created in the external accounting system. | 
**Taxes** | **bool** | Indicates if taxes can be specified by the HubSpot user for line items. | 
**ExchangeRates** | **bool** | Indicates if the external accounting system supports fetching exchange rates when create an invoice in HubSpot for a customer billed in a different currency. | 
**Terms** | **bool** | Indicates if the external accounting system supports fetching payment terms. | 
**InvoiceComments** | **bool** | Indicates if a visible comment can be added to invoices. | 
**InvoiceDiscounts** | **bool** | Indicates if invoice-level discounts can be added to invoices. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

