using Microsoft.AspNetCore.Mvc;

namespace SINAC.Capacitacion.Curso1.Web.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
