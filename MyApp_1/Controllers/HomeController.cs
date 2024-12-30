using Microsoft.AspNetCore.Mvc;

namespace MyApp_1.Controllers;

// [RoutePrefix("api/Home")] // matches first part of route. Later Route attributes get this prepended to them
// [Route("~/Home/Index")] // ~ means ignore prior prefixes
// [Route("Home/Index/{id:int:min(1)}")] // route constraint. In this case , constrains id to be an integer that is >= 1
// [Route("api/cars/{id?}, Name="GetCarById")] // Named route. Also ? means optional.
// 



[Route("")]
[Route("Home")]
// [Route("[Controller]/[Action]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    [HttpGet("Index")]
    public IActionResult Index()
    {
        return View();
    }




    // [HttpGet("")]
    // [HttpGet("Index")]
    // public String Index()
    // {
    //     return $"Hello: {_count++}";
    // }
    // static int _count = 0;
}