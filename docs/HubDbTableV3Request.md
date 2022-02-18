# HubSpot.NET.Model.HubDbTableV3Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the table | 
**Label** | **string** | Label of the table | 
**UseForPages** | **bool** | Specifies whether the table can be used for creation of dynamic pages | [optional] 
**AllowPublicApiAccess** | **bool** | Specifies whether the table can be read by public without authorization | [optional] 
**AllowChildTables** | **bool** | Specifies whether child tables can be created | [optional] 
**EnableChildTablePages** | **bool** | Specifies creation of multi-level dynamic pages using child tables | [optional] 
**Columns** | [**List&lt;ColumnRequest&gt;**](ColumnRequest.md) | List of columns in the table | [optional] 
**DynamicMetaTags** | **Dictionary&lt;string, int&gt;** | Specifies the key value pairs of the metadata fields with the associated column ids | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

