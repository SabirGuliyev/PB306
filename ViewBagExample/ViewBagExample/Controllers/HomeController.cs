using Microsoft.AspNetCore.Mvc;
using ViewBagExample.Models;
using ViewBagExample.ViewModels;

namespace ViewBagExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new()
            {
                new Student{ Id=1, Name="Eynulla",Age=18 },
                new Student{ Id=2, Name="Aytac",Age=18 },
                new Student{ Id=3, Name="Nazrin",Age=20 },
                new Student{ Id=4, Name="Dilshad",Age=22 }
            };
            List<Teacher> teachers = new()
            {
                new Teacher{Id=1, Name="Sabir",Salary=76543.90m},
                new Teacher{Id=2, Name="Revan",Salary=126543.99m},

            };

            HomeVM homeVM = new HomeVM {
                Students = students,
                Teachers = teachers
            
            
            };

            return View(homeVM);







            //ViewBag.Students= students;

            //ViewData["Students"] = students;

            //TempData["Name"] = "Eynulla";
        }


        public IActionResult Details()
        {
            return View();
        }

        public IActionResult About()
        {
            string str=TempData["Name"].ToString();
            TempData.Keep("Name");

            return Content(str);
        }


    }
}
