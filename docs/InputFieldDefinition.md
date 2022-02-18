# HubSpot.NET.Model.InputFieldDefinition
Configuration for an input field on the custom action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeDefinition** | [**FieldTypeDefinition**](FieldTypeDefinition.md) |  | 
**SupportedValueTypes** | **List&lt;string&gt;** | Controls what kind of input a customer can use to specify the field value. Must contain exactly one of &#x60;STATIC_VALUE&#x60; or &#x60;OBJECT_PROPERTY&#x60;. If &#x60;STATIC_VALUE&#x60;, the customer will be able to choose a value when configuring the custom action; if &#x60;OBJECT_PROPERTY&#x60;, the customer will be able to choose a property from the enrolled workflow object that the field value will be copied from. In the future we may support more than one input control type here. | [optional] 
**IsRequired** | **bool** | Whether the field is required for the custom action to be valid | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

