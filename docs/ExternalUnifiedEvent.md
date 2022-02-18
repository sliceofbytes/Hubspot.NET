# HubSpot.NET.Model.ExternalUnifiedEvent
Used to represent any event. With this format, the `objectType` and `eventType` values are stringified CRM types. Example object: <br/> ```  {       \"objectType\": \"CONTACT\",       \"objectId\": 208451632,       \"eventType\": \"e_visited_page\",       \"occurredAt\": 1567377501421,       \"id\": \"leviathan-be3335d3-46f1-3985-988e-ff38e6e7b9d8\",       \"properties\": {           \"hs_url\": \"https://some-website.com/\",           \"hs_title\": \"Home\",           \"hs_referrer\": \"https://some-other-website.com/blog/why-we-love-big-data-and-you-should-too\",           \"hs_userAgent\": \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.80 Safari/537.36\",           \"hs_city\": \"lund\",           \"hs_region\": \"m\",           \"hs_country\": \"se\",           \"hs_session_id\" : \"leviathan-be3335d3-46f1-3985-988e-ff38e6e7b9d8\",           \"hs_session_source\" : \"DIRECT\"       }   }       ```

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **string** | The objectType for the object which did the event. | 
**ObjectId** | **string** | The objectId of the object which did the event. | 
**EventType** | **string** | The format of the &#x60;eventType&#x60; string is &#x60;ae{appId}_{eventTypeLabel}&#x60;, &#x60;pe{portalId}_{eventTypeLabel}&#x60;, or just &#x60;e_{eventTypeLabel}&#x60; for HubSpot events. | 
**OccurredAt** | **DateTimeOffset** | An ISO 8601 timestamp when the event occurred. | 
**Id** | **string** | A unique identifier for the event. | 
**Properties** | **Dictionary&lt;string, string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

