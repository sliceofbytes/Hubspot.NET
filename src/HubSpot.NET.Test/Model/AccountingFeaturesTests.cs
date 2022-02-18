/*
 * HubSpot
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.NET.Api;
using HubSpot.NET.Model;
using HubSpot.NET.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.NET.Test.Model
{
    /// <summary>
    ///  Class for testing AccountingFeatures
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountingFeaturesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccountingFeatures
        //private AccountingFeatures instance;

        public AccountingFeaturesTests()
        {
            // TODO uncomment below to create an instance of AccountingFeatures
            //instance = new AccountingFeatures();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountingFeatures
        /// </summary>
        [Fact]
        public void AccountingFeaturesInstanceTest()
        {
            // TODO uncomment below to test "IsType" AccountingFeatures
            //Assert.IsType<AccountingFeatures>(instance);
        }


        /// <summary>
        /// Test the property 'CreateInvoice'
        /// </summary>
        [Fact]
        public void CreateInvoiceTest()
        {
            // TODO unit test for the property 'CreateInvoice'
        }
        /// <summary>
        /// Test the property 'ImportInvoice'
        /// </summary>
        [Fact]
        public void ImportInvoiceTest()
        {
            // TODO unit test for the property 'ImportInvoice'
        }
        /// <summary>
        /// Test the property 'Sync'
        /// </summary>
        [Fact]
        public void SyncTest()
        {
            // TODO unit test for the property 'Sync'
        }

    }

}