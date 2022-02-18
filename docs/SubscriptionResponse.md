# HubSpot.NET.Model.SubscriptionResponse
Complete details for an event subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | Type of event to listen for. Can be one of &#x60;create&#x60;, &#x60;delete&#x60;, &#x60;deletedForPrivacy&#x60;, or &#x60;propertyChange&#x60;. | 
**PropertyName** | **string** | The internal name of the property being monitored for changes. Only applies when &#x60;eventType&#x60; is &#x60;propertyChange&#x60;. | [optional] 
**Active** | **bool** | Determines if the subscription is active or paused. | 
**Id** | **string** | The unique ID of the subscription. | 
**CreatedAt** | **DateTimeOffset** | When this subscription was created. Formatted as milliseconds from the [Unix epoch](#). | 
**UpdatedAt** | **DateTimeOffset** | When this subscription was last updated. Formatted as milliseconds from the [Unix epoch](#). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

