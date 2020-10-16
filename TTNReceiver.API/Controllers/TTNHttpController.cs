using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TTNReceiver.API.Subscribers;
using TTNReceiver.Data;

namespace TTNReceiver.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TTNHttpController : ControllerBase
    {
        private readonly TTNReceiverDataContext _data;

        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived;

        public TTNHttpController(TTNReceiverDataContext data)
        {
            _data = data;
            DbMessageSubscriber sub = new DbMessageSubscriber();
            OnMessageReceived += sub.MessageHandler;
        }

        [HttpPost]
        public void ReceiveMessage([FromBody] object message)
        {
            //Check if device is registered and if not, add it.

            //Save rawdata with deviceId

            TTNHttpDTO dinges = JsonConvert.DeserializeObject<TTNHttpDTO>(message.ToString());
            MessageReceivedEventArgs args = new MessageReceivedEventArgs(dinges);
            OnMessageReceived(this, args);
            Console.WriteLine(dinges.payload_raw);

            var rawData = Mapper.Map(dinges);

            _data.Add(rawData);
            _data.SaveChanges();
        }
    }

    public class MessageReceivedEventArgs : EventArgs
    {
        public MessageReceivedEventArgs(TTNHttpDTO message)
        {
            Message = message;
        }

        public TTNHttpDTO Message { get; }
    }
}