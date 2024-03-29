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
    ///  Class for testing Domain
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DomainTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Domain
        //private Domain instance;

        public DomainTests()
        {
            // TODO uncomment below to create an instance of Domain
            //instance = new Domain();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Domain
        /// </summary>
        [Fact]
        public void DomainInstanceTest()
        {
            // TODO uncomment below to test "IsType" Domain
            //Assert.IsType<Domain>(instance);
        }


        /// <summary>
        /// Test the property 'PortalId'
        /// </summary>
        [Fact]
        public void PortalIdTest()
        {
            // TODO unit test for the property 'PortalId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Fact]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }
        /// <summary>
        /// Test the property '_Domain'
        /// </summary>
        [Fact]
        public void _DomainTest()
        {
            // TODO unit test for the property '_Domain'
        }
        /// <summary>
        /// Test the property 'PrimaryLandingPage'
        /// </summary>
        [Fact]
        public void PrimaryLandingPageTest()
        {
            // TODO unit test for the property 'PrimaryLandingPage'
        }
        /// <summary>
        /// Test the property 'PrimaryEmail'
        /// </summary>
        [Fact]
        public void PrimaryEmailTest()
        {
            // TODO unit test for the property 'PrimaryEmail'
        }
        /// <summary>
        /// Test the property 'PrimaryBlog'
        /// </summary>
        [Fact]
        public void PrimaryBlogTest()
        {
            // TODO unit test for the property 'PrimaryBlog'
        }
        /// <summary>
        /// Test the property 'PrimaryBlogPost'
        /// </summary>
        [Fact]
        public void PrimaryBlogPostTest()
        {
            // TODO unit test for the property 'PrimaryBlogPost'
        }
        /// <summary>
        /// Test the property 'PrimarySitePage'
        /// </summary>
        [Fact]
        public void PrimarySitePageTest()
        {
            // TODO unit test for the property 'PrimarySitePage'
        }
        /// <summary>
        /// Test the property 'PrimaryKnowledge'
        /// </summary>
        [Fact]
        public void PrimaryKnowledgeTest()
        {
            // TODO unit test for the property 'PrimaryKnowledge'
        }
        /// <summary>
        /// Test the property 'PrimaryLegacyPage'
        /// </summary>
        [Fact]
        public void PrimaryLegacyPageTest()
        {
            // TODO unit test for the property 'PrimaryLegacyPage'
        }
        /// <summary>
        /// Test the property 'PrimaryClickTracking'
        /// </summary>
        [Fact]
        public void PrimaryClickTrackingTest()
        {
            // TODO unit test for the property 'PrimaryClickTracking'
        }
        /// <summary>
        /// Test the property 'FullCategoryKey'
        /// </summary>
        [Fact]
        public void FullCategoryKeyTest()
        {
            // TODO unit test for the property 'FullCategoryKey'
        }
        /// <summary>
        /// Test the property 'SecondaryToDomain'
        /// </summary>
        [Fact]
        public void SecondaryToDomainTest()
        {
            // TODO unit test for the property 'SecondaryToDomain'
        }
        /// <summary>
        /// Test the property 'IsResolving'
        /// </summary>
        [Fact]
        public void IsResolvingTest()
        {
            // TODO unit test for the property 'IsResolving'
        }
        /// <summary>
        /// Test the property 'IsDnsCorrect'
        /// </summary>
        [Fact]
        public void IsDnsCorrectTest()
        {
            // TODO unit test for the property 'IsDnsCorrect'
        }
        /// <summary>
        /// Test the property 'ManuallyMarkedAsResolving'
        /// </summary>
        [Fact]
        public void ManuallyMarkedAsResolvingTest()
        {
            // TODO unit test for the property 'ManuallyMarkedAsResolving'
        }
        /// <summary>
        /// Test the property 'ConsecutiveNonResolvingCount'
        /// </summary>
        [Fact]
        public void ConsecutiveNonResolvingCountTest()
        {
            // TODO unit test for the property 'ConsecutiveNonResolvingCount'
        }
        /// <summary>
        /// Test the property 'SslCname'
        /// </summary>
        [Fact]
        public void SslCnameTest()
        {
            // TODO unit test for the property 'SslCname'
        }
        /// <summary>
        /// Test the property 'IsSslEnabled'
        /// </summary>
        [Fact]
        public void IsSslEnabledTest()
        {
            // TODO unit test for the property 'IsSslEnabled'
        }
        /// <summary>
        /// Test the property 'IsSslOnly'
        /// </summary>
        [Fact]
        public void IsSslOnlyTest()
        {
            // TODO unit test for the property 'IsSslOnly'
        }
        /// <summary>
        /// Test the property 'CertificateId'
        /// </summary>
        [Fact]
        public void CertificateIdTest()
        {
            // TODO unit test for the property 'CertificateId'
        }
        /// <summary>
        /// Test the property 'SslRequestId'
        /// </summary>
        [Fact]
        public void SslRequestIdTest()
        {
            // TODO unit test for the property 'SslRequestId'
        }
        /// <summary>
        /// Test the property 'IsUsedForBlogPost'
        /// </summary>
        [Fact]
        public void IsUsedForBlogPostTest()
        {
            // TODO unit test for the property 'IsUsedForBlogPost'
        }
        /// <summary>
        /// Test the property 'IsUsedForSitePage'
        /// </summary>
        [Fact]
        public void IsUsedForSitePageTest()
        {
            // TODO unit test for the property 'IsUsedForSitePage'
        }
        /// <summary>
        /// Test the property 'IsUsedForLandingPage'
        /// </summary>
        [Fact]
        public void IsUsedForLandingPageTest()
        {
            // TODO unit test for the property 'IsUsedForLandingPage'
        }
        /// <summary>
        /// Test the property 'IsUsedForEmail'
        /// </summary>
        [Fact]
        public void IsUsedForEmailTest()
        {
            // TODO unit test for the property 'IsUsedForEmail'
        }
        /// <summary>
        /// Test the property 'IsUsedForKnowledge'
        /// </summary>
        [Fact]
        public void IsUsedForKnowledgeTest()
        {
            // TODO unit test for the property 'IsUsedForKnowledge'
        }
        /// <summary>
        /// Test the property 'SetupTaskId'
        /// </summary>
        [Fact]
        public void SetupTaskIdTest()
        {
            // TODO unit test for the property 'SetupTaskId'
        }
        /// <summary>
        /// Test the property 'IsSetupComplete'
        /// </summary>
        [Fact]
        public void IsSetupCompleteTest()
        {
            // TODO unit test for the property 'IsSetupComplete'
        }
        /// <summary>
        /// Test the property 'SetUpLanguage'
        /// </summary>
        [Fact]
        public void SetUpLanguageTest()
        {
            // TODO unit test for the property 'SetUpLanguage'
        }
        /// <summary>
        /// Test the property 'TeamIds'
        /// </summary>
        [Fact]
        public void TeamIdsTest()
        {
            // TODO unit test for the property 'TeamIds'
        }
        /// <summary>
        /// Test the property 'ActualCname'
        /// </summary>
        [Fact]
        public void ActualCnameTest()
        {
            // TODO unit test for the property 'ActualCname'
        }
        /// <summary>
        /// Test the property 'CorrectCname'
        /// </summary>
        [Fact]
        public void CorrectCnameTest()
        {
            // TODO unit test for the property 'CorrectCname'
        }
        /// <summary>
        /// Test the property 'ActualIp'
        /// </summary>
        [Fact]
        public void ActualIpTest()
        {
            // TODO unit test for the property 'ActualIp'
        }
        /// <summary>
        /// Test the property 'ApexResolutionStatus'
        /// </summary>
        [Fact]
        public void ApexResolutionStatusTest()
        {
            // TODO unit test for the property 'ApexResolutionStatus'
        }
        /// <summary>
        /// Test the property 'ApexDomain'
        /// </summary>
        [Fact]
        public void ApexDomainTest()
        {
            // TODO unit test for the property 'ApexDomain'
        }
        /// <summary>
        /// Test the property 'PublicSuffix'
        /// </summary>
        [Fact]
        public void PublicSuffixTest()
        {
            // TODO unit test for the property 'PublicSuffix'
        }
        /// <summary>
        /// Test the property 'ApexIpAddresses'
        /// </summary>
        [Fact]
        public void ApexIpAddressesTest()
        {
            // TODO unit test for the property 'ApexIpAddresses'
        }
        /// <summary>
        /// Test the property 'SiteId'
        /// </summary>
        [Fact]
        public void SiteIdTest()
        {
            // TODO unit test for the property 'SiteId'
        }
        /// <summary>
        /// Test the property 'BrandId'
        /// </summary>
        [Fact]
        public void BrandIdTest()
        {
            // TODO unit test for the property 'BrandId'
        }
        /// <summary>
        /// Test the property 'Deletable'
        /// </summary>
        [Fact]
        public void DeletableTest()
        {
            // TODO unit test for the property 'Deletable'
        }
        /// <summary>
        /// Test the property 'DomainCdnConfig'
        /// </summary>
        [Fact]
        public void DomainCdnConfigTest()
        {
            // TODO unit test for the property 'DomainCdnConfig'
        }
        /// <summary>
        /// Test the property 'SetupInfo'
        /// </summary>
        [Fact]
        public void SetupInfoTest()
        {
            // TODO unit test for the property 'SetupInfo'
        }
        /// <summary>
        /// Test the property 'DerivedBrandName'
        /// </summary>
        [Fact]
        public void DerivedBrandNameTest()
        {
            // TODO unit test for the property 'DerivedBrandName'
        }
        /// <summary>
        /// Test the property 'CreatedById'
        /// </summary>
        [Fact]
        public void CreatedByIdTest()
        {
            // TODO unit test for the property 'CreatedById'
        }
        /// <summary>
        /// Test the property 'UpdatedById'
        /// </summary>
        [Fact]
        public void UpdatedByIdTest()
        {
            // TODO unit test for the property 'UpdatedById'
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
        /// Test the property 'IsAnyPrimary'
        /// </summary>
        [Fact]
        public void IsAnyPrimaryTest()
        {
            // TODO unit test for the property 'IsAnyPrimary'
        }
        /// <summary>
        /// Test the property 'IsLegacyDomain'
        /// </summary>
        [Fact]
        public void IsLegacyDomainTest()
        {
            // TODO unit test for the property 'IsLegacyDomain'
        }
        /// <summary>
        /// Test the property 'IsInternalDomain'
        /// </summary>
        [Fact]
        public void IsInternalDomainTest()
        {
            // TODO unit test for the property 'IsInternalDomain'
        }
        /// <summary>
        /// Test the property 'IsResolvingInternalProperty'
        /// </summary>
        [Fact]
        public void IsResolvingInternalPropertyTest()
        {
            // TODO unit test for the property 'IsResolvingInternalProperty'
        }
        /// <summary>
        /// Test the property 'IsResolvingIgnoringManuallyMarkedAsResolving'
        /// </summary>
        [Fact]
        public void IsResolvingIgnoringManuallyMarkedAsResolvingTest()
        {
            // TODO unit test for the property 'IsResolvingIgnoringManuallyMarkedAsResolving'
        }
        /// <summary>
        /// Test the property 'IsUsedForAnyContentType'
        /// </summary>
        [Fact]
        public void IsUsedForAnyContentTypeTest()
        {
            // TODO unit test for the property 'IsUsedForAnyContentType'
        }
        /// <summary>
        /// Test the property 'IsLegacy'
        /// </summary>
        [Fact]
        public void IsLegacyTest()
        {
            // TODO unit test for the property 'IsLegacy'
        }
        /// <summary>
        /// Test the property 'AuthorAt'
        /// </summary>
        [Fact]
        public void AuthorAtTest()
        {
            // TODO unit test for the property 'AuthorAt'
        }
        /// <summary>
        /// Test the property 'CosObjectType'
        /// </summary>
        [Fact]
        public void CosObjectTypeTest()
        {
            // TODO unit test for the property 'CosObjectType'
        }
        /// <summary>
        /// Test the property 'CdnPurgeEmbargoTime'
        /// </summary>
        [Fact]
        public void CdnPurgeEmbargoTimeTest()
        {
            // TODO unit test for the property 'CdnPurgeEmbargoTime'
        }
        /// <summary>
        /// Test the property 'IsStagingDomain'
        /// </summary>
        [Fact]
        public void IsStagingDomainTest()
        {
            // TODO unit test for the property 'IsStagingDomain'
        }

    }

}
