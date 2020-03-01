using System.Collections.Generic;
using LineBot.Net.Types.Enums;

namespace LineBot.Net.Types.Abstractions
{
    public class MessageObject
    {
        public virtual QuickReply QuickReply { get; set; }
        public virtual string Type { get; set; }
        public virtual string Text { get; set; }
        public virtual string PackageId { get; set; }
        public virtual string StickerId { get; set; }
        public virtual string OriginalContentUrl { get; set; }
        public virtual string PreviewImageUrl { get; set; }
        public virtual long Duration { get; set; }
        public virtual string Title { get; set; }
        public virtual string Address { get; set; }
        public virtual decimal Latitude { get; set; }
        public virtual decimal Longitude { get; set; }
        public virtual string BaseUrl { get; set; }
        public virtual string AltText { get; set; }
        public virtual BaseSize BaseSize { get; set; }
        public virtual Video Video { get; set; }
        public virtual List<Action> Actions { get; set; }

    }
}