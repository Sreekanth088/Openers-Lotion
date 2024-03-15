using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Openers_Lotion.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace Openers_Lotion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string http;

        public ActionResult Admin()
        {
            string apiUri = Url.Action("DefaultApi", new { controller = "admin" });
            ViewBag.ApiUrl = new Uri(Request.Scheme + "://" + Request.Host + apiUri).AbsoluteUri;


            return View();
        }
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
