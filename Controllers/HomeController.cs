using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArduinoCameraWebApp.Models;

namespace ArduinoCameraWebApp.Controllers;

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
        return View();
    }
    [HttpGet]
    public PartialViewResult GetPhotos(DateTime startDate, DateTime endDate)
    {
        if(startDate == null){
            Console.WriteLine("Null value :(");
        }
        Console.WriteLine("Begin time: " + startDate.ToString() + ", end time: " + endDate.ToString());
        var Path = "<The path to your images here>";
        Console.WriteLine("About to get pics.");
        var fileFetcher = new FileFetcher(Path);
        var returnValue = fileFetcher.GetImages(startDate,endDate);
        Console.WriteLine("Getting the pics.");
        return PartialView("_ImagesViewPartial", returnValue);
    }    
[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
