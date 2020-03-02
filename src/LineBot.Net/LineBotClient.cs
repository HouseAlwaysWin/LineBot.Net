using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using LineBot.Net.Args;
using LineBot.Net.Exceptions;
using LineBot.Net.Requests.Abstractions;
using LineBot.Net.Types;
using LineBot.Net.Types.Abstractions;
using LineBot.Net.Types.Messages;
using Newtonsoft.Json;

namespace LineBot.Net {
    public class LineBotClient : ILineBotClient {

        private const string _baseMessageRequestUrl = "https://api.line.me/v2/bot/message/";
        private readonly HttpClient _httpClient;
        private readonly string _channelAccessToken;
        /// <summary>
        /// Occurs before sending a request to API
        /// </summary>
        public event EventHandler<ApiRequestEventArgs> MakingApiRequest;

        public LineBotClient (string channelAccessToken, HttpClient httpcClient = null) {
            _httpClient = httpcClient ?? new HttpClient ();

            _channelAccessToken = channelAccessToken ??
                throw new ArgumentNullException (nameof (channelAccessToken));

            _httpClient.DefaultRequestHeaders.Add ("Authorization", "Bearer " + channelAccessToken);
        }

        #region Helpers
        public async Task<TResponse> MakeRequestAsync<TResponse> (
            IRequest<TResponse> request,
            CancellationToken cancellationToken = default) {
            string url = _baseMessageRequestUrl + request.MethodName;

            var httpRequest = new HttpRequestMessage (request.Method, url) {
                Content = request.ToHttpContent (),
            };

            var reqDataArgs = new ApiRequestEventArgs {
                MethodName = request.MethodName,
                HttpContent = httpRequest.Content,
            };
            MakingApiRequest?.Invoke (this, reqDataArgs);

            HttpResponseMessage httpResponse = null;

            try {
                httpResponse = await _httpClient.SendAsync (httpRequest, cancellationToken)
                    .ConfigureAwait (false);
            } catch (TaskCanceledException ex) {
                if (cancellationToken.IsCancellationRequested)
                    throw;
                throw new ApiRequestException ("Request timed out", 408, ex);
            }

            string responseJson =
                await httpResponse.Content.ReadAsStringAsync ().ConfigureAwait (false);

            var apiResponse =
                JsonConvert.DeserializeObject<ApiResponse<TResponse>> (responseJson) ??
                new ApiResponse<TResponse> {
                    Ok = false,
                    Description = "No response received"
                };

            if (!apiResponse.Ok) {
                throw new ApiRequestException (JsonConvert.SerializeObject (apiResponse), 400);
            }

            return apiResponse.Result;

        }
        #endregion

        public async Task ReplyTextMessage (
            string replyToken,
            TextMessage messages,
            bool notificationDisabled,
            CancellationToken cancellationToken = default) {
            var messageObjs = new List<IMessage> ();
            messageObjs.Add (messages);
            await MakeRequestAsync (new ReplyMessageRequest (replyToken, messageObjs), cancellationToken);
        }

    }
}