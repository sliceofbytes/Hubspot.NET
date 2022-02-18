# HubSpot.NET.Model.Column

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the column | 
**Label** | **string** | Label of the column | 
**Id** | **string** | Column Id | [optional] 
**Width** | **int** | Column width for HubDB UI | [optional] 
**ForeignTableId** | **long** | Foreign table id referenced | [optional] 
**ForeignColumnId** | **int** | Foreign Column id | [optional] 
**ForeignIds** | [**List&lt;ForeignId&gt;**](ForeignId.md) | Foreign Ids | [optional] 
**ForeignIdsById** | [**Dictionary&lt;string, ForeignId&gt;**](ForeignId.md) | Foreign ids | [optional] 
**ForeignIdsByName** | [**Dictionary&lt;string, ForeignId&gt;**](ForeignId.md) | Foreign ids by name | [optional] 
**Type** | **string** | Type of the column | 
**OptionCount** | **int** | Number of options available | [optional] 
**Archived** | **bool** | Specifies whether the column is archived | [optional] 
**Options** | [**List&lt;Option&gt;**](Option.md) | Options to choose for select and multi-select columns | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

