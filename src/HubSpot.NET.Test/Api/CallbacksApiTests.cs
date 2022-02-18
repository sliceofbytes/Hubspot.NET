/*
 * HubSpot
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using HubSpot.NET.Client;
using HubSpot.NET.Api;
// uncomment below to import models
//using HubSpot.NET.Model;

namespace HubSpot.NET.Test.Api
{
    /// <summary>
    ///  Class for testing CallbacksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallbacksApiTests : IDisposable
    {
        private CallbacksApi instance;

        public CallbacksApiTests()
        {
            instance = new CallbacksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallbacksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CallbacksApi
            //Assert.IsType<CallbacksApi>(instance);
        }

        /// <summary>
        /// Test PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete
        /// </summary>
        [Fact]
        public void PostAutomationV4ActionsCallbacksCallbackIdCompleteCompleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string callbackId = null;
            //CallbackCompletionRequest callbackCompletionRequest = null;
            //instance.PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete(callbackId, callbackCompletionRequest);
        }

        /// <summary>
        /// Test PostAutomationV4ActionsCallbacksCompleteCompleteBatch
        /// </summary>
        [Fact]
        public void PostAutomationV4ActionsCallbacksCompleteCompleteBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputCallbackCompletionBatchRequest batchInputCallbackCompletionBatchRequest = null;
            //instance.PostAutomationV4ActionsCallbacksCompleteCompleteBatch(batchInputCallbackCompletionBatchRequest);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //ResultIdAccountingResponse resultIdAccountingResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer(requestId, resultIdAccountingResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //CustomerSearchResponseExternal customerSearchResponseExternal = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch(requestId, customerSearchResponseExternal);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //ExchangeRateResponse exchangeRateResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate(requestId, exchangeRateResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //ResultIdAccountingResponse resultIdAccountingResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice(requestId, resultIdAccountingResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //InvoicePdfResponse invoicePdfResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf(requestId, invoicePdfResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //InvoiceSearchResponse invoiceSearchResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch(requestId, invoiceSearchResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //InvoicesResponseExternal invoicesResponseExternal = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById(requestId, invoicesResponseExternal);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //ProductSearchResponse productSearchResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch(requestId, productSearchResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //TaxSearchResponse taxSearchResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch(requestId, taxSearchResponse);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTermTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //TermsResponse termsResponse = null;
            //instance.PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm(requestId, termsResponse);
        }
    }
}
