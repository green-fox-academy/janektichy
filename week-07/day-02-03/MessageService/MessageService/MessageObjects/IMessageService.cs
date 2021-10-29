using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageService.Services
{
    public interface IMessageService
    {
        public bool isEnabled { get; set; }
        public void Send(string message);
    }
}
