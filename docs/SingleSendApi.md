# HubSpot.NET.Api.SingleSendApi

All URIs are relative to *https://api.hubapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostMarketingV3TransactionalSingleEmailSendSendEmail**](SingleSendApi.md#postmarketingv3transactionalsingleemailsendsendemail) | **POST** /marketing/v3/transactional/single-email/send | Send a single transactional email asynchronously.


<a name="postmarketingv3transactionalsingleemailsendsendemail"></a>
# **PostMarketingV3TransactionalSingleEmailSendSendEmail**
> EmailSendStatusView PostMarketingV3TransactionalSingleEmailSendSendEmail (PublicSingleSendRequestEgg publicSingleSendRequestEgg = null)

Send a single transactional email asynchronously.

Asynchronously send a transactional email. Returns the status of the email send with a statusId that can be used to continuously query for the status using the Email Send Status API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.NET.Api;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace Example
{
    public class PostMarketingV3TransactionalSingleEmailSendSendEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            var apiInstance = new SingleSendApi(config);
            var publicSingleSendRequestEgg = new PublicSingleSendRequestEgg(); // PublicSingleSendRequestEgg | A request object describing the email to send. (optional) 

            try
            {
                // Send a single transactional email asynchronously.
                EmailSendStatusView result = apiInstance.PostMarketingV3TransactionalSingleEmailSendSendEmail(publicSingleSendRequestEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SingleSendApi.PostMarketingV3TransactionalSingleEmailSendSendEmail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicSingleSendRequestEgg** | [**PublicSingleSendRequestEgg**](PublicSingleSendRequestEgg.md)| A request object describing the email to send. | [optional] 

### Return type

[**EmailSendStatusView**](EmailSendStatusView.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

