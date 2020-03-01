using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Video
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OriginalContentUrl { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PreviewImageUrl { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Area Area { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExternalLink ExternalLink { get; set; }

    }
}