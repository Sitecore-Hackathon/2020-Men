using System.Web.Mvc;

namespace Sitecore.Project.Hackathon.Controllers
{
    public class GallerySectionController : Controller
    {
        // GET: Hackathons
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}