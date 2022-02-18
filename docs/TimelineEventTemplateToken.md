# HubSpot.NET.Model.TimelineEventTemplateToken
State of the token definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Used for list segmentation and reporting. | 
**ObjectPropertyName** | **string** | The name of the CRM object property. This will populate the CRM object property associated with the event. With enough of these, you can fully build CRM objects via the Timeline API. | [optional] 
**Options** | [**List&lt;TimelineEventTemplateTokenOption&gt;**](TimelineEventTemplateTokenOption.md) | If type is &#x60;enumeration&#x60;, we should have a list of options to choose from. | 
**Name** | **string** | The name of the token referenced in the templates. This must be unique for the specific template. It may only contain alphanumeric characters, periods, dashes, or underscores (. - _). | 
**Type** | **string** | The data type of the token. You can currently choose from [string, number, date, enumeration]. | 
**CreatedAt** | **DateTimeOffset** | The date and time that the Event Template Token was created, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020. | [optional] 
**UpdatedAt** | **DateTimeOffset** | The date and time that the Event Template Token was last updated, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

