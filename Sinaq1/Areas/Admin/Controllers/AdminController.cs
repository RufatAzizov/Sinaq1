using Microsoft.AspNetCore.Mvc;

namespace Sinaq1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Home/Index.cshtml");
        }
    }
}
