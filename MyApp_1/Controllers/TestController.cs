using Microsoft.AspNetCore.Mvc;

namespace MyApp_1.Controllers;

public class TestController: Controller
{
    public ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}