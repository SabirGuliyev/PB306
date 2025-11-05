using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index()
        {
            //var json = new JsonResult(
            //    new
            //    {
            //        Name = "Test",
            //        Surname = "Testov"
            //    }
            //    );
            //return json;

            //return Content("Hello world");

            return View();

            
        }


        public IActionResult Details(int? id)
        {
            if(id==null|| id < 1)
            {
                return BadRequest();

                //return Content("");
            }

            return View("Product");
        }
        
    }
}
