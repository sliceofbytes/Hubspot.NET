# HubSpot.NET.Model.PropertyUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | A human-readable property label that will be shown in HubSpot. | [optional] 
**Type** | **string** | The data type of the property. | [optional] 
**FieldType** | **string** | Controls how the property appears in HubSpot. | [optional] 
**GroupName** | **string** | The name of the property group the property belongs to. | [optional] 
**Description** | **string** | A description of the property that will be shown as help text in HubSpot. | [optional] 
**Options** | [**List&lt;PropertiesOptionInput&gt;**](PropertiesOptionInput.md) | A list of valid options for the property. | [optional] 
**DisplayOrder** | **int** | Properties are displayed in order starting with the lowest positive integer value. Values of -1 will cause the Property to be displayed after any positive values. | [optional] 
**Hidden** | **bool** | If true, the property won&#39;t be visible and can&#39;t be used in HubSpot. | [optional] 
**FormField** | **bool** | Whether or not the property can be used in a HubSpot form. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

