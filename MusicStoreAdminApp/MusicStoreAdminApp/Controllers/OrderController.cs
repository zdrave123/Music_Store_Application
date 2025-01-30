using Microsoft.AspNetCore.Mvc;

namespace MusicStoreAdminApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
