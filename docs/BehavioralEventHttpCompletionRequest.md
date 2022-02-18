# HubSpot.NET.Model.BehavioralEventHttpCompletionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Utk** | **string** | User token | [optional] 
**Email** | **string** | Email of visitor | [optional] 
**EventName** | **string** | Internal name of the event-type to trigger | 
**Properties** | **Dictionary&lt;string, string&gt;** | Map of properties for the event in the format property internal name - property value | 
**OccurredAt** | **DateTimeOffset** | The time when this event occurred (if any). If this isn&#39;t set, the current time will be used | [optional] 
**ObjectId** | **string** | The object id that this event occurred on. Could be a contact id or a visitor id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

