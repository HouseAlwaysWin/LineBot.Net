using System;
using System.Threading.Tasks;
using LineBot.Net;
using LineBot.Net.Types;
using LineBot.Net.Types.Messages;
using Microsoft.AspNetCore.Mvc;

namespace LineBotExample.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class MessageController : ControllerBase {
        private ILineBotClient _lineBotClinet;

        public MessageController () {
            _lineBotClinet = new LineBotClient ("RvSksS+laWnhuLNrsNlBN5ptY4D1nufOOd1Nkd3MAzim/pNg3wUyYtQpHFpMrymBUL0+R5z/uH30/+tmbn9I2W6f6n52mq58ilT3eYzWQsVWPGdZrhey9JfU5WToTtLrMC8re+QqqnrYnseg2XXxBAdB04t89/1O/w1cDnyilFU=");
        }

        [HttpPost]
        public async Task<IActionResult> Post ([FromBody] WebhookEventObject messageData) {
            try {
                foreach (var msg in messageData.Events) {
                    switch (msg.Type) {
                        case "message":
                            await _lineBotClinet.ReplyTextMessage (msg.ReplyToken, new TextMessage { Type = "text", Text = "reply text" }, false);
                            break;
                        default:
                            await _lineBotClinet.ReplyTextMessage (msg.ReplyToken, new TextMessage { Type = "text", Text = "reply default" }, false);
                            break;
                    }
                }
            } catch (Exception ex) {
                return BadRequest (ex);
            }
            return Ok ();
        }
    }
}