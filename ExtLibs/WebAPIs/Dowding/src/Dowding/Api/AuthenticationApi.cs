/* 
 * Dowding HTTP REST API
 *
 * The Dowding HTTP REST API allows you to add and retrieve contact data from Dowding as well as perform other peripheral functions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Dowding.Client;
using Dowding.Model;

namespace Dowding.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>AuthToken</returns>
        AuthToken AuthenticationLoginPost (LoginDto loginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>ApiResponse of AuthToken</returns>
        ApiResponse<AuthToken> AuthenticationLoginPostWithHttpInfo (LoginDto loginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>AuthToken</returns>
        AuthToken AuthenticationRefreshPost (EmptyObject emptyObject);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>ApiResponse of AuthToken</returns>
        ApiResponse<AuthToken> AuthenticationRefreshPostWithHttpInfo (EmptyObject emptyObject);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>Task of AuthToken</returns>
        System.Threading.Tasks.Task<AuthToken> AuthenticationLoginPostAsync (LoginDto loginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>Task of ApiResponse (AuthToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthToken>> AuthenticationLoginPostAsyncWithHttpInfo (LoginDto loginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>Task of AuthToken</returns>
        System.Threading.Tasks.Task<AuthToken> AuthenticationRefreshPostAsync (EmptyObject emptyObject);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>Task of ApiResponse (AuthToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthToken>> AuthenticationRefreshPostAsyncWithHttpInfo (EmptyObject emptyObject);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private Dowding.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Dowding.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Dowding.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dowding.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>AuthToken</returns>
        public AuthToken AuthenticationLoginPost (LoginDto loginDto)
        {
             ApiResponse<AuthToken> localVarResponse = AuthenticationLoginPostWithHttpInfo(loginDto);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>ApiResponse of AuthToken</returns>
        public ApiResponse< AuthToken > AuthenticationLoginPostWithHttpInfo (LoginDto loginDto)
        {
            // verify the required parameter 'loginDto' is set
            if (loginDto == null)
                throw new ApiException(400, "Missing required parameter 'loginDto' when calling AuthenticationApi->AuthenticationLoginPost");

            var localVarPath = "/authentication/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (loginDto != null && loginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthToken)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>Task of AuthToken</returns>
        public async System.Threading.Tasks.Task<AuthToken> AuthenticationLoginPostAsync (LoginDto loginDto)
        {
             ApiResponse<AuthToken> localVarResponse = await AuthenticationLoginPostAsyncWithHttpInfo(loginDto);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginDto"></param>
        /// <returns>Task of ApiResponse (AuthToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthToken>> AuthenticationLoginPostAsyncWithHttpInfo (LoginDto loginDto)
        {
            // verify the required parameter 'loginDto' is set
            if (loginDto == null)
                throw new ApiException(400, "Missing required parameter 'loginDto' when calling AuthenticationApi->AuthenticationLoginPost");

            var localVarPath = "/authentication/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (loginDto != null && loginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthToken)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>AuthToken</returns>
        public AuthToken AuthenticationRefreshPost (EmptyObject emptyObject)
        {
             ApiResponse<AuthToken> localVarResponse = AuthenticationRefreshPostWithHttpInfo(emptyObject);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>ApiResponse of AuthToken</returns>
        public ApiResponse< AuthToken > AuthenticationRefreshPostWithHttpInfo (EmptyObject emptyObject)
        {
            // verify the required parameter 'emptyObject' is set
            if (emptyObject == null)
                throw new ApiException(400, "Missing required parameter 'emptyObject' when calling AuthenticationApi->AuthenticationRefreshPost");

            var localVarPath = "/authentication/refresh";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emptyObject != null && emptyObject.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(emptyObject); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emptyObject; // byte array
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationRefreshPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthToken)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>Task of AuthToken</returns>
        public async System.Threading.Tasks.Task<AuthToken> AuthenticationRefreshPostAsync (EmptyObject emptyObject)
        {
             ApiResponse<AuthToken> localVarResponse = await AuthenticationRefreshPostAsyncWithHttpInfo(emptyObject);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emptyObject"></param>
        /// <returns>Task of ApiResponse (AuthToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthToken>> AuthenticationRefreshPostAsyncWithHttpInfo (EmptyObject emptyObject)
        {
            // verify the required parameter 'emptyObject' is set
            if (emptyObject == null)
                throw new ApiException(400, "Missing required parameter 'emptyObject' when calling AuthenticationApi->AuthenticationRefreshPost");

            var localVarPath = "/authentication/refresh";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emptyObject != null && emptyObject.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(emptyObject); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emptyObject; // byte array
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationRefreshPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthToken)));
            
        }

    }
}
