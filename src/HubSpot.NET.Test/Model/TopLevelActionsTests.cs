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
    ///  Class for testing TopLevelActions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TopLevelActionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TopLevelActions
        //private TopLevelActions instance;

        public TopLevelActionsTests()
        {
            // TODO uncomment below to create an instance of TopLevelActions
            //instance = new TopLevelActions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TopLevelActions
        /// </summary>
        [Fact]
        public void TopLevelActionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TopLevelActions
            //Assert.IsType<TopLevelActions>(instance);
        }


        /// <summary>
        /// Test the property 'Settings'
        /// </summary>
        [Fact]
        public void SettingsTest()
        {
            // TODO unit test for the property 'Settings'
        }
        /// <summary>
        /// Test the property 'Primary'
        /// </summary>
        [Fact]
        public void PrimaryTest()
        {
            // TODO unit test for the property 'Primary'
        }
        /// <summary>
        /// Test the property 'Secondary'
        /// </summary>
        [Fact]
        public void SecondaryTest()
        {
            // TODO unit test for the property 'Secondary'
        }

    }

}
