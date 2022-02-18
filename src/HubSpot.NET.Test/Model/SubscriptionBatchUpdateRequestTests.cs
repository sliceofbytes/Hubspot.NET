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
    ///  Class for testing SubscriptionBatchUpdateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubscriptionBatchUpdateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SubscriptionBatchUpdateRequest
        //private SubscriptionBatchUpdateRequest instance;

        public SubscriptionBatchUpdateRequestTests()
        {
            // TODO uncomment below to create an instance of SubscriptionBatchUpdateRequest
            //instance = new SubscriptionBatchUpdateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubscriptionBatchUpdateRequest
        /// </summary>
        [Fact]
        public void SubscriptionBatchUpdateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SubscriptionBatchUpdateRequest
            //Assert.IsType<SubscriptionBatchUpdateRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }

    }

}