using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp_1.Data;
using MyApp_1.Models;

namespace MyApp_1.Controllers;

[Route("Users")]
public class UsersController : Controller
{
    private ILogger<UsersController> _logger;
    private MyApp_1DbContext _context;

    public UsersController(ILogger<UsersController> logger, MyApp_1DbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("")]
    [HttpGet("Index")]
    public IActionResult Index()
    {
        return View();
    }


    [HttpGet("Details/{id:int?}")]
    public IActionResult Details(int? id)
    {
        if(id == null)
            return NotFound("Not Found");
        
        FirstModel? model = _context.FirstModel.FirstOrDefault(user => user.Id == id);
        if(model == null)
            return NotFound($"Not Found (Id: {id})");
        // FirstModel model = _context.FirstModel.First(user => user.Id == id);

        // FirstModel model = _context.FirstModel.First();
        return View(model);

        
    }
}