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
    ///  Class for testing Tax
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaxTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Tax
        //private Tax instance;

        public TaxTests()
        {
            // TODO uncomment below to create an instance of Tax
            //instance = new Tax();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Tax
        /// </summary>
        [Fact]
        public void TaxInstanceTest()
        {
            // TODO uncomment below to test "IsType" Tax
            //Assert.IsType<Tax>(instance);
        }


        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Percentage'
        /// </summary>
        [Fact]
        public void PercentageTest()
        {
            // TODO unit test for the property 'Percentage'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
