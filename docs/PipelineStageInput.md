# HubSpot.NET.Model.PipelineStageInput
An input used to create or replace a pipeline stage's definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | A label used to organize pipeline stages in HubSpot&#39;s UI. Each pipeline stage&#39;s label must be unique within that pipeline. | 
**DisplayOrder** | **int** | The order for displaying this pipeline stage. If two pipeline stages have a matching &#x60;displayOrder&#x60;, they will be sorted alphabetically by label. | 
**Metadata** | **Dictionary&lt;string, string&gt;** | A JSON object containing properties that are not present on all object pipelines.  For &#x60;deals&#x60; pipelines, the &#x60;probability&#x60; field is required (&#x60;{ \&quot;probability\&quot;: 0.5 }&#x60;), and represents the likelihood a deal will close. Possible values are between 0.0 and 1.0 in increments of 0.1.  For &#x60;tickets&#x60; pipelines, the &#x60;ticketState&#x60; field is optional (&#x60;{ \&quot;ticketState\&quot;: \&quot;OPEN\&quot; }&#x60;), and represents whether the ticket remains open or has been closed by a member of your Support team. Possible values are &#x60;OPEN&#x60; or &#x60;CLOSED&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

