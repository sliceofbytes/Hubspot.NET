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
    ///  Class for testing ConditionalSingleFieldDependency
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConditionalSingleFieldDependencyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConditionalSingleFieldDependency
        //private ConditionalSingleFieldDependency instance;

        public ConditionalSingleFieldDependencyTests()
        {
            // TODO uncomment below to create an instance of ConditionalSingleFieldDependency
            //instance = new ConditionalSingleFieldDependency();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConditionalSingleFieldDependency
        /// </summary>
        [Fact]
        public void ConditionalSingleFieldDependencyInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConditionalSingleFieldDependency
            //Assert.IsType<ConditionalSingleFieldDependency>(instance);
        }


        /// <summary>
        /// Test the property 'DependencyType'
        /// </summary>
        [Fact]
        public void DependencyTypeTest()
        {
            // TODO unit test for the property 'DependencyType'
        }
        /// <summary>
        /// Test the property 'DependentFieldNames'
        /// </summary>
        [Fact]
        public void DependentFieldNamesTest()
        {
            // TODO unit test for the property 'DependentFieldNames'
        }
        /// <summary>
        /// Test the property 'ControllingFieldName'
        /// </summary>
        [Fact]
        public void ControllingFieldNameTest()
        {
            // TODO unit test for the property 'ControllingFieldName'
        }
        /// <summary>
        /// Test the property 'ControllingFieldValue'
        /// </summary>
        [Fact]
        public void ControllingFieldValueTest()
        {
            // TODO unit test for the property 'ControllingFieldValue'
        }

    }

}
