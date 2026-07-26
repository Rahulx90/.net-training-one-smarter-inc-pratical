using Assignment10_21july.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment10_21july.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
