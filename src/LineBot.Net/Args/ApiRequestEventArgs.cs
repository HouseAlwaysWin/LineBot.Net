using System;
using System.Net.Http;

namespace LineBot.Net.Args {
    public class ApiRequestEventArgs : EventArgs {
        /// <summary>
        /// Bot API method name
        /// </summary>
        public string MethodName { get; internal set; }

        /// <summary>
        /// HTTP content of the request message
        /// </summary>
        public HttpContent HttpContent { get; internal set; }
    }
}