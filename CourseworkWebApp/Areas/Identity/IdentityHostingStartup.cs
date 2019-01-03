using System;
using CourseworkWebApp.Areas.Identity.Data;
using CourseworkWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CourseworkWebApp.Areas.Identity.IdentityHostingStartup))]
namespace CourseworkWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CourseworkWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CourseworkWebAppContextConnection")));

                services.AddDefaultIdentity<CourseworkWebAppUser>()
                    .AddEntityFrameworkStores<CourseworkWebAppContext>();
            });
        }
    }
}