
using cleanArchitecture.Extensions;

namespace cleanArchitecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //  cors configuration corse origin policy
            builder.Services.ConfigureCors();
            // IIS configuration
            builder.Services.ConfigureIISIntegration();
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("hello  bangladesh ");
            });
            app.MapControllers();

            app.Run();
        }
    }
}
