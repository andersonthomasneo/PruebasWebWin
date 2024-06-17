namespace Prueba.Servicios.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inicializar(args);


        }


        public static void Inicializar(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.Run();

        }
    }
}
