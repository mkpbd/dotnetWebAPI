
using cleanArchitecture.Extensions;
using NLog;

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

            // Configure logger service
            builder.Services.ConfigureLoggerService();
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            // use  hsts  strict transport security header
            app.UseHsts();
            app.UseHttpsRedirection();

            // statics files 
            app.UseStaticFiles();
            // use forwaded headers   proxy headers  to the current request
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All
            });
            // use cores
            app.UseCors("CorsPolicy");
         
            app.UseAuthorization();
            //============================ Run Middle ware =======================

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("hello  bangladesh ");
            //});
            //===========================  Use Middleware ==========================
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Logic before  executing the next delegate in the use method ");
            //    await next.Invoke();

            //    Console.WriteLine(" Logic after executing the next delegate in the use method");
            //});

            //app.Use(async (context, next) =>
            //{
            //    next.Invoke();
            //    Console.WriteLine($"Writing the response to the client in the Run method");
            //    await context.Response.WriteAsync("Hello from the middleware component.");
            //});


            // =============== Map  middleware  ===================


            //app.Map("/path-name", builder =>
            //{
            //    builder.Use(async (context, next) =>
            //    {
            //        Console.WriteLine("Map branch logic in the Use method before the next delegate");
            //        await next.Invoke(); Console.WriteLine("Map branch logic in the Use method after the next delegate");
            //    });

            //    builder.Run(async context => { Console.WriteLine($"Map branch response to the client in the Run method"); 
            //        await context.Response.WriteAsync("Hello from the map branch."); });

            //});

            // =========================  MapWhen Middleware  ================

            //app.MapWhen(context => context.Request.Query.ContainsKey("testqueryString"), builder =>
            //{
            //    builder.Run(async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from the MapWhen branch.");
            //    });
            //});

            app.MapControllers();

            app.Run();
        }
    }
}
