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
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventsApi
            //Assert.IsType<EventsApi>(instance);
        }

        /// <summary>
        /// Test GetEventsV3EventsGetPage
        /// </summary>
        [Fact]
        public void GetEventsV3EventsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTimeOffset? occurredAfter = null;
            //DateTimeOffset? occurredBefore = null;
            //string objectType = null;
            //long? objectId = null;
            //string eventType = null;
            //string after = null;
            //string before = null;
            //int? limit = null;
            //List<string> sort = null;
            //var response = instance.GetEventsV3EventsGetPage(occurredAfter, occurredBefore, objectType, objectId, eventType, after, before, limit, sort);
            //Assert.IsType<CollectionResponseExternalUnifiedEvent>(response);
        }

        /// <summary>
        /// Test GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById
        /// </summary>
        [Fact]
        public void GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventTemplateId = null;
            //string eventId = null;
            //var response = instance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById(eventTemplateId, eventId);
            //Assert.IsType<EventDetail>(response);
        }

        /// <summary>
        /// Test GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById
        /// </summary>
        [Fact]
        public void GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventTemplateId = null;
            //string eventId = null;
            //var response = instance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById(eventTemplateId, eventId);
            //Assert.IsType<TimelineEventResponse>(response);
        }

        /// <summary>
        /// Test GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById
        /// </summary>
        [Fact]
        public void GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventTemplateId = null;
            //string eventId = null;
            //bool? detail = null;
            //var response = instance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById(eventTemplateId, eventId, detail);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test PostIntegratorsTimelineV3EventsBatchCreateCreateBatch
        /// </summary>
        [Fact]
        public void PostIntegratorsTimelineV3EventsBatchCreateCreateBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputTimelineEvent batchInputTimelineEvent = null;
            //var response = instance.PostIntegratorsTimelineV3EventsBatchCreateCreateBatch(batchInputTimelineEvent);
            //Assert.IsType<BatchResponseTimelineEventResponse>(response);
        }

        /// <summary>
        /// Test PostIntegratorsTimelineV3EventsCreate
        /// </summary>
        [Fact]
        public void PostIntegratorsTimelineV3EventsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimelineEvent timelineEvent = null;
            //var response = instance.PostIntegratorsTimelineV3EventsCreate(timelineEvent);
            //Assert.IsType<TimelineEventResponse>(response);
        }
    }
}
