using System.Threading;
using System.Threading.Tasks;
using LineBot.Net.Types.Messages;

namespace LineBot.Net
{
    public interface ILineBotClient
    {
        Task ReplyTextMessage(
                    string replyToken,
                    TextMessage messages,
                    bool notificationDisabled,
                    CancellationToken cancellationToken = default);
    }
}