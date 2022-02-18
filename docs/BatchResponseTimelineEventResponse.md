# HubSpot.NET.Model.BatchResponseTimelineEventResponse
The state of the batch event request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the batch response. Should always be COMPLETED if processed. | 
**Results** | [**List&lt;TimelineEventResponse&gt;**](TimelineEventResponse.md) | Successfully created events. | 
**RequestedAt** | **DateTimeOffset** | The time the request occurred. | [optional] 
**StartedAt** | **DateTimeOffset** | The time the request began processing. | 
**CompletedAt** | **DateTimeOffset** | The time the request was completed. | 
**Links** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

