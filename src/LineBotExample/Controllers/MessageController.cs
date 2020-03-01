using System.Threading.Tasks;
using LineBot.Net;
using LineBot.Net.Types;
using Microsoft.AspNetCore.Mvc;

namespace LineBotExample.Controllers
{
    public class MessageController : ControllerBase
    {
        private ILineBotClient _lineBotClinet;

        public MessageController(ILineBotClient lineBotClient)
        {
            _lineBotClinet = lineBotClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WebhookEventObject update)
        {
            return Ok();
        }
    }
}