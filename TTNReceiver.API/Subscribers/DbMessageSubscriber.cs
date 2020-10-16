using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTNReceiver.API.Controllers;

namespace TTNReceiver.API.Subscribers
{
    public class DbMessageSubscriber
    {
        public void MessageHandler(object sender, MessageReceivedEventArgs message)
        {
            Console.WriteLine("Database received message {0}", message.Message.payload_raw);
        }
    }
}