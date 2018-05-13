using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcmeCareers.Models
{
    public class JobInfo
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Location")]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}