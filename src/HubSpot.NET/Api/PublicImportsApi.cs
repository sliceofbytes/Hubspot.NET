/*
 * HubSpot
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using HubSpot.NET.Client;
using HubSpot.NET.Model;

namespace HubSpot.NET.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicImportsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <returns>CollectionResponsePublicImportErrorForwardPaging</returns>
        CollectionResponsePublicImportErrorForwardPaging GetCrmV3ImportsImportIdErrorsGetErrors(long importId, string after = default(string), int? limit = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <returns>ApiResponse of CollectionResponsePublicImportErrorForwardPaging</returns>
        ApiResponse<CollectionResponsePublicImportErrorForwardPaging> GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfo(long importId, string after = default(string), int? limit = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicImportsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicImportErrorForwardPaging</returns>
        System.Threading.Tasks.Task<CollectionResponsePublicImportErrorForwardPaging> GetCrmV3ImportsImportIdErrorsGetErrorsAsync(long importId, string after = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicImportErrorForwardPaging)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionResponsePublicImportErrorForwardPaging>> GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfoAsync(long importId, string after = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicImportsApi : IPublicImportsApiSync, IPublicImportsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicImportsApi : IPublicImportsApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicImportsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicImportsApi(string basePath)
        {
            this.Configuration = HubSpot.NET.Client.Configuration.MergeConfigurations(
                HubSpot.NET.Client.GlobalConfiguration.Instance,
                new HubSpot.NET.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HubSpot.NET.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.NET.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HubSpot.NET.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicImportsApi(HubSpot.NET.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HubSpot.NET.Client.Configuration.MergeConfigurations(
                HubSpot.NET.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HubSpot.NET.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.NET.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HubSpot.NET.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicImportsApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HubSpot.NET.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HubSpot.NET.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HubSpot.NET.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public HubSpot.NET.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HubSpot.NET.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <returns>CollectionResponsePublicImportErrorForwardPaging</returns>
        public CollectionResponsePublicImportErrorForwardPaging GetCrmV3ImportsImportIdErrorsGetErrors(long importId, string after = default(string), int? limit = default(int?))
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicImportErrorForwardPaging> localVarResponse = GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfo(importId, after, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <returns>ApiResponse of CollectionResponsePublicImportErrorForwardPaging</returns>
        public HubSpot.NET.Client.ApiResponse<CollectionResponsePublicImportErrorForwardPaging> GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfo(long importId, string after = default(string), int? limit = default(int?))
        {
            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.NET.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.NET.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("importId", HubSpot.NET.Client.ClientUtils.ParameterToString(importId)); // path parameter
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.NET.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.NET.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionResponsePublicImportErrorForwardPaging>("/crm/v3/imports/{importId}/errors", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3ImportsImportIdErrorsGetErrors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicImportErrorForwardPaging</returns>
        public async System.Threading.Tasks.Task<CollectionResponsePublicImportErrorForwardPaging> GetCrmV3ImportsImportIdErrorsGetErrorsAsync(long importId, string after = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicImportErrorForwardPaging> localVarResponse = await GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfoAsync(importId, after, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importId"></param>
        /// <param name="after">The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. (optional)</param>
        /// <param name="limit">The maximum number of results to display per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicImportErrorForwardPaging)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<CollectionResponsePublicImportErrorForwardPaging>> GetCrmV3ImportsImportIdErrorsGetErrorsWithHttpInfoAsync(long importId, string after = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.NET.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.NET.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("importId", HubSpot.NET.Client.ClientUtils.ParameterToString(importId)); // path parameter
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.NET.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.NET.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionResponsePublicImportErrorForwardPaging>("/crm/v3/imports/{importId}/errors", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3ImportsImportIdErrorsGetErrors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
