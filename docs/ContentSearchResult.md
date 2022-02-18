# HubSpot.NET.Model.ContentSearchResult
An individual search result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the content. | 
**Score** | **decimal** | The matching score of the document. | 
**Type** | **string** | The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;. | 
**Domain** | **string** | The domain the document is hosted on. | 
**Url** | **string** | The url of the document. | 
**FeaturedImageUrl** | **string** | URL of the featured image. | [optional] 
**Language** | **string** | The document&#39;s language. | [optional] 
**Title** | **string** | The title of the returned document. | [optional] 
**Description** | **string** | The result&#39;s description. The content will be determined by the value of &#x60;length&#x60; in the request. | [optional] 
**Category** | **string** | For knowledge articles, the category of the article. | [optional] 
**Subcategory** | **string** | For knowledge articles, the subcategory of the article. | [optional] 
**AuthorFullName** | **string** | Name of the author. | [optional] 
**Tags** | **List&lt;string&gt;** | If a blog post, the tags associated with it. | [optional] 
**TableId** | **long** | If a dynamic page, the ID of the HubDB table. | [optional] 
**RowId** | **long** | If a dynamic page, the row ID in the HubDB table. | [optional] 
**PublishedDate** | **long** | The date the content was published. | [optional] 
**CombinedId** | **string** | The ID of the document in HubSpot. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

