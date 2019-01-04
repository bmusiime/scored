using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scored.Models
{
    //[Table("tblRetro")]
    public class Retro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "RetroDate")]
        private DateTime? retroDate;
        public DateTime RetroDate
        {
            get => (retroDate ?? DateTime.Now);
            set { retroDate = value; }
        }
        public int SkillID { get; set; }

        [DisplayFormat(NullDisplayText = "Unknown")]
        public Level? Level { get; set; }

        [ForeignKey("SkillID")]
        public virtual Skill Skill { get; set; }
    }
}
