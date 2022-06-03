using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EchoController : ControllerBase{
[HttpGet]
public string ping(){
	return "pong";
}
}
