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
    ///  Class for testing SyncProductsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SyncProductsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SyncProductsRequest
        //private SyncProductsRequest instance;

        public SyncProductsRequestTests()
        {
            // TODO uncomment below to create an instance of SyncProductsRequest
            //instance = new SyncProductsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SyncProductsRequest
        /// </summary>
        [Fact]
        public void SyncProductsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SyncProductsRequest
            //Assert.IsType<SyncProductsRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'Products'
        /// </summary>
        [Fact]
        public void ProductsTest()
        {
            // TODO unit test for the property 'Products'
        }

    }

}
