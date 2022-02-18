# HubSpot.NET.Model.ObjectTypePropertyCreate
Defines a property to create.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The internal property name, which must be used when referencing the property from the API. | 
**Label** | **string** | A human-readable property label that will be shown in HubSpot. | 
**GroupName** | **string** | The name of the group this property belongs to. | [optional] 
**Description** | **string** | A description of the property that will be shown as help text in HubSpot. | [optional] 
**Options** | [**List&lt;OptionInput&gt;**](OptionInput.md) | A list of available options for the property. This field is only required for enumerated properties. | [optional] 
**DisplayOrder** | **int** | The order that this property should be displayed in the HubSpot UI relative to other properties for this object type. Properties are displayed in order starting with the lowest positive integer value. A value of -1 will cause the property to be displayed **after** any positive values. | [optional] 
**HasUniqueValue** | **bool** | Whether or not the property&#39;s value must be unique. Once set, this can&#39;t be changed. | [optional] 
**Hidden** | **bool** |  | [optional] 
**Type** | **string** | The data type of the property. | 
**FieldType** | **string** | Controls how the property appears in HubSpot. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

