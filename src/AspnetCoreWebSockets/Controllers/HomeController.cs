using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreWebSockets.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new EmptyResult();
        }
    }
}
