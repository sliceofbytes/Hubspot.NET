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
    ///  Class for testing RowsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RowsApiTests : IDisposable
    {
        private RowsApi instance;

        public RowsApiTests()
        {
            instance = new RowsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RowsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RowsApi
            //Assert.IsType<RowsApi>(instance);
        }

        /// <summary>
        /// Test DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow
        /// </summary>
        [Fact]
        public void DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //instance.DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow(tableIdOrName, rowId);
        }

        /// <summary>
        /// Test GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows
        /// </summary>
        [Fact]
        public void GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //List<string> sort = null;
            //string after = null;
            //int? limit = null;
            //List<string> properties = null;
            //var response = instance.GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows(tableIdOrName, sort, after, limit, properties);
            //Assert.IsType<CollectionResponseWithTotalHubDbTableRowV3ForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows
        /// </summary>
        [Fact]
        public void GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //List<string> sort = null;
            //string after = null;
            //int? limit = null;
            //List<string> properties = null;
            //var response = instance.GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows(tableIdOrName, sort, after, limit, properties);
            //Assert.IsType<CollectionResponseWithTotalHubDbTableRowV3ForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById
        /// </summary>
        [Fact]
        public void GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //var response = instance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById(tableIdOrName, rowId);
            //Assert.IsType<HubDbTableRowV3>(response);
        }

        /// <summary>
        /// Test GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow
        /// </summary>
        [Fact]
        public void GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //var response = instance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow(tableIdOrName, rowId);
            //Assert.IsType<HubDbTableRowV3>(response);
        }

        /// <summary>
        /// Test PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow
        /// </summary>
        [Fact]
        public void PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //HubDbTableRowV3Request hubDbTableRowV3Request = null;
            //var response = instance.PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow(tableIdOrName, rowId, hubDbTableRowV3Request);
            //Assert.IsType<HubDbTableRowV3>(response);
        }

        /// <summary>
        /// Test PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow
        /// </summary>
        [Fact]
        public void PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //HubDbTableRowV3Request hubDbTableRowV3Request = null;
            //var response = instance.PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow(tableIdOrName, hubDbTableRowV3Request);
            //Assert.IsType<HubDbTableRowV3>(response);
        }

        /// <summary>
        /// Test PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow
        /// </summary>
        [Fact]
        public void PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //var response = instance.PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow(tableIdOrName, rowId);
            //Assert.IsType<HubDbTableRowV3>(response);
        }

        /// <summary>
        /// Test PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow
        /// </summary>
        [Fact]
        public void PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableIdOrName = null;
            //string rowId = null;
            //HubDbTableRowV3Request hubDbTableRowV3Request = null;
            //var response = instance.PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow(tableIdOrName, rowId, hubDbTableRowV3Request);
            //Assert.IsType<HubDbTableRowV3>(response);
        }
    }
}
