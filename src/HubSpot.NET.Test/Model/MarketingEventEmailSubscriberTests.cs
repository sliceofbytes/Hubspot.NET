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
    ///  Class for testing MarketingEventEmailSubscriber
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MarketingEventEmailSubscriberTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MarketingEventEmailSubscriber
        //private MarketingEventEmailSubscriber instance;

        public MarketingEventEmailSubscriberTests()
        {
            // TODO uncomment below to create an instance of MarketingEventEmailSubscriber
            //instance = new MarketingEventEmailSubscriber();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MarketingEventEmailSubscriber
        /// </summary>
        [Fact]
        public void MarketingEventEmailSubscriberInstanceTest()
        {
            // TODO uncomment below to test "IsType" MarketingEventEmailSubscriber
            //Assert.IsType<MarketingEventEmailSubscriber>(instance);
        }


        /// <summary>
        /// Test the property 'InteractionDateTime'
        /// </summary>
        [Fact]
        public void InteractionDateTimeTest()
        {
            // TODO unit test for the property 'InteractionDateTime'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

    }

}
