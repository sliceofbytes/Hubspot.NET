# HubSpot.NET.Model.HubDbTableV3
Model for HubDB table

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the table | [optional] 
**Name** | **string** | Name of the table | 
**Label** | **string** | Label of the table | 
**Columns** | [**List&lt;Column&gt;**](Column.md) | List of columns in the table | [optional] 
**Published** | **bool** |  | [optional] 
**ColumnCount** | **int** | Number of columns including deleted | [optional] 
**RowCount** | **int** | Number of rows in the table | [optional] 
**CreatedBy** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**UpdatedBy** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**PublishedAt** | **DateTimeOffset** | Timestamp at which the table is published recently | [optional] 
**DynamicMetaTags** | **Dictionary&lt;string, int&gt;** | Specifies the key value pairs of the metadata fields with the associated column ids | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp at which the table is created | [optional] 
**Archived** | **bool** | Specifies whether table is archived or not | [optional] 
**AllowPublicApiAccess** | **bool** | Specifies whether the table can be read by public without authorization | [optional] 
**UseForPages** | **bool** | Specifies whether the table can be used for creation of dynamic pages | [optional] 
**EnableChildTablePages** | **bool** | Specifies creation of multi-level dynamic pages using child tables | [optional] 
**AllowChildTables** | **bool** | Specifies whether child tables can be created | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp at which the table is updated recently | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

