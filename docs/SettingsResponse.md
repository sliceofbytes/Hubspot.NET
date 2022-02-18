# HubSpot.NET.Model.SettingsResponse
Webhook settings for an app.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetUrl** | **string** | A publicly available URL for Hubspot to call where event payloads will be delivered. See [link-so-some-doc](#) for details about the format of these event payloads. | 
**Throttling** | [**ThrottlingSettings**](ThrottlingSettings.md) |  | 
**CreatedAt** | **DateTimeOffset** | When this subscription was created. Formatted as milliseconds from the [Unix epoch](#). | 
**UpdatedAt** | **DateTimeOffset** | When this subscription was last updated. Formatted as milliseconds from the [Unix epoch](#). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

