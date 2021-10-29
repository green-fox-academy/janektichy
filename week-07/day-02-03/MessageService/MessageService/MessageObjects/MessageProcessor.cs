using MessageService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageService
{
    public class MessageProcessor
    {
        public List<IMessageService> MessageServices { get; set; }
        public MessageProcessor(IEnumerable<IMessageService> service)
        {
            MessageServices = service.ToList();
        }
        public void PropagateMessage(string message)
        {
            foreach (var item in MessageServices)
            {
                if (item.isEnabled)
                {
                    item.Send(message);
                }
            }
        }
    }
}
