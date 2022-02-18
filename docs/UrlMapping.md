# HubSpot.NET.Model.UrlMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique ID of this URL redirect. | 
**PortalId** | **int** |  | 
**Created** | **long** |  | 
**Updated** | **long** |  | 
**CreatedById** | **int** |  | 
**UpdatedById** | **int** |  | 
**RoutePrefix** | **string** | The target incoming URL, path, or pattern to match for redirection. | 
**Destination** | **string** | The destination URL, where the target URL should be redirected if it matches the &#x60;routePrefix&#x60;. | 
**RedirectStyle** | **int** | The type of redirect to create. Options include: 301 (permanent), 302 (temporary), or 305 (proxy). Find more details [here](https://knowledge.hubspot.com/cos-general/how-to-redirect-a-hubspot-page). | 
**ContentGroupId** | **long** |  | 
**IsOnlyAfterNotFound** | **bool** | Whether the URL redirect mapping should apply only if a live page on the URL isn&#39;t found. If False, the URL redirect mapping will take precedence over any existing page. | 
**IsRegex** | **bool** |  | 
**IsMatchFullUrl** | **bool** | Whether the &#x60;routePrefix&#x60; should match on the entire URL, including the domain. | 
**IsMatchQueryString** | **bool** | Whether the &#x60;routePrefix&#x60; should match on the entire URL path, including the query string. | 
**IsPattern** | **bool** | Whether the &#x60;routePrefix&#x60; should match based on pattern. | 
**IsTrailingSlashOptional** | **bool** | Whether a trailing slash will be ignored. | 
**IsProtocolAgnostic** | **bool** | Whether the &#x60;routePrefix&#x60; should match both HTTP and HTTPS protocols. | 
**Name** | **string** |  | 
**Precedence** | **int** | Used to prioritize URL redirection. If a given URL matches more than one redirect, the one with the **lower** precedence will be used. | 
**DeletedAt** | **long** |  | 
**Note** | **string** |  | 
**Label** | **string** |  | 
**InternallyCreated** | **bool** |  | 
**CosObjectType** | **string** |  | 
**CdnPurgeEmbargoTime** | **long** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

