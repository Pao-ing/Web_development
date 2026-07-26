using Microsoft.AspNetCore.Mvc;

namespace SugarBlossomProject.Controllers
{
    public class HomeSweetController : Controller
    {
        public IActionResult HomeSweet()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
