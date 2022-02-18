# HubSpot.NET.Model.ExtensionActionDefinitionInput
State of custom workflow action to be created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Functions** | [**List&lt;ActionFunction&gt;**](ActionFunction.md) | A list of functions associated with the custom workflow action. | 
**ActionUrl** | **string** | The URL that will accept an HTTPS request each time workflows executes the custom action. | 
**Published** | **bool** | Whether this custom action is published to customers. | 
**ArchivedAt** | **long** | The date that this custom action was archived, if the custom action is archived. | [optional] 
**InputFields** | [**List&lt;InputFieldDefinition&gt;**](InputFieldDefinition.md) | The list of input fields to display in this custom action. | 
**ObjectRequestOptions** | [**ObjectRequestOptions**](ObjectRequestOptions.md) |  | [optional] 
**InputFieldDependencies** | [**List&lt;OneOfSingleFieldDependencyConditionalSingleFieldDependency&gt;**](OneOfSingleFieldDependencyConditionalSingleFieldDependency.md) | A list of dependencies between the input fields. These configure when the input fields should be visible. | [optional] 
**Labels** | [**Dictionary&lt;string, ActionLabels&gt;**](ActionLabels.md) | The user-facing labels for the custom action. | 
**ObjectTypes** | **List&lt;string&gt;** | The object types that this custom action supports. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

