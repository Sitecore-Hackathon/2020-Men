using Glass.Mapper.Sc;
using Sitecore.Project.Hackathon.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sitecore.Project.Hackathon.Controllers
{
    public class TeamController : Controller
    {
        //private readonly ISitecoreService _sitecoreService;

        //public TeamController(ISitecoreService sitecoreService)
        //{
        //    _sitecoreService = sitecoreService ?? throw new ArgumentNullException(nameof(sitecoreService));
        //}

        // GET: Hackathons
        public PartialViewResult Team()
        {
            var sc = new SitecoreContext();
            var item = Context.Database.GetItem($"/sitecore/content/hackathon/Hackathons{Request.Path.Replace("-", " ")}");
            var model = sc.Cast<Team>(item);

            model.TeamMembers = new List<TeamMember>();

            foreach (Sitecore.Data.Items.Item c in item.Children)
            {
                model.TeamMembers.Add(sc.Cast<TeamMember>(c));
            }

            return PartialView(model);
        }
    }
}