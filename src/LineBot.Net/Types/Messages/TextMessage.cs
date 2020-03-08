using LineBot.Net.Types.Abstractions;
using LineBot.Net.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types.Messages
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TextMessage : IMessage
    {
        [JsonProperty(Required = Required.Always)]
        public MessageType Type { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Text { get; set; }

    }
}