using System.Collections.Generic;

namespace Scored.ViewModels
{
    public class SkillListModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public IEnumerable<SkillListModel> SkillListModels { get; set; }
    }
}
