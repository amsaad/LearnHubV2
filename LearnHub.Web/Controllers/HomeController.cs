using LearnHub.Web.Configs;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LearnHub.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> IndexAsync()
        {
            //await Category._category.List();
            SysSettings s = new SysSettings();
            var result = await s.GetSettings();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}