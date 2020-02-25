using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using LineBot.Net.Requests.Abstractions;
using LineBot.Net.Types;
using Newtonsoft.Json;

namespace LineBot.Net {
    public class LineBotClient {

        private const string _baseRequestUrl = "";
        private readonly HttpClient _httpClient;

        public LineBotClient (HttpClient httpcClient = null) {
            _httpClient = httpcClient ?? new HttpClient ();
        }

        #region Helpers
        public async Task<TResponse> MakeRequestAsync<TResponse> (
            IRequest<TResponse> request,
            CancellationToken cancellationToken = default) {
            string url = _baseRequestUrl + request.MethodName;

            var httpRequest = new HttpRequestMessage (request.Method, url) {
                Content = request.ToHttpContent ()
            };

            HttpResponseMessage httpResponse = null;

            try {
                httpResponse = await _httpClient.SendAsync (httpRequest, cancellationToken)
                    .ConfigureAwait (false);
            } catch (TaskCanceledException ex) {

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

            }

            return apiResponse.Result;

        }
        #endregion

    }
}