# HubSpot.NET.Model.BlogPost
Model definition for a Blog Post.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the Blog Post. | 
**Slug** | **string** | The path of the this blog post. This field is appended to the domain to construct the url of this post. | 
**ContentGroupId** | **string** | The ID of the parent Blog this Blog Post is associated with. | 
**Campaign** | **string** | The GUID of the marketing campaign this Blog Post is a part of. | 
**CategoryId** | **int** | ID of the type of object this is. Should always . | 
**State** | **string** | An ENUM descibing the current state of this Blog Post. | 
**Name** | **string** | The internal name of the Blog Post. | 
**MabExperimentId** | **string** |  | 
**Archived** | **bool** |  | 
**AuthorName** | **string** | The name of the user that updated this Blog Post. | 
**AbTestId** | **string** |  | 
**CreatedById** | **string** | The ID of the user that created this Blog Post. | 
**UpdatedById** | **string** | The ID of the user that updated this Blog Post. | 
**Domain** | **string** | The domain this Blog Post will resolve to. If null, the Blog Post will default to the domain of the ParentBlog. | 
**AbStatus** | **string** |  | 
**FolderId** | **string** |  | 
**WidgetContainers** | **Dictionary&lt;string, Object&gt;** | A data structure containing the data for all the modules inside the containers for this post. This will only be populated if the page has widget containers. | 
**Widgets** | **Dictionary&lt;string, Object&gt;** | A data structure containing the data for all the modules for this page. | 
**Language** | **string** | The explicitly defined ISO 639 language code of the Blog Post. If null, the Blog Post will default to the language of the ParentBlog. | 
**TranslatedFromId** | **string** | ID of the primary blog post this object was translated from. | 
**Translations** | [**Dictionary&lt;string, ContentLanguageVariation&gt;**](ContentLanguageVariation.md) |  | 
**DynamicPageHubDbTableId** | **string** | The ID of the HubDB table this Blog Post references, if applicable | 
**BlogAuthorId** | **string** | The ID of the Blog Author associated with this Blog Post. | 
**TagIds** | **List&lt;long&gt;** | List of IDs for the tags associated with this Blog Post. | 
**HtmlTitle** | **string** | The html title of this Blog Post. | 
**UseFeaturedImage** | **bool** | Boolean to determine if this post should use a featuredImage. | 
**PostBody** | **string** | The HTML of the main post body. | 
**PostSummary** | **string** | The summary of the blog post that will appear on the main listing page. | 
**RssBody** | **string** | The contents of the RSS body for this Blog Post. | 
**RssSummary** | **string** | The contents of the RSS summary for this Blog Post. | 
**EnableGoogleAmpOutputOverride** | **bool** | Boolean to allow overriding the AMP settings for the blog. | 
**Url** | **string** | A generated field representing the URL of this blog post. | 
**Password** | **string** | Set this to create a password protected page. Entering the password will be required to view the page. | 
**CurrentState** | **string** | A generated ENUM descibing the current state of this Blog Post. Should always match state. | 
**LinkRelCanonicalUrl** | **string** | Optional override to set the URL to be used in the rel&#x3D;canonical link tag on the page. | 
**PageExpiryEnabled** | **bool** |  | 
**PageExpiryRedirectId** | **long** |  | 
**PageExpiryRedirectUrl** | **string** |  | 
**PageExpiryDate** | **long** |  | 
**IncludeDefaultCustomCss** | **bool** | Boolean to determine whether or not the Primary CSS Files should be applied. | 
**EnableLayoutStylesheets** | **bool** | Boolean to determine whether or not the styles from the template should be applied. | 
**EnableDomainStylesheets** | **bool** | Boolean to determine whether or not the styles from the template should be applied. | 
**ContentTypeCategory** | **string** | An ENUM descibing the type of this object. Should always be BLOG_POST. | 
**PublishImmediately** | **bool** | Set this to true if you want to be published immediately when the schedule publish endpoint is called, and to ignore the publish_date setting. | 
**FeaturedImage** | **string** | The featuredImage of this Blog Post. | 
**FeaturedImageAltText** | **string** | Alt Text of the featuredImage. | 
**AttachedStylesheets** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | List of stylesheets to attach to this blog post. These stylesheets are attached to just this page. Order of precedence is bottom to top, just like in the HTML. | 
**MetaDescription** | **string** | A description that goes in &lt;meta&gt; tag on the page. | 
**HeadHtml** | **string** | Custom HTML for embed codes, javascript, etc. that goes in the &lt;head&gt; tag of the page. | 
**FooterHtml** | **string** | Custom HTML for embed codes, javascript that should be placed before the &lt;/body&gt; tag of the page. | 
**ArchivedInDashboard** | **bool** | If True, the post will not show up in your dashboard, although the post could still be live. | 
**PublicAccessRulesEnabled** | **bool** | Boolean to determine whether or not to respect publicAccessRules. | 
**PublicAccessRules** | **List&lt;Object&gt;** | Rules for require member registration to access private content. | 
**LayoutSections** | [**Dictionary&lt;string, LayoutSection&gt;**](LayoutSection.md) |  | 
**ThemeSettingsValues** | **Dictionary&lt;string, Object&gt;** |  | 
**PublishDate** | **DateTimeOffset** | The date (ISO8601 format) the blog post is to be published at. | 
**DeletedAt** | **DateTimeOffset** | The timestamp (ISO8601 format) when this Blog Post was deleted. | 
**CreatedAt** | **DateTimeOffset** | The timestamp (ISO8601 format) when this blog post was created. | 
**Published** | **bool** | Boolean describing if this Blog Post is published. | 
**UpdatedAt** | **DateTimeOffset** | The timestamp (ISO8601 format) when this Blog Post was last updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

