# HubSpot.NET.Model.PipelineInput
An input used to create or replace a pipeline's definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | A unique label used to organize pipelines in HubSpot&#39;s UI | 
**DisplayOrder** | **int** | The order for displaying this pipeline. If two pipelines have a matching &#x60;displayOrder&#x60;, they will be sorted alphabetically by label. | 
**Stages** | [**List&lt;PipelineStageInput&gt;**](PipelineStageInput.md) | Pipeline stage inputs used to create the new or replacement pipeline. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

