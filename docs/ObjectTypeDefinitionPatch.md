# HubSpot.NET.Model.ObjectTypeDefinitionPatch
Defines attributes to update on an object type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Labels** | [**ObjectTypeDefinitionLabels**](ObjectTypeDefinitionLabels.md) |  | [optional] 
**RequiredProperties** | **List&lt;string&gt;** | The names of properties that should be **required** when creating an object of this type. | [optional] 
**SearchableProperties** | **List&lt;string&gt;** | Names of properties that will be indexed for this object type in by HubSpot&#39;s product search. | [optional] 
**PrimaryDisplayProperty** | **string** | The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type. | [optional] 
**SecondaryDisplayProperties** | **List&lt;string&gt;** | The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type. | [optional] 
**Restorable** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

