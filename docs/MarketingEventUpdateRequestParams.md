# HubSpot.NET.Model.MarketingEventUpdateRequestParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The name of the marketing event. | [optional] 
**EventType** | **string** | Describes what type of event this is.  For example: &#x60;WEBINAR&#x60;, &#x60;CONFERENCE&#x60;, &#x60;WORKSHOP&#x60; | [optional] 
**StartDateTime** | **DateTimeOffset** | The start date and time of the marketing event. | [optional] 
**EndDateTime** | **DateTimeOffset** | The end date and time of the marketing event. | [optional] 
**EventOrganizer** | **string** | The name of the organizer of the marketing event. | [optional] 
**EventDescription** | **string** | The description of the marketing event. | [optional] 
**EventUrl** | **string** | A URL in the external event application where the marketing event can be managed. | [optional] 
**EventCancelled** | **bool** | Indicates if the marketing event has been cancelled. Defaults to &#x60;false&#x60; | [optional] 
**CustomProperties** | [**List&lt;PropertyValue&gt;**](PropertyValue.md) | A list of PropertyValues. These can be whatever kind of property names and values you want. However, they must already exist on the HubSpot account&#39;s definition of the MarketingEvent Object. If they don&#39;t they will be filtered out and not set. In order to do this you&#39;ll need to create a new PropertyGroup on the HubSpot account&#39;s MarketingEvent object for your specific app and create the Custom Property you want to track on that HubSpot account. Do not create any new default properties on the MarketingEvent object as that will apply to all HubSpot accounts.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

