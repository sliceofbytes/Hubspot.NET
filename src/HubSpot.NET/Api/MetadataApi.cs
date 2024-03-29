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
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the metadata for a file
        /// </summary>
        /// <remarks>
        /// Gets the metadata object for the file at the specified path in the specified environment.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <returns>AssetFileMetadata</returns>
        AssetFileMetadata GetCmsV3SourceCodeEnvironmentMetadataPath(string environment, string path);

        /// <summary>
        /// Get the metadata for a file
        /// </summary>
        /// <remarks>
        /// Gets the metadata object for the file at the specified path in the specified environment.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <returns>ApiResponse of AssetFileMetadata</returns>
        ApiResponse<AssetFileMetadata> GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfo(string environment, string path);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the metadata for a file
        /// </summary>
        /// <remarks>
        /// Gets the metadata object for the file at the specified path in the specified environment.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetFileMetadata</returns>
        System.Threading.Tasks.Task<AssetFileMetadata> GetCmsV3SourceCodeEnvironmentMetadataPathAsync(string environment, string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the metadata for a file
        /// </summary>
        /// <remarks>
        /// Gets the metadata object for the file at the specified path in the specified environment.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetFileMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetFileMetadata>> GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfoAsync(string environment, string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApi : IMetadataApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetadataApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// Get the metadata for a file Gets the metadata object for the file at the specified path in the specified environment.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <returns>AssetFileMetadata</returns>
        public AssetFileMetadata GetCmsV3SourceCodeEnvironmentMetadataPath(string environment, string path)
        {
            HubSpot.NET.Client.ApiResponse<AssetFileMetadata> localVarResponse = GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfo(environment, path);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the metadata for a file Gets the metadata object for the file at the specified path in the specified environment.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <returns>ApiResponse of AssetFileMetadata</returns>
        public HubSpot.NET.Client.ApiResponse<AssetFileMetadata> GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfo(string environment, string path)
        {
            // verify the required parameter 'environment' is set
            if (environment == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'environment' when calling MetadataApi->GetCmsV3SourceCodeEnvironmentMetadataPath");
            }

            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'path' when calling MetadataApi->GetCmsV3SourceCodeEnvironmentMetadataPath");
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

            localVarRequestOptions.PathParameters.Add("environment", HubSpot.NET.Client.ClientUtils.ParameterToString(environment)); // path parameter
            localVarRequestOptions.PathParameters.Add("path", HubSpot.NET.Client.ClientUtils.ParameterToString(path)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetFileMetadata>("/cms/v3/source-code/{environment}/metadata/{path}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCmsV3SourceCodeEnvironmentMetadataPath", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the metadata for a file Gets the metadata object for the file at the specified path in the specified environment.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetFileMetadata</returns>
        public async System.Threading.Tasks.Task<AssetFileMetadata> GetCmsV3SourceCodeEnvironmentMetadataPathAsync(string environment, string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<AssetFileMetadata> localVarResponse = await GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfoAsync(environment, path, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the metadata for a file Gets the metadata object for the file at the specified path in the specified environment.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="environment">The environment of the file (\&quot;draft\&quot; or \&quot;published\&quot;).</param>
        /// <param name="path">The file system location of the file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetFileMetadata)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<AssetFileMetadata>> GetCmsV3SourceCodeEnvironmentMetadataPathWithHttpInfoAsync(string environment, string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'environment' is set
            if (environment == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'environment' when calling MetadataApi->GetCmsV3SourceCodeEnvironmentMetadataPath");
            }

            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'path' when calling MetadataApi->GetCmsV3SourceCodeEnvironmentMetadataPath");
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

            localVarRequestOptions.PathParameters.Add("environment", HubSpot.NET.Client.ClientUtils.ParameterToString(environment)); // path parameter
            localVarRequestOptions.PathParameters.Add("path", HubSpot.NET.Client.ClientUtils.ParameterToString(path)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetFileMetadata>("/cms/v3/source-code/{environment}/metadata/{path}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCmsV3SourceCodeEnvironmentMetadataPath", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
