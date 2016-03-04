using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Mock1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}