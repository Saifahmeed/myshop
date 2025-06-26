using Microsoft.AspNetCore.Mvc;

namespace myshop.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
