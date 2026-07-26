using _16julyPratical.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Cache;

namespace _16julyPratical.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
    {
        new Student { Id = 101, Name = "Rahul", Age = 21, Course = "Dotnet Framework" , Gender ="male", Qualification="1"},
        new Student { Id = 102, Name = "Anshuman", Age = 20, Course = "Java Framework" , Gender ="male" , Qualification="2"},
        new Student { Id = 103, Name = "Ammar", Age = 22, Course = ".NET Framework" ,Gender ="male" , Qualification="3"},
        new Student { Id = 104, Name = "Kartik", Age = 20, Course = "Python Framework", Gender ="male" , Qualification="4"},
    };

            return View(students);
        }


    }
}
