using Microsoft.AspNetCore.Mvc;

namespace MyApp_1.Controllers;


//[Route("Home")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //[HttpGet("")]
    //[HttpGet("Index")]
    //[HttpGet("Home/Index")]
    public IActionResult Index()
    {
        return View();
    }
}