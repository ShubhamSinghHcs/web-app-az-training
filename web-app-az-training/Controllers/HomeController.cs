using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_app_az_training.Models;

namespace web_app_az_training.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
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

        public IActionResult WebAppName()
        {
            var webAppName = _configuration["WebApp:Name"];
            ViewData["WebAppName"] = webAppName;
            return View();
        }
    }
}
