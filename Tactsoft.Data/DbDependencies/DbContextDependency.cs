using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tactsoft.Service.DbDependencies
{
    public static class DbContextDependency
    {
        public static void AddDbContextDependencies(this IServiceCollection services, IConfiguration configuration)
        {


            var connectionString = configuration.GetConnectionString("DbConnection");
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.LogTo(Console.WriteLine);
                options.UseSqlServer(connectionString);

            });
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(option =>
            {
                option.ExpireTimeSpan = TimeSpan.FromMinutes(60 * 1);
                option.LoginPath = "/Account/Login";
                option.AccessDeniedPath = "/Account/Login";
            });

            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(5);
                option.Cookie.HttpOnly = true;
                option.Cookie.IsEssential = true;
            });

            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = true;
            //    options.User.RequireUniqueEmail = true;
            //    options.Password.RequireNonAlphanumeric = false;

            //}).AddEntityFrameworkStores<AppDbContext>()
            //.AddDefaultTokenProviders();            

        }


    }

}
