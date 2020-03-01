using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineBot.Net.Types.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        Text,
        Sticker,
        Image,
        Video,
        Audio,
        Location,
        ImageMap,
        Template,
        Flex,
    }
}