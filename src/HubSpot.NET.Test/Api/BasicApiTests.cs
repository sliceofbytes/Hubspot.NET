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
    ///  Class for testing BasicApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BasicApiTests : IDisposable
    {
        private BasicApi instance;

        public BasicApiTests()
        {
            instance = new BasicApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BasicApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BasicApi
            //Assert.IsType<BasicApi>(instance);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsCompaniesCompanyIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsCompaniesCompanyIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyId = null;
            //instance.DeleteCrmV3ObjectsCompaniesCompanyIdArchive(companyId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsContactsContactIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsContactsContactIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //instance.DeleteCrmV3ObjectsContactsContactIdArchive(contactId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsDealsDealIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsDealsDealIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dealId = null;
            //instance.DeleteCrmV3ObjectsDealsDealIdArchive(dealId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsLineItemsLineItemIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsLineItemsLineItemIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lineItemId = null;
            //instance.DeleteCrmV3ObjectsLineItemsLineItemIdArchive(lineItemId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsObjectTypeObjectIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsObjectTypeObjectIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string objectId = null;
            //instance.DeleteCrmV3ObjectsObjectTypeObjectIdArchive(objectType, objectId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsProductsProductIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsProductsProductIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //instance.DeleteCrmV3ObjectsProductsProductIdArchive(productId);
        }

        /// <summary>
        /// Test DeleteCrmV3ObjectsTicketsTicketIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ObjectsTicketsTicketIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //instance.DeleteCrmV3ObjectsTicketsTicketIdArchive(ticketId);
        }

        /// <summary>
        /// Test DeleteMarketingV3MarketingEventsEventsExternalEventId
        /// </summary>
        [Fact]
        public void DeleteMarketingV3MarketingEventsEventsExternalEventIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalEventId = null;
            //string externalAccountId = null;
            //instance.DeleteMarketingV3MarketingEventsEventsExternalEventId(externalEventId, externalAccountId);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsCompaniesCompanyIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsCompaniesCompanyIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsCompaniesCompanyIdGetById(companyId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<CompaniesSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsCompaniesGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsCompaniesGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsCompaniesGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<CompaniesCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsContactsContactIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsContactsContactIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsContactsContactIdGetById(contactId, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<ContactsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsContactsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsContactsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsContactsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<ContactsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsDealsDealIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsDealsDealIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dealId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsDealsDealIdGetById(dealId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<DealsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsDealsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsDealsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsDealsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<DealsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedbackSubmissionId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById(feedbackSubmissionId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<FeedbackSubmissionsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsFeedbackSubmissionsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsFeedbackSubmissionsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsFeedbackSubmissionsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<FeedbackSubmissionsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsLineItemsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsLineItemsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsLineItemsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<LineItemsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsLineItemsLineItemIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsLineItemsLineItemIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lineItemId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsLineItemsLineItemIdGetById(lineItemId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<LineItemsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsObjectTypeGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsObjectTypeGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsObjectTypeGetPage(objectType, limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<ObjectsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsObjectTypeObjectIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsObjectTypeObjectIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string objectId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsObjectTypeObjectIdGetById(objectType, objectId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<ObjectsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsProductsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsProductsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsProductsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsProductsProductIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsProductsProductIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsProductsProductIdGetById(productId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<SimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsQuotesGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsQuotesGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsQuotesGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<QuotesCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsQuotesQuoteIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsQuotesQuoteIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string quoteId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsQuotesQuoteIdGetById(quoteId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<QuotesSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsTicketsGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsTicketsGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string after = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3ObjectsTicketsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
            //Assert.IsType<TicketsCollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3ObjectsTicketsTicketIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ObjectsTicketsTicketIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //List<string> properties = null;
            //List<string> propertiesWithHistory = null;
            //List<string> associations = null;
            //bool? archived = null;
            //string idProperty = null;
            //var response = instance.GetCrmV3ObjectsTicketsTicketIdGetById(ticketId, properties, propertiesWithHistory, associations, archived, idProperty);
            //Assert.IsType<TicketsSimplePublicObjectWithAssociations>(response);
        }

        /// <summary>
        /// Test GetMarketingV3MarketingEventsEventsExternalEventId
        /// </summary>
        [Fact]
        public void GetMarketingV3MarketingEventsEventsExternalEventIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalEventId = null;
            //string externalAccountId = null;
            //var response = instance.GetMarketingV3MarketingEventsEventsExternalEventId(externalEventId, externalAccountId);
            //Assert.IsType<MarketingEventPublicReadResponse>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsCompaniesCompanyIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsCompaniesCompanyIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyId = null;
            //CompaniesSimplePublicObjectInput companiesSimplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsCompaniesCompanyIdUpdate(companyId, companiesSimplePublicObjectInput, idProperty);
            //Assert.IsType<CompaniesSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsContactsContactIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsContactsContactIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //ContactsSimplePublicObjectInput contactsSimplePublicObjectInput = null;
            //var response = instance.PatchCrmV3ObjectsContactsContactIdUpdate(contactId, contactsSimplePublicObjectInput);
            //Assert.IsType<ContactsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsDealsDealIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsDealsDealIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dealId = null;
            //DealsSimplePublicObjectInput dealsSimplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsDealsDealIdUpdate(dealId, dealsSimplePublicObjectInput, idProperty);
            //Assert.IsType<DealsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsLineItemsLineItemIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsLineItemsLineItemIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lineItemId = null;
            //LineItemsSimplePublicObjectInput lineItemsSimplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsLineItemsLineItemIdUpdate(lineItemId, lineItemsSimplePublicObjectInput, idProperty);
            //Assert.IsType<LineItemsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsObjectTypeObjectIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsObjectTypeObjectIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string objectId = null;
            //ObjectsSimplePublicObjectInput objectsSimplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsObjectTypeObjectIdUpdate(objectType, objectId, objectsSimplePublicObjectInput, idProperty);
            //Assert.IsType<ObjectsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsProductsProductIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsProductsProductIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //SimplePublicObjectInput simplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsProductsProductIdUpdate(productId, simplePublicObjectInput, idProperty);
            //Assert.IsType<SimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ObjectsTicketsTicketIdUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ObjectsTicketsTicketIdUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //TicketsSimplePublicObjectInput ticketsSimplePublicObjectInput = null;
            //string idProperty = null;
            //var response = instance.PatchCrmV3ObjectsTicketsTicketIdUpdate(ticketId, ticketsSimplePublicObjectInput, idProperty);
            //Assert.IsType<TicketsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PatchMarketingV3MarketingEventsEventsExternalEventId
        /// </summary>
        [Fact]
        public void PatchMarketingV3MarketingEventsEventsExternalEventIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalEventId = null;
            //string externalAccountId = null;
            //MarketingEventUpdateRequestParams marketingEventUpdateRequestParams = null;
            //var response = instance.PatchMarketingV3MarketingEventsEventsExternalEventId(externalEventId, externalAccountId, marketingEventUpdateRequestParams);
            //Assert.IsType<MarketingEventPublicDefaultResponse>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsCompaniesCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsCompaniesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompaniesSimplePublicObjectInput companiesSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsCompaniesCreate(companiesSimplePublicObjectInput);
            //Assert.IsType<CompaniesSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsContactsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsContactsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContactsSimplePublicObjectInput contactsSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsContactsCreate(contactsSimplePublicObjectInput);
            //Assert.IsType<ContactsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsDealsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsDealsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DealsSimplePublicObjectInput dealsSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsDealsCreate(dealsSimplePublicObjectInput);
            //Assert.IsType<DealsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LineItemsSimplePublicObjectInput lineItemsSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsLineItemsCreate(lineItemsSimplePublicObjectInput);
            //Assert.IsType<LineItemsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsObjectTypeCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsObjectTypeCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //ObjectsSimplePublicObjectInput objectsSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsObjectTypeCreate(objectType, objectsSimplePublicObjectInput);
            //Assert.IsType<ObjectsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsProductsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SimplePublicObjectInput simplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsProductsCreate(simplePublicObjectInput);
            //Assert.IsType<SimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsTicketsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsTicketsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TicketsSimplePublicObjectInput ticketsSimplePublicObjectInput = null;
            //var response = instance.PostCrmV3ObjectsTicketsCreate(ticketsSimplePublicObjectInput);
            //Assert.IsType<TicketsSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostMarketingV3MarketingEventsEvents
        /// </summary>
        [Fact]
        public void PostMarketingV3MarketingEventsEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MarketingEventCreateRequestParams marketingEventCreateRequestParams = null;
            //var response = instance.PostMarketingV3MarketingEventsEvents(marketingEventCreateRequestParams);
            //Assert.IsType<MarketingEventDefaultResponse>(response);
        }

        /// <summary>
        /// Test PostMarketingV3MarketingEventsEventsExternalEventIdCancel
        /// </summary>
        [Fact]
        public void PostMarketingV3MarketingEventsEventsExternalEventIdCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalEventId = null;
            //string externalAccountId = null;
            //var response = instance.PostMarketingV3MarketingEventsEventsExternalEventIdCancel(externalEventId, externalAccountId);
            //Assert.IsType<MarketingEventDefaultResponse>(response);
        }

        /// <summary>
        /// Test PutMarketingV3MarketingEventsEventsExternalEventId
        /// </summary>
        [Fact]
        public void PutMarketingV3MarketingEventsEventsExternalEventIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalEventId = null;
            //MarketingEventCreateRequestParams marketingEventCreateRequestParams = null;
            //var response = instance.PutMarketingV3MarketingEventsEventsExternalEventId(externalEventId, marketingEventCreateRequestParams);
            //Assert.IsType<MarketingEventPublicDefaultResponse>(response);
        }
    }
}
