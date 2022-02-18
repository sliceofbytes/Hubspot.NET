/*
 * HubSpot
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using HubSpot.NET.Client;
using HubSpot.NET.Api;
// uncomment below to import models
//using HubSpot.NET.Model;

namespace HubSpot.NET.Test.Api
{
    /// <summary>
    ///  Class for testing BehavioralEventsTrackingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BehavioralEventsTrackingApiTests : IDisposable
    {
        private BehavioralEventsTrackingApi instance;

        public BehavioralEventsTrackingApiTests()
        {
            instance = new BehavioralEventsTrackingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BehavioralEventsTrackingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BehavioralEventsTrackingApi
            //Assert.IsType<BehavioralEventsTrackingApi>(instance);
        }

        /// <summary>
        /// Test PostEventsV3Send
        /// </summary>
        [Fact]
        public void PostEventsV3SendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest = null;
            //instance.PostEventsV3Send(behavioralEventHttpCompletionRequest);
        }
    }
}