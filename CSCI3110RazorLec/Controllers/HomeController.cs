using CSCI3110RazorLec.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSCI3110RazorLec.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["SomeValue1"] = "Used ViewData in the controller";
        ViewBag.SomeValue2 = "Used ViewBag in the controller";

        return View();
    }

    public IActionResult CreatePerson()
    {
        return View();
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