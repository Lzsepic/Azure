<<<<<<< HEAD
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
=======
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
>>>>>>> 5fb5752d3bd843f55b9bd6c6ac7a02c3321b4dbc
}