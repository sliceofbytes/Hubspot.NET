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
    public interface IStatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get subscription statuses for a contact
        /// </summary>
        /// <remarks>
        /// Returns a list of subscriptions and their status for a given contact.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <returns>PublicSubscriptionStatusesResponse</returns>
        PublicSubscriptionStatusesResponse GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus(string emailAddress);

        /// <summary>
        /// Get subscription statuses for a contact
        /// </summary>
        /// <remarks>
        /// Returns a list of subscriptions and their status for a given contact.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatusesResponse</returns>
        ApiResponse<PublicSubscriptionStatusesResponse> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo(string emailAddress);
        /// <summary>
        /// Subscribe a contact
        /// </summary>
        /// <remarks>
        /// Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>PublicSubscriptionStatus</returns>
        PublicSubscriptionStatus PostCommunicationPreferencesV3SubscribeSubscribe(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest);

        /// <summary>
        /// Subscribe a contact
        /// </summary>
        /// <remarks>
        /// Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatus</returns>
        ApiResponse<PublicSubscriptionStatus> PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest);
        /// <summary>
        /// Unsubscribe a contact
        /// </summary>
        /// <remarks>
        /// Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>PublicSubscriptionStatus</returns>
        PublicSubscriptionStatus PostCommunicationPreferencesV3UnsubscribeUnsubscribe(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest);

        /// <summary>
        /// Unsubscribe a contact
        /// </summary>
        /// <remarks>
        /// Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatus</returns>
        ApiResponse<PublicSubscriptionStatus> PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get subscription statuses for a contact
        /// </summary>
        /// <remarks>
        /// Returns a list of subscriptions and their status for a given contact.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatusesResponse</returns>
        System.Threading.Tasks.Task<PublicSubscriptionStatusesResponse> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusAsync(string emailAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get subscription statuses for a contact
        /// </summary>
        /// <remarks>
        /// Returns a list of subscriptions and their status for a given contact.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatusesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublicSubscriptionStatusesResponse>> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfoAsync(string emailAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Subscribe a contact
        /// </summary>
        /// <remarks>
        /// Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatus</returns>
        System.Threading.Tasks.Task<PublicSubscriptionStatus> PostCommunicationPreferencesV3SubscribeSubscribeAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Subscribe a contact
        /// </summary>
        /// <remarks>
        /// Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublicSubscriptionStatus>> PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfoAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Unsubscribe a contact
        /// </summary>
        /// <remarks>
        /// Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatus</returns>
        System.Threading.Tasks.Task<PublicSubscriptionStatus> PostCommunicationPreferencesV3UnsubscribeUnsubscribeAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Unsubscribe a contact
        /// </summary>
        /// <remarks>
        /// Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </remarks>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublicSubscriptionStatus>> PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfoAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatusApi : IStatusApiSync, IStatusApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatusApi : IStatusApi
    {
        private HubSpot.NET.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusApi(HubSpot.NET.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StatusApi(HubSpot.NET.Client.ISynchronousClient client, HubSpot.NET.Client.IAsynchronousClient asyncClient, HubSpot.NET.Client.IReadableConfiguration configuration)
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
        /// Get subscription statuses for a contact Returns a list of subscriptions and their status for a given contact.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <returns>PublicSubscriptionStatusesResponse</returns>
        public PublicSubscriptionStatusesResponse GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus(string emailAddress)
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatusesResponse> localVarResponse = GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo(emailAddress);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subscription statuses for a contact Returns a list of subscriptions and their status for a given contact.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatusesResponse</returns>
        public HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatusesResponse> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo(string emailAddress)
        {
            // verify the required parameter 'emailAddress' is set
            if (emailAddress == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'emailAddress' when calling StatusApi->GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus");
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

            localVarRequestOptions.PathParameters.Add("emailAddress", HubSpot.NET.Client.ClientUtils.ParameterToString(emailAddress)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<PublicSubscriptionStatusesResponse>("/communication-preferences/v3/status/email/{emailAddress}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get subscription statuses for a contact Returns a list of subscriptions and their status for a given contact.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatusesResponse</returns>
        public async System.Threading.Tasks.Task<PublicSubscriptionStatusesResponse> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusAsync(string emailAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatusesResponse> localVarResponse = await GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfoAsync(emailAddress, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subscription statuses for a contact Returns a list of subscriptions and their status for a given contact.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatusesResponse)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatusesResponse>> GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfoAsync(string emailAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'emailAddress' is set
            if (emailAddress == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'emailAddress' when calling StatusApi->GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus");
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

            localVarRequestOptions.PathParameters.Add("emailAddress", HubSpot.NET.Client.ClientUtils.ParameterToString(emailAddress)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PublicSubscriptionStatusesResponse>("/communication-preferences/v3/status/email/{emailAddress}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Subscribe a contact Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>PublicSubscriptionStatus</returns>
        public PublicSubscriptionStatus PostCommunicationPreferencesV3SubscribeSubscribe(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> localVarResponse = PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo(publicUpdateSubscriptionStatusRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Subscribe a contact Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatus</returns>
        public HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)
        {
            // verify the required parameter 'publicUpdateSubscriptionStatusRequest' is set
            if (publicUpdateSubscriptionStatusRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'publicUpdateSubscriptionStatusRequest' when calling StatusApi->PostCommunicationPreferencesV3SubscribeSubscribe");
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

            localVarRequestOptions.Data = publicUpdateSubscriptionStatusRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<PublicSubscriptionStatus>("/communication-preferences/v3/subscribe", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCommunicationPreferencesV3SubscribeSubscribe", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Subscribe a contact Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatus</returns>
        public async System.Threading.Tasks.Task<PublicSubscriptionStatus> PostCommunicationPreferencesV3SubscribeSubscribeAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> localVarResponse = await PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfoAsync(publicUpdateSubscriptionStatusRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Subscribe a contact Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatus)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus>> PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfoAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'publicUpdateSubscriptionStatusRequest' is set
            if (publicUpdateSubscriptionStatusRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'publicUpdateSubscriptionStatusRequest' when calling StatusApi->PostCommunicationPreferencesV3SubscribeSubscribe");
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

            localVarRequestOptions.Data = publicUpdateSubscriptionStatusRequest;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<PublicSubscriptionStatus>("/communication-preferences/v3/subscribe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCommunicationPreferencesV3SubscribeSubscribe", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unsubscribe a contact Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>PublicSubscriptionStatus</returns>
        public PublicSubscriptionStatus PostCommunicationPreferencesV3UnsubscribeUnsubscribe(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> localVarResponse = PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo(publicUpdateSubscriptionStatusRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unsubscribe a contact Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <returns>ApiResponse of PublicSubscriptionStatus</returns>
        public HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)
        {
            // verify the required parameter 'publicUpdateSubscriptionStatusRequest' is set
            if (publicUpdateSubscriptionStatusRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'publicUpdateSubscriptionStatusRequest' when calling StatusApi->PostCommunicationPreferencesV3UnsubscribeUnsubscribe");
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

            localVarRequestOptions.Data = publicUpdateSubscriptionStatusRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<PublicSubscriptionStatus>("/communication-preferences/v3/unsubscribe", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCommunicationPreferencesV3UnsubscribeUnsubscribe", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unsubscribe a contact Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PublicSubscriptionStatus</returns>
        public async System.Threading.Tasks.Task<PublicSubscriptionStatus> PostCommunicationPreferencesV3UnsubscribeUnsubscribeAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus> localVarResponse = await PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfoAsync(publicUpdateSubscriptionStatusRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unsubscribe a contact Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.
        /// </summary>
        /// <exception cref="HubSpot.NET.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicUpdateSubscriptionStatusRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PublicSubscriptionStatus)</returns>
        public async System.Threading.Tasks.Task<HubSpot.NET.Client.ApiResponse<PublicSubscriptionStatus>> PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfoAsync(PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'publicUpdateSubscriptionStatusRequest' is set
            if (publicUpdateSubscriptionStatusRequest == null)
            {
                throw new HubSpot.NET.Client.ApiException(400, "Missing required parameter 'publicUpdateSubscriptionStatusRequest' when calling StatusApi->PostCommunicationPreferencesV3UnsubscribeUnsubscribe");
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

            localVarRequestOptions.Data = publicUpdateSubscriptionStatusRequest;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<PublicSubscriptionStatus>("/communication-preferences/v3/unsubscribe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCommunicationPreferencesV3UnsubscribeUnsubscribe", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
