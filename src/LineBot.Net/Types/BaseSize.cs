using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BaseSize
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Width { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Height { get; set; }
    }
}