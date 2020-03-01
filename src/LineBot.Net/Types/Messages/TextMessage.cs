using LineBot.Net.Types.Abstractions;

namespace LineBot.Net.Types.Messages
{
    public class TextMessage : MessageObject
    {
        public override string Type { get; set; }
        public override string Text { get; set; }

    }
}