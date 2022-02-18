# HubSpot.NET.Model.TimelineEventTemplate
The current state of the template definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The template name. | 
**HeaderTemplate** | **string** | This uses Markdown syntax with Handlebars and event-specific data to render HTML on a timeline as a header. | [optional] 
**DetailTemplate** | **string** | This uses Markdown syntax with Handlebars and event-specific data to render HTML on a timeline when you expand the details. | [optional] 
**Tokens** | [**List&lt;TimelineEventTemplateToken&gt;**](TimelineEventTemplateToken.md) | A collection of tokens that can be used as custom properties on the event and to create fully fledged CRM objects. | 
**Id** | **string** | The template ID. | 
**ObjectType** | **string** | The type of CRM object this template is for. [Contacts, companies, tickets, and deals] are supported. | 
**CreatedAt** | **DateTimeOffset** | The date and time that the Event Template was created, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020. | [optional] 
**UpdatedAt** | **DateTimeOffset** | The date and time that the Event Template was last updated, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

