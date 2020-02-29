using System.Web.Mvc;

namespace Sitecore.Project.Hackathon.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Hackathons
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}