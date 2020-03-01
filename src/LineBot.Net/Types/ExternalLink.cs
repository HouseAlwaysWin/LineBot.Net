using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ExternalLink
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LinkUri { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Label { get; set; }
    }
}