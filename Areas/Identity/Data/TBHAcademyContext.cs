using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Data
{
    public class TBHAcademyContext : IdentityDbContext<TBHAcademyUser>
    {
        public TBHAcademyContext(DbContextOptions<TBHAcademyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet <Enroll> Enroll { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<AssignModules> AssignModules { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Topic> Topic { get; set; }

    }
}
