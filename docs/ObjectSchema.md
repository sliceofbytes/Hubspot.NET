# HubSpot.NET.Model.ObjectSchema
Defines an object schema, including its properties and associations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Labels** | [**ObjectTypeDefinitionLabels**](ObjectTypeDefinitionLabels.md) |  | 
**RequiredProperties** | **List&lt;string&gt;** | The names of properties that should be **required** when creating an object of this type. | 
**SearchableProperties** | **List&lt;string&gt;** | Names of properties that will be indexed for this object type in by HubSpot&#39;s product search. | 
**PrimaryDisplayProperty** | **string** | The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type. | [optional] 
**SecondaryDisplayProperties** | **List&lt;string&gt;** | The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type. | 
**Archived** | **bool** |  | 
**Id** | **string** | A unique ID for this schema&#39;s object type. Will be defined as {meta-type}-{unique ID}. | 
**FullyQualifiedName** | **string** | An assigned unique ID for the object, including portal ID and object name. | 
**CreatedAt** | **DateTimeOffset** | When the object schema was created. | [optional] 
**UpdatedAt** | **DateTimeOffset** | When the object schema was last updated. | [optional] 
**ObjectTypeId** | **string** |  | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Properties defined for this object type. | 
**Associations** | [**List&lt;AssociationDefinition&gt;**](AssociationDefinition.md) | Associations defined for a given object type. | 
**Name** | **string** | A unique name for the schema&#39;s object type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

