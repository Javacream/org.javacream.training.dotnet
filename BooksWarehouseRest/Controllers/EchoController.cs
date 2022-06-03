using Microsoft.AspNetCore.Mvc;
using System;
[ApiController]
[Route("[controller]")]
public class EchoController : ControllerBase{
[HttpGet("pong")]
public string ping(){
	return "pong";
}

[HttpGet("echo/{message}")]
public string echo(string message){
    Console.WriteLine("############### " + message);
	return message;
}

}
