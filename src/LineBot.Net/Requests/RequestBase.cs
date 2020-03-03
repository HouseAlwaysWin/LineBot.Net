using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LineBot.Net.Requests.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Requests {
    [JsonObject (MemberSerialization.OptIn, NamingStrategyType = typeof (SnakeCaseNamingStrategy))]
    public class RequestBase<TResponse> : IRequest<TResponse> {
        [JsonIgnore]
        public HttpMethod Method { get; }

        [JsonIgnore]
        public string MethodName { get; protected set; }
        protected RequestBase (string methodName) : this (methodName, HttpMethod.Post) { }

        /// <summary>
        /// Initializes an instance of request
        /// </summary>
        /// <param name="methodName">Bot API method</param>
        /// <param name="method">HTTP method to use</param>
        protected RequestBase (string methodName, HttpMethod method) {
            MethodName = methodName;
            Method = method;
        }

        /// <summary>
        /// Generate content of HTTP message
        /// </summary>
        /// <returns>Content of HTTP request</returns>
        public virtual HttpContent ToHttpContent () {
            string payload = JsonConvert.SerializeObject (this, Formatting.Indented,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver () });
            var content = new StringContent (payload, Encoding.UTF8, "application/json");
            return content;
        }

    }

    public class RequestBase : IRequest {
        [JsonIgnore]
        public HttpMethod Method { get; }

        [JsonIgnore]
        public string MethodName { get; protected set; }
        protected RequestBase (string methodName) : this (methodName, HttpMethod.Post) { }

        /// <summary>
        /// Initializes an instance of request
        /// </summary>
        /// <param name="methodName">Bot API method</param>
        /// <param name="method">HTTP method to use</param>
        protected RequestBase (string methodName, HttpMethod method) {
            MethodName = methodName;
            Method = method;
        }

        /// <summary>
        /// Generate content of HTTP message
        /// </summary>
        /// <returns>Content of HTTP request</returns>
        public virtual HttpContent ToHttpContent () {
            string payload = JsonConvert.SerializeObject (this, Formatting.Indented,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver () });
            var content = new StringContent (payload, Encoding.UTF8, "application/json");
            return content;
        }

    }
}