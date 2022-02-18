# HubSpot.NET.Model.AccountingFeatures
Outlines the features that are supported by the external accounting system.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateInvoice** | [**CreateInvoiceFeature**](CreateInvoiceFeature.md) |  | 
**ImportInvoice** | [**ImportInvoiceFeature**](ImportInvoiceFeature.md) |  | 
**Sync** | [**Dictionary&lt;string, ObjectSyncFeature&gt;**](ObjectSyncFeature.md) | Indicates if syncing objects from the external account system into HubSpot is supported for the integration. This is a map, where the key is one of &#x60;CONTACT&#x60; or &#x60;PRODUCT&#x60;, to indicate which type of object you do or don&#39;t support syncing. For example: &#x60;&#x60;&#x60;   \&quot;sync\&quot;: {     \&quot;CONTACT\&quot;: {       \&quot;toHubSpot\&quot;: true     },     \&quot;PRODUCT\&quot;: {       \&quot;toHubSpot\&quot;: true     }   } &#x60;&#x60;&#x60;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

