# HubSpot.NET.Model.UpdatedProduct
A request to import external accounting product properties in HubSpot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SyncAction** | **string** | The operation to be performed. | 
**UpdatedAt** | **DateTimeOffset** | The timestamp (ISO8601 format) when the product was updated in the external accounting system. | 
**Price** | **decimal** | The price of the product. | 
**CurrencyCode** | **string** | The ISO 4217 currency code that represents the currency of the product price. | [optional] 
**Id** | **string** | The ID of the product in the external accounting system. | 
**Properties** | **Dictionary&lt;string, string&gt;** | A map of key-value product properties to be imported. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

