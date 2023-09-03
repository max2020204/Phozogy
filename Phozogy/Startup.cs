using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Phozogy.Data;
using Phozogy.Data.Repositories.EntityFramework;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;

namespace Phozogy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBlogRepository, EFBlog>();
            services.AddScoped<ICommentRepository, EFComment>();
            services.AddScoped<IPostRepository, EFPost>();
            services.AddScoped<IReviewRepository, EFReview>();
            services.AddScoped<ITeamRepository, EFTeam>();
            services.AddScoped<IEmailRepository, EFEmail>();
            services.AddScoped<IFeedBack, EFFeedBack>();
            services.AddScoped<DataManager>();

            Configuration.Bind("SocialShare", new SocialShare());
            Configuration.Bind("ContactInformation", new ContactInformation());
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.User.AllowedUserNameCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_-.";
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<AppDbContext>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Post",
                    pattern: "Post/{action=Index}/{id?}",
                    defaults: new { Controller = "Post", action = "Index" });
            });
        }
    }
}