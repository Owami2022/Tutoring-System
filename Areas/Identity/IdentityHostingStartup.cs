using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;

[assembly: HostingStartup(typeof(TBHAcademy.Areas.Identity.IdentityHostingStartup))]
namespace TBHAcademy.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                     .RequireAuthenticatedUser()
            //                     .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //}).AddXmlSerializerFormatters();
            services.AddDbContext<TBHAcademyContext>(options =>
                options.UseSqlServer(
                    context.Configuration.GetConnectionString("TBHAcademyContextConnection")));
            var lockoutOptions = new LockoutOptions()
            {
                AllowedForNewUsers = true,
                DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5),
                MaxFailedAccessAttempts = 3


            };

            services.AddIdentity<TBHAcademyUser, IdentityRole>(options => 
            {
                options.SignIn.RequireConfirmedAccount = false;

                options.Lockout = lockoutOptions;
            })
                     .AddRoles<IdentityRole>()
                     .AddDefaultUI()
                     .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<TBHAcademyContext>();
               

                //var lockoutOptions = new LockoutOptions()
                //{
                //    AllowedForNewUsers = true,
                //    DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5),
                //    MaxFailedAccessAttempts = 3


                //};

                //services.AddIdentity<TBHAcademyUser, IdentityRole>(options =>
                //{
                //    options.Lockout = lockoutOptions;
                //}
                //    );

            });
          
        }
    }
}