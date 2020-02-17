using System;
using bethanyspieshop.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(bethanyspieshop.Areas.Identity.IdentityHostingStartup))]
namespace bethanyspieshop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<bethanyspieshopContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("bethanyspieshopContextConnection")));

                /*services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<bethanyspieshopContext>();*/
            });
        }
    }
}