using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Javacream.BooksWarehouse.Web
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {

        [HttpGet] 
        public string ping(){
            return "pong";
        }
        [HttpGet("{message}")] 
        public string echo(string message){
            return "Greetings " + message;
        }
    }
}