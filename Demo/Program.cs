using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            //app.MapGet("/", () => "Hello World!");

            app.UseStaticFiles();
            app.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}"
                    );

            //defaults: new { action = "Index", controller = "Movies" },
            //constraints: new { Id = @"\d{2}"});


            //app.MapGet("/X{name}", async context =>
            //{
            //    //var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}!");
            //});


            app.Run();
        }
    }
}
