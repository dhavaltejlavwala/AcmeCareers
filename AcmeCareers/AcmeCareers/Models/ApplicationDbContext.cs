using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcmeCareers.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<JobApplication> JobApplication { get; set; }
        public DbSet<JobInfo> JobInfo { get; set; }
    }
}