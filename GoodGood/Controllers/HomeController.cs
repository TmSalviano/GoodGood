using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoodGood.Models;
using GoodGood.Data;
using Microsoft.EntityFrameworkCore;

namespace GoodGood.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ComidaDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger, ComidaDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
