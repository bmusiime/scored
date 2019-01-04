using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scored.Models;

namespace Scored.ViewModels
{
    public class RetroViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public Level? Level { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "RetroDate")]
        public DateTime RetroDate
        {
            get => (this.retroDate ?? DateTime.Now);
            set { this.retroDate = value; }
        }
        private DateTime? retroDate = DateTime.Now;

        public int SkillID { get; set; }
        public Skill Skill { get; set; }

        [DisplayName("Title")]
        public string SelectedSkillTitle { get; set; }

        [DisplayName("Description")]
        public string SelectedSkillDescription { get; set; }

        public SelectList Levels { get; set; }
        public IEnumerable<SkillListModel> Skills { get; set; }
        public IEnumerable<RetroViewModel> RetroViewModels { get; set; }
    }
}
