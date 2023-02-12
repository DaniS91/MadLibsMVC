using Microsoft.AspNetCore.Builder;
// lets us access tools to create and configure a web application host
using Microsoft.Extensions.DependencyInjection;
// allows us to access tools to create services within our web app that get added to our web application via dependency injection

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
      // creating a web application host

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();
      // creates and returns our web app host

      // app.UseDeveloperExceptionPage();
      // app.UseHttpsRedirection();
      // enable HTTPS redirection for all of your ASP.NET Core web apps going forward

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}