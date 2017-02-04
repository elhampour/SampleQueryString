using System.Web.Mvc;

namespace SampleQueryString.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string q)
        {
            return View();
        }
    }
}