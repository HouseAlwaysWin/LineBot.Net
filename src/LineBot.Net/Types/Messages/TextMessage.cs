using LineBot.Net.Types.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types.Messages {
    [JsonObject (MemberSerialization.OptIn, NamingStrategyType = typeof (SnakeCaseNamingStrategy))]
    public class TextMessage : IMessage {
        [JsonProperty (Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty (Required = Required.Always)]
        public string Text { get; set; }

    }
}