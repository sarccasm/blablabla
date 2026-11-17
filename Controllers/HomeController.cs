using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Models;
using OrderSystem.Services;

namespace OrderSystem.Controllers;

public class HomeController : Controller
{
    private readonly ITimeService _timeService;

    public HomeController(ITimeService timeService)
    {
        _timeService = timeService;
    }

    public IActionResult Index()
    {
        return View(new HomeViewModel("Вітаємо в OrderSystem!", _timeService.GetCurrentTime()));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
