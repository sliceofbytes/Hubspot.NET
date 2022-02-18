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
    ///  Class for testing ActionFunction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ActionFunctionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ActionFunction
        //private ActionFunction instance;

        public ActionFunctionTests()
        {
            // TODO uncomment below to create an instance of ActionFunction
            //instance = new ActionFunction();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ActionFunction
        /// </summary>
        [Fact]
        public void ActionFunctionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ActionFunction
            //Assert.IsType<ActionFunction>(instance);
        }


        /// <summary>
        /// Test the property 'FunctionSource'
        /// </summary>
        [Fact]
        public void FunctionSourceTest()
        {
            // TODO unit test for the property 'FunctionSource'
        }
        /// <summary>
        /// Test the property 'FunctionType'
        /// </summary>
        [Fact]
        public void FunctionTypeTest()
        {
            // TODO unit test for the property 'FunctionType'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}