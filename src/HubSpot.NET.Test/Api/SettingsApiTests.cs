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
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        private SettingsApi instance;

        public SettingsApiTests()
        {
            instance = new SettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsApi
            //Assert.IsType<SettingsApi>(instance);
        }

        /// <summary>
        /// Test DeleteCrmV3ExtensionsCallingAppIdSettingsArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //instance.DeleteCrmV3ExtensionsCallingAppIdSettingsArchive(appId);
        }

        /// <summary>
        /// Test DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //instance.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive(appId);
        }

        /// <summary>
        /// Test DeleteWebhooksV3AppIdSettingsClear
        /// </summary>
        [Fact]
        public void DeleteWebhooksV3AppIdSettingsClearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //instance.DeleteWebhooksV3AppIdSettingsClear(appId);
        }

        /// <summary>
        /// Test GetCrmV3ExtensionsAccountingSettingsAppIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //var response = instance.GetCrmV3ExtensionsAccountingSettingsAppIdGetById(appId);
            //Assert.IsType<AccountingAppSettings>(response);
        }

        /// <summary>
        /// Test GetCrmV3ExtensionsCallingAppIdSettingsGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ExtensionsCallingAppIdSettingsGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //var response = instance.GetCrmV3ExtensionsCallingAppIdSettingsGetById(appId);
            //Assert.IsType<CallingSettingsResponse>(response);
        }

        /// <summary>
        /// Test GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //var response = instance.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById(appId);
            //Assert.IsType<ExternalSettings>(response);
        }

        /// <summary>
        /// Test GetMarketingV3MarketingEventsAppIdSettings
        /// </summary>
        [Fact]
        public void GetMarketingV3MarketingEventsAppIdSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //var response = instance.GetMarketingV3MarketingEventsAppIdSettings(appId);
            //Assert.IsType<EventDetailSettings>(response);
        }

        /// <summary>
        /// Test GetWebhooksV3AppIdSettingsGetAll
        /// </summary>
        [Fact]
        public void GetWebhooksV3AppIdSettingsGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //var response = instance.GetWebhooksV3AppIdSettingsGetAll(appId);
            //Assert.IsType<SettingsResponse>(response);
        }

        /// <summary>
        /// Test PatchCrmV3ExtensionsCallingAppIdSettingsUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3ExtensionsCallingAppIdSettingsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //SettingsPatchRequest settingsPatchRequest = null;
            //var response = instance.PatchCrmV3ExtensionsCallingAppIdSettingsUpdate(appId, settingsPatchRequest);
            //Assert.IsType<CallingSettingsResponse>(response);
        }

        /// <summary>
        /// Test PostCrmV3ExtensionsCallingAppIdSettingsCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ExtensionsCallingAppIdSettingsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //SettingsRequest settingsRequest = null;
            //var response = instance.PostCrmV3ExtensionsCallingAppIdSettingsCreate(appId, settingsRequest);
            //Assert.IsType<CallingSettingsResponse>(response);
        }

        /// <summary>
        /// Test PostMarketingV3MarketingEventsAppIdSettings
        /// </summary>
        [Fact]
        public void PostMarketingV3MarketingEventsAppIdSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //EventDetailSettingsUrl eventDetailSettingsUrl = null;
            //var response = instance.PostMarketingV3MarketingEventsAppIdSettings(appId, eventDetailSettingsUrl);
            //Assert.IsType<EventDetailSettings>(response);
        }

        /// <summary>
        /// Test PutCrmV3ExtensionsAccountingSettingsAppIdReplace
        /// </summary>
        [Fact]
        public void PutCrmV3ExtensionsAccountingSettingsAppIdReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //AccountingAppSettings accountingAppSettings = null;
            //instance.PutCrmV3ExtensionsAccountingSettingsAppIdReplace(appId, accountingAppSettings);
        }

        /// <summary>
        /// Test PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace
        /// </summary>
        [Fact]
        public void PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //ExternalSettings externalSettings = null;
            //var response = instance.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace(appId, externalSettings);
            //Assert.IsType<ExternalSettings>(response);
        }

        /// <summary>
        /// Test PutWebhooksV3AppIdSettingsConfigure
        /// </summary>
        [Fact]
        public void PutWebhooksV3AppIdSettingsConfigureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int appId = null;
            //SettingsChangeRequest settingsChangeRequest = null;
            //var response = instance.PutWebhooksV3AppIdSettingsConfigure(appId, settingsChangeRequest);
            //Assert.IsType<SettingsResponse>(response);
        }
    }
}
