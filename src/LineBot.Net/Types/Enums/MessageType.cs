using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineBot.Net.Types.Enums
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum MessageType
    {
        [EnumMember(Value = "Text")]
        Text,
        [EnumMember(Value = "sticker")]
        Sticker,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "imagemap")]
        ImageMap,
        [EnumMember(Value = "template")]
        Template,
        [EnumMember(Value = "flex")]
        Flex,
    }
}