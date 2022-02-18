# HubSpot.NET.Model.FieldTypeDefinition
The data type expected by an input field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The input field name. | 
**Type** | **string** | The data type of the field. | 
**FieldType** | **string** | Controls how the field appears in HubSpot. | [optional] 
**Options** | [**List&lt;ActionsOption&gt;**](ActionsOption.md) | A list of valid options for the field value. | 
**OptionsUrl** | **string** | A URL that will accept HTTPS requests when the valid options for the field are fetched. | [optional] 
**ReferencedObjectType** | **string** | This can be set to &#x60;OWNER&#x60; if the field should contain a HubSpot owner value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

