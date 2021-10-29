using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MessageService.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        private IConfiguration Config;
        public MessageProcessor MessageProcessor { get; set; }
        
        public MessageController(MessageProcessor processor, IConfiguration configuration)
        {
            Config = configuration;
            MessageProcessor = processor;
            
        }
        [HttpGet]
        public IActionResult MessageSubmit()
        {

            return View();
        }
        [HttpPost("send")]
        public void SendMessage(string Message)
        {
            MessageProcessor.MessageServices[0].isEnabled = bool.Parse(Config.GetSection("EmailEnabled").Value);
            MessageProcessor.MessageServices[1].isEnabled = bool.Parse(Config.GetSection("TwitterEnabled").Value);
            MessageProcessor.PropagateMessage(Message);
        }
    }
}
