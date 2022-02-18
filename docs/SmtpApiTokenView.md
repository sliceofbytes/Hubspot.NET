# HubSpot.NET.Model.SmtpApiTokenView
A SMTP API token provides both an ID and password that can be used to send email through the HubSpot SMTP API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | User name to log into the HubSpot SMTP server. | 
**CreatedBy** | **string** | Email address of the user that sent the token creation request. | 
**Password** | **string** | Password used to log into the HubSpot SMTP server. | [optional] 
**EmailCampaignId** | **string** | Identifier assigned to the campaign provided in the token creation request. | 
**CreatedAt** | **DateTimeOffset** | Timestamp generated when a token is created. | 
**CreateContact** | **bool** | Indicates whether a contact should be created for recipients of emails. | 
**CampaignName** | **string** | A name for the campaign tied to the token. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

