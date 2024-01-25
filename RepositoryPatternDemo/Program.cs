using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Context;
using RepositoryPatternDemo.IRepo;
using RepositoryPatternDemo.Repo;

namespace RepositoryPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddTransient<CourseRepo>();
            builder.Services.AddTransient<ICourseRepo, CourseRepo>();
            builder.Services.AddDbContext<CourseDbContext>(x => x.UseSqlServer(builder.Configuration["ConnectionStrings:MyCon"]));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}