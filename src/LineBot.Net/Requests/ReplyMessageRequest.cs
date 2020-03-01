using System.Collections.Generic;
using System.Net.Http;
using LineBot.Net.Types;
using LineBot.Net.Types.Abstractions;

namespace LineBot.Net.Requests.Abstractions
{
    public class ReplyMessageRequest : RequestBase<bool>
    {

        public string ReplyToken { get; set; }
        public List<MessageObject> Messages { get; set; }
        public bool NotificationDisabled { get; set; }

        public ReplyMessageRequest(string replyToken, List<MessageObject> messages) : base("reply")
        {
            ReplyToken = replyToken;
            Messages = messages;
        }
    }
}