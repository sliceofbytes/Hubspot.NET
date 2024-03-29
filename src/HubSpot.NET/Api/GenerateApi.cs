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
    public interface IGenerateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate a token
        /// </summary>
        /// <remarks>
        /// Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <returns>IdentificationTokenResponse</returns>
        IdentificationTokenResponse PostVisitorIdentificationV3TokensCreateGenerateToken(IdentificationTokenGenerationRequest identificationTokenGenerationRequest);

        /// <summary>
        /// Generate a token
        /// </summary>
        /// <remarks>
        /// Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <returns>ApiResponse of IdentificationTokenResponse</returns>
        ApiResponse<IdentificationTokenResponse> PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo(IdentificationTokenGenerationRequest identificationTokenGenerationRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGenerateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate a token
        /// </summary>
        /// <remarks>
        /// Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IdentificationTokenResponse</returns>
        System.Threading.Tasks.Task<IdentificationTokenResponse> PostVisitorIdentificationV3TokensCreateGenerateTokenAsync(IdentificationTokenGenerationRequest identificationTokenGenerationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Generate a token
        /// </summary>
        /// <remarks>
        /// Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IdentificationTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IdentificationTokenResponse>> PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfoAsync(IdentificationTokenGenerationRequest identificationTokenGenerationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGenerateApi : IGenerateApiSync, IGenerateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GenerateApi : IGenerateApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GenerateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GenerateApi(string basePath)
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
        /// Initializes a new instance of the <see cref="GenerateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GenerateApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="GenerateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GenerateApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// Generate a token Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <returns>IdentificationTokenResponse</returns>
        public IdentificationTokenResponse PostVisitorIdentificationV3TokensCreateGenerateToken(IdentificationTokenGenerationRequest identificationTokenGenerationRequest)
        {
            HubSpot.NET.Client.ApiResponse<IdentificationTokenResponse> localVarResponse = PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo(identificationTokenGenerationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a token Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <returns>ApiResponse of IdentificationTokenResponse</returns>
        public HubSpot.NET.Client.ApiResponse<IdentificationTokenResponse> PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo(IdentificationTokenGenerationRequest identificationTokenGenerationRequest)
        {
            // verify the required parameter 'identificationTokenGenerationRequest' is set
            if (identificationTokenGenerationRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'identificationTokenGenerationRequest' when calling GenerateApi->PostVisitorIdentificationV3TokensCreateGenerateToken");
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

            localVarRequestOptions.Data = identificationTokenGenerationRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<IdentificationTokenResponse>("/conversations/v3/visitor-identification/tokens/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostVisitorIdentificationV3TokensCreateGenerateToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate a token Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IdentificationTokenResponse</returns>
        public async System.Threading.Tasks.Task<IdentificationTokenResponse> PostVisitorIdentificationV3TokensCreateGenerateTokenAsync(IdentificationTokenGenerationRequest identificationTokenGenerationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<IdentificationTokenResponse> localVarResponse = await PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfoAsync(identificationTokenGenerationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a token Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificationTokenGenerationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IdentificationTokenResponse)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<IdentificationTokenResponse>> PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfoAsync(IdentificationTokenGenerationRequest identificationTokenGenerationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identificationTokenGenerationRequest' is set
            if (identificationTokenGenerationRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'identificationTokenGenerationRequest' when calling GenerateApi->PostVisitorIdentificationV3TokensCreateGenerateToken");
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

            localVarRequestOptions.Data = identificationTokenGenerationRequest;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<IdentificationTokenResponse>("/conversations/v3/visitor-identification/tokens/create", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostVisitorIdentificationV3TokensCreateGenerateToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
