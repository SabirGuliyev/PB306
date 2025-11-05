using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class CorporativeController : Controller
    {
        [Route("korporativ-satislar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
