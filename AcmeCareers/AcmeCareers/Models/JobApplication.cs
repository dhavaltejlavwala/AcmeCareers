using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCareers.Models
{
    public class JobApplication
    {
        [Key]
        public int AppId { get; set; }

        public int JobId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Comments (Optional)")]
        public string Comments { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AppDateTime { get; set; }

        public virtual JobInfo JobInfo { get; set; }

        public IEnumerable<SelectListItem> JobTitleList { get; set; }
    }
}