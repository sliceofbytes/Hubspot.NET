# HubSpot.NET.Model.EmailSendStatusView
Describes the status of an email send request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | [**EventIdView**](EventIdView.md) |  | [optional] 
**StatusId** | **string** | Identifier used to query the status of the send. | 
**SendResult** | **string** | Result of the send. | [optional] 
**RequestedAt** | **DateTimeOffset** | Time when the send was requested. | [optional] 
**StartedAt** | **DateTimeOffset** | Time when the send began processing. | [optional] 
**CompletedAt** | **DateTimeOffset** | Time when the send was completed. | [optional] 
**Status** | **string** | Status of the send request. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

