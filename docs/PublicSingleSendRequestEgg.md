# HubSpot.NET.Model.PublicSingleSendRequestEgg
A request to send a single transactional email asynchronously.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | [**PublicSingleSendEmail**](PublicSingleSendEmail.md) |  | 
**ContactProperties** | **Dictionary&lt;string, string&gt;** | The contactProperties field is a map of contact property values. Each contact property value contains a name and value property. Each property will get set on the contact record and will be visible in the template under {{ contact.NAME }}. Use these properties when you want to set a contact property while you’re sending the email. For example, when sending a reciept you may want to set a last_paid_date property, as the sending of the receipt will have information about the last payment. | 
**CustomProperties** | **Object** | The customProperties field is a map of property values. Each property value contains a name and value property. Each property will be visible in the template under {{ custom.NAME }}. Note: Custom properties do not currently support arrays. To provide a listing in an email, one workaround is to build an HTML list (either with tables or ul) and specify it as a custom property. | 
**EmailId** | **int** | The content ID for the transactional email, which can be found in email tool UI. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

