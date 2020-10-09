using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TTNReceiver.Data;

namespace TTNReceiver.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TTNHttpController : ControllerBase
    {
        private readonly TTNReceiverDataContext _data;

        public TTNHttpController(TTNReceiverDataContext data)
        {
            _data = data;
        }

        [HttpPost]
        public void ReceiveMessage([FromBody] object message)//TTNHttpDTO
        {
            //Check if device is registered and if not, add it.

            //Save rawdata with deviceId

            TTNHttpDTO dinges = JsonConvert.DeserializeObject<TTNHttpDTO>(message.ToString());

            Console.WriteLine(dinges.payload_raw);

            var rawData = Mapper.Map(dinges);

            _data.Add(rawData);
            _data.SaveChanges();
        }
    }
}