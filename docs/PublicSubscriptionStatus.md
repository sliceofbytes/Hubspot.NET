# HubSpot.NET.Model.PublicSubscriptionStatus
The status of a subscription for a contact.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID for the subscription. | 
**Name** | **string** | The name of the subscription. | 
**Description** | **string** | A description of the subscription. | 
**Status** | **string** | Whether the contact is subscribed. | 
**SourceOfStatus** | **string** | Where the status is determined from e.g. PORTAL_WIDE_STATUS if the contact opted out from the portal. | 
**BrandId** | **long** | The ID of the brand that the subscription is associated with, if there is one. | [optional] 
**PreferenceGroupName** | **string** | The name of the preferences group that the subscription is associated with. | [optional] 
**LegalBasis** | **string** | The legal reason for the current status of the subscription. | [optional] 
**LegalBasisExplanation** | **string** | A more detailed explanation to go with the legal basis. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

