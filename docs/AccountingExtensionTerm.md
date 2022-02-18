# HubSpot.NET.Model.AccountingExtensionTerm
Representation of payment terms that are defined in the external accounting system. One of 'dueDays' or 'dueDate' is required.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DueDate** | **DateTimeOffset** | The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd) | [optional] 
**Name** | **string** | The display name of the payment terms. | 
**Id** | **string** | The ID of the payment terms in the external accounting system. | 
**DueDays** | **int** | The number of days that these payment terms represent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

