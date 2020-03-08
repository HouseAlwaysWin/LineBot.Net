using System;
using System.Threading.Tasks;
using LineBot.Net;
using LineBot.Net.Types;
using LineBot.Net.Types.Enums;
using LineBot.Net.Types.Messages;
using Microsoft.AspNetCore.Mvc;

namespace LineBotExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private ILineBotClient _lineBotClinet;

        public MessageController()
        {
            _lineBotClinet = new LineBotClient("RvSksS+laWnhuLNrsNlBN5ptY4D1nufOOd1Nkd3MAzim/pNg3wUyYtQpHFpMrymBUL0+R5z/uH30/+tmbn9I2W6f6n52mq58ilT3eYzWQsVWPGdZrhey9JfU5WToTtLrMC8re+QqqnrYnseg2XXxBAdB04t89/1O/w1cDnyilFU=");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WebhookEventObject messageData)
        {
            try
            {
                foreach (var msg in messageData.Events)
                {
                    if (msg.Type == "message")
                    {
                        switch (msg.Message.Type)
                        {
                            case "text":
                                await _lineBotClinet.ReplyTextMessage(msg.ReplyToken, new TextMessage { Type = MessageType.Text, Text = "this is  text message" }, false);
                                break;
                            case "image":
                                await _lineBotClinet.ReplyTextMessage(msg.ReplyToken, new TextMessage { Type = MessageType.Text, Text = "this is image message" }, false);
                                break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}