using System.Web.Mvc;

namespace Sitecore.Project.Hackathon.Controllers
{
    public class HackathonsController : Controller
    {
        // GET: Hackathons
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}