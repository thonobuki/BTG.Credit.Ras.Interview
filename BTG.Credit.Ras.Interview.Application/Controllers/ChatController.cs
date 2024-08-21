using BTG.Credit.Ras.Interview.Application.Model;
using BTG.Credit.Ras.Interview.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private readonly IMessageChatService _messageChatService;

        public ChatController(IMessageChatService messageChatService)
        {
            _messageChatService = messageChatService;
        }


        [HttpPost("send")]
        public IActionResult Send(MessageChatModel message)
        {
            _messageChatService.Send(message);

            var msgs = _messageChatService.GetMsgs<MessageChatModel>();

            return Ok();
        }

        [HttpGet("get/all")]
        public IActionResult GetAll()
        {

            var msgs = _messageChatService.GetMsgs<MessageChatModel>();

            if (!msgs.Any())
            {
                return NotFound("Não foram encontradas mensagens");
            }

            return Ok(msgs);
        }
    }
}
