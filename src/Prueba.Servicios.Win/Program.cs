using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace Prueba.Servicios.Win
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args);

        }
        public static void CreateHostBuilder(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


             
            //Requerido porque se ejecutará como servicio windows
            builder.Services.AddWindowsService();

            //servicio windows a usar
            builder.Services.AddHostedService<Worker>();

            //Si no usamos la siguiente línea no encontrará los servicios definidos en el proyecto Prueba.Servicios.Web
            //https://learn.microsoft.com/es-es/aspnet/core/mvc/advanced/app-parts?view=aspnetcore-8.0
            var assembly = typeof(Prueba.Servicios.Web.Program).Assembly;
            builder.Services.AddControllersWithViews()
                 .AddApplicationPart(assembly);

            


            var app = builder.Build();
             
            
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();


            app.Run();
        }
    }
}