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
    ///  Class for testing PublicImportMetadata
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PublicImportMetadataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PublicImportMetadata
        //private PublicImportMetadata instance;

        public PublicImportMetadataTests()
        {
            // TODO uncomment below to create an instance of PublicImportMetadata
            //instance = new PublicImportMetadata();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicImportMetadata
        /// </summary>
        [Fact]
        public void PublicImportMetadataInstanceTest()
        {
            // TODO uncomment below to test "IsType" PublicImportMetadata
            //Assert.IsType<PublicImportMetadata>(instance);
        }


        /// <summary>
        /// Test the property 'ObjectLists'
        /// </summary>
        [Fact]
        public void ObjectListsTest()
        {
            // TODO unit test for the property 'ObjectLists'
        }
        /// <summary>
        /// Test the property 'Counters'
        /// </summary>
        [Fact]
        public void CountersTest()
        {
            // TODO unit test for the property 'Counters'
        }
        /// <summary>
        /// Test the property 'FileIds'
        /// </summary>
        [Fact]
        public void FileIdsTest()
        {
            // TODO unit test for the property 'FileIds'
        }

    }

}