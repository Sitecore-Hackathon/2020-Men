using System.Web.Mvc;

namespace Sitecore.Project.Hackathon.Controllers
{
    public class FooterController : Controller
    {
        // GET: Hackathons
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}