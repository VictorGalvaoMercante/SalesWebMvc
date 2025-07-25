using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models.ViewModels;

namespace SalesWeb.Controllers
{
    public class HomeController : Controller
    {
  
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Privacy()
        {
            ViewData["email"] = "galvaomercante@gmail.com";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
