using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Core.DomainModels;

namespace TRS.Data
{
    public class TRSContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public TRSContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }
        public static TRSContext Create()
        {
            return new TRSContext();
        }
    }
}
