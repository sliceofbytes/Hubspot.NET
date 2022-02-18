# HubSpot.NET.Model.ExtensionActionDefinitionPatch
Fields on custom workflow action to be updated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionUrl** | **string** | The URL that will accept an HTTPS request each time workflows executes the custom action. | [optional] 
**Published** | **bool** | Whether this custom action is published to customers. | [optional] 
**InputFields** | [**List&lt;InputFieldDefinition&gt;**](InputFieldDefinition.md) | The list of input fields to display in this custom action. | [optional] 
**ObjectRequestOptions** | [**ObjectRequestOptions**](ObjectRequestOptions.md) |  | [optional] 
**InputFieldDependencies** | [**List&lt;OneOfSingleFieldDependencyConditionalSingleFieldDependency&gt;**](OneOfSingleFieldDependencyConditionalSingleFieldDependency.md) | A list of dependencies between the input fields. These configure when the input fields should be visible. | [optional] 
**Labels** | [**Dictionary&lt;string, ActionLabels&gt;**](ActionLabels.md) | The user-facing labels for the custom action. | [optional] 
**ObjectTypes** | **List&lt;string&gt;** | The object types that this custom action supports. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

