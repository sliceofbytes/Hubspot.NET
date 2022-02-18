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
    ///  Class for testing PipelineStageInput
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PipelineStageInputTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PipelineStageInput
        //private PipelineStageInput instance;

        public PipelineStageInputTests()
        {
            // TODO uncomment below to create an instance of PipelineStageInput
            //instance = new PipelineStageInput();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PipelineStageInput
        /// </summary>
        [Fact]
        public void PipelineStageInputInstanceTest()
        {
            // TODO uncomment below to test "IsType" PipelineStageInput
            //Assert.IsType<PipelineStageInput>(instance);
        }


        /// <summary>
        /// Test the property 'Label'
        /// </summary>
        [Fact]
        public void LabelTest()
        {
            // TODO unit test for the property 'Label'
        }
        /// <summary>
        /// Test the property 'DisplayOrder'
        /// </summary>
        [Fact]
        public void DisplayOrderTest()
        {
            // TODO unit test for the property 'DisplayOrder'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }

    }

}
