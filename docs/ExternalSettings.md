# HubSpot.NET.Model.ExternalSettings
The URLs of the various actions provided by the video conferencing application. All URLs must use the `https` protocol.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateMeetingUrl** | **string** | The URL that HubSpot will send requests to create a new video conference. | 
**UpdateMeetingUrl** | **string** | The URL that HubSpot will send updates to existing meetings. Typically called when the user changes the topic or times of a meeting. | [optional] 
**DeleteMeetingUrl** | **string** | The URL that HubSpot will send notifications of meetings that have been deleted in HubSpot. | [optional] 
**UserVerifyUrl** | **string** | The URL that HubSpot will use to verify that a user exists in the video conference application. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

