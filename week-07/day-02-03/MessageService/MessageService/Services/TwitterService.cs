using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageService.Services
{
    public class TwitterService : IMessageService
    {
        public bool isEnabled { get; set; }
        public void Send(string message)
        {
            Console.WriteLine("Posting a tweet: " + message);
        }
    }
}
