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
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test GetMarketingV3MarketingEventsEventsSearch
        /// </summary>
        [Fact]
        public void GetMarketingV3MarketingEventsEventsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //var response = instance.GetMarketingV3MarketingEventsEventsSearch(q);
            //Assert.IsType<CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsCompaniesSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsCompaniesSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsCompaniesSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<CollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsContactsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsContactsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsContactsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<ContactsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsDealsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsDealsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsDealsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<DealsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsFeedbackSubmissionsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<FeedbackSubmissionsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsLineItemsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<LineItemsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsObjectTypeSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsObjectTypeSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsObjectTypeSearchDoSearch(objectType, publicObjectSearchRequest);
            //Assert.IsType<ObjectsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsProductsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsProductsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<CollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsQuotesSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsQuotesSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsQuotesSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<QuotesCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsTicketsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsTicketsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsTicketsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<TicketsCollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }
    }
}
