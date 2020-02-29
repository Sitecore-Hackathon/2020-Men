using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;

namespace Sitecore.Project.Hackathon.Models
{
    [SitecoreType(TemplateId = "{76E50733-7531-4D21-8072-7DF2D8D06467}")]
    public class TeamMember
    {
        [SitecoreId]
        public virtual ID Id { get; set; }

        [SitecoreField("Name")]
        public string Name { get; set; }
    }
}