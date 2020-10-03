using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TTNReceiver.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TTNHttpController : ControllerBase
    {
        public TTNHttpController()
        {
        }

        [HttpPost]
        public void ReceiveMessage([FromBody] object message)//TTNHttpDTO
        {
            TTNHttpDTO dinges = JsonConvert.DeserializeObject<TTNHttpDTO>(message.ToString());
            Console.WriteLine(dinges.payload_raw);
        }
    }
}