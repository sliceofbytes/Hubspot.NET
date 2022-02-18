# HubSpot.NET.Model.BatchResponseBlogPostWithErrors
Response object for batch operations on blog posts with errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of batch operation. | 
**Results** | [**List&lt;BlogPost&gt;**](BlogPost.md) | Results of batch operation. | 
**NumErrors** | **int** | Number of errors. | [optional] 
**Errors** | [**List&lt;BlogPostsStandardError&gt;**](BlogPostsStandardError.md) | Errors in batch operation. | [optional] 
**RequestedAt** | **DateTimeOffset** | Time of batch operation request. | [optional] 
**StartedAt** | **DateTimeOffset** | Time of batch operation start. | 
**CompletedAt** | **DateTimeOffset** | Time of batch operation completion. | 
**Links** | **Dictionary&lt;string, string&gt;** | Links associated with batch operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

