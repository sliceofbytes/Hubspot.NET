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
    public interface IPipelineAuditsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return an audit of all changes to the pipeline
        /// </summary>
        /// <remarks>
        /// Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <returns>CollectionResponsePublicAuditInfoNoPaging</returns>
        CollectionResponsePublicAuditInfoNoPaging GetCrmV3PipelinesObjectTypePipelineIdAudit(string objectType, string pipelineId);

        /// <summary>
        /// Return an audit of all changes to the pipeline
        /// </summary>
        /// <remarks>
        /// Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <returns>ApiResponse of CollectionResponsePublicAuditInfoNoPaging</returns>
        ApiResponse<CollectionResponsePublicAuditInfoNoPaging> GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfo(string objectType, string pipelineId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPipelineAuditsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Return an audit of all changes to the pipeline
        /// </summary>
        /// <remarks>
        /// Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicAuditInfoNoPaging</returns>
        System.Threading.Tasks.Task<CollectionResponsePublicAuditInfoNoPaging> GetCrmV3PipelinesObjectTypePipelineIdAuditAsync(string objectType, string pipelineId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Return an audit of all changes to the pipeline
        /// </summary>
        /// <remarks>
        /// Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicAuditInfoNoPaging)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionResponsePublicAuditInfoNoPaging>> GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfoAsync(string objectType, string pipelineId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPipelineAuditsApi : IPipelineAuditsApiSync, IPipelineAuditsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PipelineAuditsApi : IPipelineAuditsApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineAuditsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PipelineAuditsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineAuditsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PipelineAuditsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PipelineAuditsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PipelineAuditsApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PipelineAuditsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PipelineAuditsApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// Return an audit of all changes to the pipeline Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <returns>CollectionResponsePublicAuditInfoNoPaging</returns>
        public CollectionResponsePublicAuditInfoNoPaging GetCrmV3PipelinesObjectTypePipelineIdAudit(string objectType, string pipelineId)
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAuditInfoNoPaging> localVarResponse = GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfo(objectType, pipelineId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return an audit of all changes to the pipeline Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <returns>ApiResponse of CollectionResponsePublicAuditInfoNoPaging</returns>
        public HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAuditInfoNoPaging> GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfo(string objectType, string pipelineId)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'objectType' when calling PipelineAuditsApi->GetCrmV3PipelinesObjectTypePipelineIdAudit");
            }

            // verify the required parameter 'pipelineId' is set
            if (pipelineId == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'pipelineId' when calling PipelineAuditsApi->GetCrmV3PipelinesObjectTypePipelineIdAudit");
            }

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

            localVarRequestOptions.PathParameters.Add("objectType", HubSpot.NET.Client.ClientUtils.ParameterToString(objectType)); // path parameter
            localVarRequestOptions.PathParameters.Add("pipelineId", HubSpot.NET.Client.ClientUtils.ParameterToString(pipelineId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionResponsePublicAuditInfoNoPaging>("/crm/v3/pipelines/{objectType}/{pipelineId}/audit", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3PipelinesObjectTypePipelineIdAudit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return an audit of all changes to the pipeline Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicAuditInfoNoPaging</returns>
        public async System.Threading.Tasks.Task<CollectionResponsePublicAuditInfoNoPaging> GetCrmV3PipelinesObjectTypePipelineIdAuditAsync(string objectType, string pipelineId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAuditInfoNoPaging> localVarResponse = await GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfoAsync(objectType, pipelineId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return an audit of all changes to the pipeline Return a reverse chronological list of all mutations that have occurred on the pipeline identified by &#x60;{pipelineId}&#x60;.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicAuditInfoNoPaging)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAuditInfoNoPaging>> GetCrmV3PipelinesObjectTypePipelineIdAuditWithHttpInfoAsync(string objectType, string pipelineId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'objectType' when calling PipelineAuditsApi->GetCrmV3PipelinesObjectTypePipelineIdAudit");
            }

            // verify the required parameter 'pipelineId' is set
            if (pipelineId == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'pipelineId' when calling PipelineAuditsApi->GetCrmV3PipelinesObjectTypePipelineIdAudit");
            }


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

            localVarRequestOptions.PathParameters.Add("objectType", HubSpot.NET.Client.ClientUtils.ParameterToString(objectType)); // path parameter
            localVarRequestOptions.PathParameters.Add("pipelineId", HubSpot.NET.Client.ClientUtils.ParameterToString(pipelineId)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionResponsePublicAuditInfoNoPaging>("/crm/v3/pipelines/{objectType}/{pipelineId}/audit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3PipelinesObjectTypePipelineIdAudit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}