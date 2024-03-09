using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName = "Tom",
                LastName = "Lik"
            },
            new Person()
            {
                FirstName = "Kris",
                LastName = "Wik"
            }
        };
        return View(model);
    }

    public IActionResult About()
    {
        var model = new List<Book>()
        {
            new Book()
            {
                Title = "Harry Potter",
                Description = "Adventure book",
                Tags = new List<string>() {"England", "Adventure", "Book"}

            },
            new Book()
            {
                Title = "6 hours",
                Description = "Action book",
                Tags = new List<string>() {"Germany", "Action", "Book"}
            }
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
