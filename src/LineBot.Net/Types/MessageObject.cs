using System.Collections.Generic;
using LineBot.Net.Types.Abstractions;
using LineBot.Net.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LineBot.Net.Types {
    [JsonObject (MemberSerialization.OptIn, NamingStrategyType = typeof (SnakeCaseNamingStrategy))]
    public class MessageObject : IMessage {
        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual QuickReply QuickReply { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Type { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Text { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string PackageId { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string StickerId { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string OriginalContentUrl { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string PreviewImageUrl { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual long Duration { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Title { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Address { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual decimal Latitude { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual decimal Longitude { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string BaseUrl { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string AltText { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual BaseSize BaseSize { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual Video Video { get; set; }

        [JsonProperty (DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual List<Action> Actions { get; set; }

    }
}