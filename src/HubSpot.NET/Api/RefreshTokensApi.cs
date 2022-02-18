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
    public interface IRefreshTokensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>Error</returns>
        Error DeleteOauthV1RefreshTokensTokenArchiveRefreshToken(string token);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfo(string token);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>RefreshTokenInfoResponse</returns>
        RefreshTokenInfoResponse GetOauthV1RefreshTokensTokenGetRefreshToken(string token);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>ApiResponse of RefreshTokenInfoResponse</returns>
        ApiResponse<RefreshTokenInfoResponse> GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfo(string token);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRefreshTokensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfoAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefreshTokenInfoResponse</returns>
        System.Threading.Tasks.Task<RefreshTokenInfoResponse> GetOauthV1RefreshTokensTokenGetRefreshTokenAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefreshTokenInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefreshTokenInfoResponse>> GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfoAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRefreshTokensApi : IRefreshTokensApiSync, IRefreshTokensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RefreshTokensApi : IRefreshTokensApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefreshTokensApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefreshTokensApi(string basePath)
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
        /// Initializes a new instance of the <see cref="RefreshTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RefreshTokensApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="RefreshTokensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RefreshTokensApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// <param name="token"></param>
        /// <returns>Error</returns>
        public Error DeleteOauthV1RefreshTokensTokenArchiveRefreshToken(string token)
        {
            HubSpot.NET.Client.ApiResponse<Error> localVarResponse = DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfo(token);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>ApiResponse of Error</returns>
        public HubSpot.NET.Client.ApiResponse<Error> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfo(string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'token' when calling RefreshTokensApi->DeleteOauthV1RefreshTokensTokenArchiveRefreshToken");
            }

            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
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

            localVarRequestOptions.PathParameters.Add("token", HubSpot.NET.Client.ClientUtils.ParameterToString(token)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Error>("/oauth/v1/refresh-tokens/{token}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOauthV1RefreshTokensTokenArchiveRefreshToken", localVarResponse);
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
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<Error> localVarResponse = await DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfoAsync(token, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<Error>> DeleteOauthV1RefreshTokensTokenArchiveRefreshTokenWithHttpInfoAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'token' is set
            if (token == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'token' when calling RefreshTokensApi->DeleteOauthV1RefreshTokensTokenArchiveRefreshToken");
            }


            HubSpot.NET.Client.RequestOptions localVarRequestOptions = new HubSpot.NET.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
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

            localVarRequestOptions.PathParameters.Add("token", HubSpot.NET.Client.ClientUtils.ParameterToString(token)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Error>("/oauth/v1/refresh-tokens/{token}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOauthV1RefreshTokensTokenArchiveRefreshToken", localVarResponse);
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
        /// <param name="token"></param>
        /// <returns>RefreshTokenInfoResponse</returns>
        public RefreshTokenInfoResponse GetOauthV1RefreshTokensTokenGetRefreshToken(string token)
        {
            HubSpot.NET.Client.ApiResponse<RefreshTokenInfoResponse> localVarResponse = GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfo(token);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <returns>ApiResponse of RefreshTokenInfoResponse</returns>
        public HubSpot.NET.Client.ApiResponse<RefreshTokenInfoResponse> GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfo(string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'token' when calling RefreshTokensApi->GetOauthV1RefreshTokensTokenGetRefreshToken");
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

            localVarRequestOptions.PathParameters.Add("token", HubSpot.NET.Client.ClientUtils.ParameterToString(token)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<RefreshTokenInfoResponse>("/oauth/v1/refresh-tokens/{token}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOauthV1RefreshTokensTokenGetRefreshToken", localVarResponse);
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
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefreshTokenInfoResponse</returns>
        public async System.Threading.Tasks.Task<RefreshTokenInfoResponse> GetOauthV1RefreshTokensTokenGetRefreshTokenAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<RefreshTokenInfoResponse> localVarResponse = await GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfoAsync(token, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefreshTokenInfoResponse)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<RefreshTokenInfoResponse>> GetOauthV1RefreshTokensTokenGetRefreshTokenWithHttpInfoAsync(string token, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'token' is set
            if (token == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'token' when calling RefreshTokensApi->GetOauthV1RefreshTokensTokenGetRefreshToken");
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

            localVarRequestOptions.PathParameters.Add("token", HubSpot.NET.Client.ClientUtils.ParameterToString(token)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RefreshTokenInfoResponse>("/oauth/v1/refresh-tokens/{token}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOauthV1RefreshTokensTokenGetRefreshToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
