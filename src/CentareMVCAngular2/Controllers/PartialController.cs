using Microsoft.AspNet.Mvc;

namespace CentareMVCAngular2.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Message() => PartialView();

        public IActionResult Numbers() => PartialView();

        public IActionResult Users() => PartialView();
    }
}