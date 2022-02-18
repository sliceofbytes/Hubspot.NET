# HubSpot.NET.Model.SubscriptionCreateRequest
New webhook settings for an app.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | Type of event to listen for. Can be one of &#x60;create&#x60;, &#x60;delete&#x60;, &#x60;deletedForPrivacy&#x60;, or &#x60;propertyChange&#x60;. | 
**PropertyName** | **string** | The internal name of the property to monitor for changes. Only applies when &#x60;eventType&#x60; is &#x60;propertyChange&#x60;. | [optional] 
**Active** | **bool** | Determines if the subscription is active or paused. Defaults to false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

