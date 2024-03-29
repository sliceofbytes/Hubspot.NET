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
    public interface ITypesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List association types
        /// </summary>
        /// <remarks>
        /// List all the valid association types available between two object types
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <returns>CollectionResponsePublicAssociationDefiniton</returns>
        CollectionResponsePublicAssociationDefiniton GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll(string fromObjectType, string toObjectType);

        /// <summary>
        /// List association types
        /// </summary>
        /// <remarks>
        /// List all the valid association types available between two object types
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <returns>ApiResponse of CollectionResponsePublicAssociationDefiniton</returns>
        ApiResponse<CollectionResponsePublicAssociationDefiniton> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo(string fromObjectType, string toObjectType);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITypesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List association types
        /// </summary>
        /// <remarks>
        /// List all the valid association types available between two object types
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicAssociationDefiniton</returns>
        System.Threading.Tasks.Task<CollectionResponsePublicAssociationDefiniton> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllAsync(string fromObjectType, string toObjectType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List association types
        /// </summary>
        /// <remarks>
        /// List all the valid association types available between two object types
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicAssociationDefiniton)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionResponsePublicAssociationDefiniton>> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfoAsync(string fromObjectType, string toObjectType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITypesApi : ITypesApiSync, ITypesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TypesApi : ITypesApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TypesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TypesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TypesApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TypesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TypesApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// List association types List all the valid association types available between two object types
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <returns>CollectionResponsePublicAssociationDefiniton</returns>
        public CollectionResponsePublicAssociationDefiniton GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll(string fromObjectType, string toObjectType)
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAssociationDefiniton> localVarResponse = GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo(fromObjectType, toObjectType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List association types List all the valid association types available between two object types
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <returns>ApiResponse of CollectionResponsePublicAssociationDefiniton</returns>
        public HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAssociationDefiniton> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo(string fromObjectType, string toObjectType)
        {
            // verify the required parameter 'fromObjectType' is set
            if (fromObjectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'fromObjectType' when calling TypesApi->GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll");
            }

            // verify the required parameter 'toObjectType' is set
            if (toObjectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'toObjectType' when calling TypesApi->GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll");
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

            localVarRequestOptions.PathParameters.Add("fromObjectType", HubSpot.NET.Client.ClientUtils.ParameterToString(fromObjectType)); // path parameter
            localVarRequestOptions.PathParameters.Add("toObjectType", HubSpot.NET.Client.ClientUtils.ParameterToString(toObjectType)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionResponsePublicAssociationDefiniton>("/crm/v3/associations/{fromObjectType}/{toObjectType}/types", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List association types List all the valid association types available between two object types
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponsePublicAssociationDefiniton</returns>
        public async System.Threading.Tasks.Task<CollectionResponsePublicAssociationDefiniton> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllAsync(string fromObjectType, string toObjectType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAssociationDefiniton> localVarResponse = await GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfoAsync(fromObjectType, toObjectType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List association types List all the valid association types available between two object types
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromObjectType"></param>
        /// <param name="toObjectType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponsePublicAssociationDefiniton)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<CollectionResponsePublicAssociationDefiniton>> GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfoAsync(string fromObjectType, string toObjectType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'fromObjectType' is set
            if (fromObjectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'fromObjectType' when calling TypesApi->GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll");
            }

            // verify the required parameter 'toObjectType' is set
            if (toObjectType == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'toObjectType' when calling TypesApi->GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll");
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

            localVarRequestOptions.PathParameters.Add("fromObjectType", HubSpot.NET.Client.ClientUtils.ParameterToString(fromObjectType)); // path parameter
            localVarRequestOptions.PathParameters.Add("toObjectType", HubSpot.NET.Client.ClientUtils.ParameterToString(toObjectType)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionResponsePublicAssociationDefiniton>("/crm/v3/associations/{fromObjectType}/{toObjectType}/types", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
