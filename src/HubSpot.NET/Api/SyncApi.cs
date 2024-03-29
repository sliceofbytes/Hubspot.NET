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
    public interface ISyncApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Import contacts
        /// </summary>
        /// <remarks>
        /// Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <returns>ActionResponse</returns>
        ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact(int appId, SyncContactsRequest syncContactsRequest);

        /// <summary>
        /// Import contacts
        /// </summary>
        /// <remarks>
        /// Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <returns>ApiResponse of ActionResponse</returns>
        ApiResponse<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo(int appId, SyncContactsRequest syncContactsRequest);
        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <returns>ActionResponse</returns>
        ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct(int appId, SyncProductsRequest syncProductsRequest);

        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <returns>ApiResponse of ActionResponse</returns>
        ApiResponse<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo(int appId, SyncProductsRequest syncProductsRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISyncApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Import contacts
        /// </summary>
        /// <remarks>
        /// Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ActionResponse</returns>
        System.Threading.Tasks.Task<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactAsync(int appId, SyncContactsRequest syncContactsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Import contacts
        /// </summary>
        /// <remarks>
        /// Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionResponse>> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfoAsync(int appId, SyncContactsRequest syncContactsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ActionResponse</returns>
        System.Threading.Tasks.Task<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductAsync(int appId, SyncProductsRequest syncProductsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionResponse>> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfoAsync(int appId, SyncProductsRequest syncProductsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISyncApi : ISyncApiSync, ISyncApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SyncApi : ISyncApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SyncApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SyncApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SyncApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SyncApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SyncApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SyncApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// Import contacts Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <returns>ActionResponse</returns>
        public ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact(int appId, SyncContactsRequest syncContactsRequest)
        {
            HubSpot.NET.Client.ApiResponse<ActionResponse> localVarResponse = PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo(appId, syncContactsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import contacts Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <returns>ApiResponse of ActionResponse</returns>
        public HubSpot.NET.Client.ApiResponse<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo(int appId, SyncContactsRequest syncContactsRequest)
        {
            // verify the required parameter 'syncContactsRequest' is set
            if (syncContactsRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'syncContactsRequest' when calling SyncApi->PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact");
            }

            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.NET.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = syncContactsRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ActionResponse>("/crm/v3/extensions/accounting/sync/{appId}/contacts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import contacts Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ActionResponse</returns>
        public async System.Threading.Tasks.Task<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactAsync(int appId, SyncContactsRequest syncContactsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<ActionResponse> localVarResponse = await PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfoAsync(appId, syncContactsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import contacts Imports contacts&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncContactsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<ActionResponse>> PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfoAsync(int appId, SyncContactsRequest syncContactsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'syncContactsRequest' is set
            if (syncContactsRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'syncContactsRequest' when calling SyncApi->PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact");
            }


            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.NET.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = syncContactsRequest;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ActionResponse>("/crm/v3/extensions/accounting/sync/{appId}/contacts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import products Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <returns>ActionResponse</returns>
        public ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct(int appId, SyncProductsRequest syncProductsRequest)
        {
            HubSpot.NET.Client.ApiResponse<ActionResponse> localVarResponse = PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo(appId, syncProductsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import products Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <returns>ApiResponse of ActionResponse</returns>
        public HubSpot.NET.Client.ApiResponse<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo(int appId, SyncProductsRequest syncProductsRequest)
        {
            // verify the required parameter 'syncProductsRequest' is set
            if (syncProductsRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'syncProductsRequest' when calling SyncApi->PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct");
            }

            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.NET.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = syncProductsRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ActionResponse>("/crm/v3/extensions/accounting/sync/{appId}/products", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import products Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ActionResponse</returns>
        public async System.Threading.Tasks.Task<ActionResponse> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductAsync(int appId, SyncProductsRequest syncProductsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<ActionResponse> localVarResponse = await PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfoAsync(appId, syncProductsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import products Imports products&#39; properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="syncProductsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<ActionResponse>> PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfoAsync(int appId, SyncProductsRequest syncProductsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'syncProductsRequest' is set
            if (syncProductsRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'syncProductsRequest' when calling SyncApi->PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct");
            }


            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.NET.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = syncProductsRequest;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ActionResponse>("/crm/v3/extensions/accounting/sync/{appId}/products", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
