using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ERPCloudMaker.DataBaseContext;

namespace ERPCloudMaker.Controllers
{
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
        public IActionResult Dashboard() 
        {
            return View();
        }
        public IActionResult CreateCompany()
        {
            return View();
        }
        
       
        public IActionResult Ledgers()
        {
            return View();
        }
       
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}