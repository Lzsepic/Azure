using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : ControllerBase
{

    [HttpGet]
    public ActionResult<string> HelloWorld()
    {
        var name = "Tony";
        return $"Hello world {name}";
    }
}