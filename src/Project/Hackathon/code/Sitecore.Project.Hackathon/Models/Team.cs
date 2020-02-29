using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System.Collections.Generic;

namespace Sitecore.Project.Hackathon.Models
{
    [SitecoreType(TemplateId = "{990A5353-ADA6-4A45-899A-660985CF423A}")]
    public class Team
    {
        [SitecoreId]
        public virtual ID Id { get; set; }

        [SitecoreField("Name")]
        public string Name { get; set; }

        public List<TeamMember> TeamMembers { get; set; }
    }
}