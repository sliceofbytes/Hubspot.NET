# HubSpot.NET.Model.ObjectSchemaEgg
Defines a new object type, its properties, and associations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Labels** | [**ObjectTypeDefinitionLabels**](ObjectTypeDefinitionLabels.md) |  | 
**RequiredProperties** | **List&lt;string&gt;** | The names of properties that should be **required** when creating an object of this type. | 
**SearchableProperties** | **List&lt;string&gt;** | Names of properties that will be indexed for this object type in by HubSpot&#39;s product search. | 
**PrimaryDisplayProperty** | **string** | The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type. | [optional] 
**SecondaryDisplayProperties** | **List&lt;string&gt;** | The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type. | 
**Properties** | [**List&lt;ObjectTypePropertyCreate&gt;**](ObjectTypePropertyCreate.md) | Properties defined for this object type. | 
**AssociatedObjects** | **List&lt;string&gt;** | Associations defined for this object type. | 
**Name** | **string** | A unique name for this object. For internal use only. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

