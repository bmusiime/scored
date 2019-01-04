using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scored.Models
{
    //[Table("tblSkill")]
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Skill is required")]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [DisplayName("Description")]
        public string Description { get; set; }

    }
}
