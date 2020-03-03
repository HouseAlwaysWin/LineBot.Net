using System.Collections.Generic;
using System.Net.Http;
using LineBot.Net.Types;
using LineBot.Net.Types.Abstractions;

namespace LineBot.Net.Requests.Abstractions {
    public class ReplyMessageRequest : RequestBase {

        public string ReplyToken { get; set; }
        public List<IMessage> Messages { get; set; }
        public bool NotificationDisabled { get; set; }

        public ReplyMessageRequest (string replyToken, List<IMessage> messages) : base ("reply") {
            ReplyToken = replyToken;
            Messages = messages;
        }
    }
}