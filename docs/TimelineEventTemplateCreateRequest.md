# HubSpot.NET.Model.TimelineEventTemplateCreateRequest
State of the template definition being created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The template name. | 
**HeaderTemplate** | **string** | This uses Markdown syntax with Handlebars and event-specific data to render HTML on a timeline as a header. | [optional] 
**DetailTemplate** | **string** | This uses Markdown syntax with Handlebars and event-specific data to render HTML on a timeline when you expand the details. | [optional] 
**Tokens** | [**List&lt;TimelineEventTemplateToken&gt;**](TimelineEventTemplateToken.md) | A collection of tokens that can be used as custom properties on the event and to create fully fledged CRM objects. | 
**ObjectType** | **string** | The type of CRM object this template is for. [Contacts, companies, tickets, and deals] are supported. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

