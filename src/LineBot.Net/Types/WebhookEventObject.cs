using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class WebhookEventObject
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Destination { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<EventsType> Events { get; set; }
    }
}