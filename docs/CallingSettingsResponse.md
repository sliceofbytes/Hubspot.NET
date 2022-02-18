# HubSpot.NET.Model.CallingSettingsResponse
Current settings state

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of your calling service to display to users. | 
**Url** | **string** | The URL to your phone/calling UI, built with the [Calling SDK](#). | 
**Height** | **int** | The target height of the iframe that will contain your phone/calling UI. | 
**Width** | **int** | The target width of the iframe that will contain your phone/calling UI. | 
**IsReady** | **bool** | When true, your service will appear as an option under the *Call* action in contact records of connected accounts. | 
**SupportsCustomObjects** | **bool** | When true, you are indicating that your service is compatible with engagement v2 service and can be used with custom objects. | 
**CreatedAt** | **DateTimeOffset** | When this calling extension was created. | 
**UpdatedAt** | **DateTimeOffset** | The last time the settings for this calling extension were modified. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

