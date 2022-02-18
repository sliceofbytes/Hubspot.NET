# HubSpot.NET.Model.AssetFileMetadata
The object metadata of a file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The path of the file in the CMS Developer File System. | 
**Name** | **string** | The name of the file. | 
**Folder** | **bool** | Determines whether or not this path points to a folder. | 
**Children** | **List&lt;string&gt;** | If the object is a folder, contains the filenames of the files within the folder. | [optional] 
**UpdatedAt** | **int** | Timestamp of when the object was last updated. | 
**CreatedAt** | **int** | Timestamp of when the object was first created. | 
**ArchivedAt** | **long** | Timestamp of when the object was archived (deleted). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

