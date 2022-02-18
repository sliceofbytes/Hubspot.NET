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
    ///  Class for testing InvoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvoiceApiTests : IDisposable
    {
        private InvoiceApi instance;

        public InvoiceApiTests()
        {
            instance = new InvoiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvoiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvoiceApi
            //Assert.IsType<InvoiceApi>(instance);
        }

        /// <summary>
        /// Test GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //string accountId = null;
            //var response = instance.GetCrmV3ExtensionsAccountingInvoiceInvoiceIdGetById(invoiceId, accountId);
            //Assert.IsType<InvoiceReadResponse>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //string accountId = null;
            //InvoiceUpdateRequest invoiceUpdateRequest = null;
            //var response = instance.PatchCrmV3ExtensionsAccountingInvoiceInvoiceIdUpdate(invoiceId, accountId, invoiceUpdateRequest);
            //Assert.IsType<InvoiceUpdateResponse>(response);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //InvoiceCreatePaymentRequest invoiceCreatePaymentRequest = null;
            //string accountId = null;
            //var response = instance.PostCrmV3ExtensionsAccountingInvoiceInvoiceIdPaymentCreatePayment(invoiceId, invoiceCreatePaymentRequest, accountId);
            //Assert.IsType<InvoiceUpdateResponse>(response);
        }
    }
}
