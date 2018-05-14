using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcmeCareers.Models
{

    public interface IApplicationDbContext
    {
         IDbSet<JobApplication> JobApplication { get; set; }
         IDbSet<JobInfo> JobInfo { get; set; }

        int SaveChanges();
    }

    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        public IDbSet<JobApplication> JobApplication { get; set; }
        public IDbSet<JobInfo> JobInfo { get; set; }
    }

    public class FakeApplicationDbContext : IApplicationDbContext
    {
        public IDbSet<JobApplication> JobApplication { get; set; }
        public IDbSet<JobInfo> JobInfo { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}