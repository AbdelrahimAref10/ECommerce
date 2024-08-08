using Application;
using Infrastructure;

namespace ECommerce.Server
{
    public static class StatupExtensions
    {
        public static WebApplication ConfigureServices (this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddDatabaseServices(builder.Configuration);
            builder.Services.AddControllers();
            // Configure CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    policy => policy
                        .AllowAnyOrigin() // Allow any origin
                        .AllowAnyMethod() // Allow any method (GET, POST, etc.)
                        .AllowAnyHeader()); // Allow any header
            });
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddOpenApiDocument(document =>
            {
                document.Title = "Ecommerce API";
            });
            return builder.Build();
        }

        public static WebApplication ConfigurePipeline (this WebApplication app)
        {
            app.UseCors("open");
            app.UseDefaultFiles();
            app.UseStaticFiles();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwaggerUi();
                app.UseOpenApi();
            }
            app.UseRouting();
            app.UseHttpsRedirection();
            app.MapControllers();
            app.UseAuthorization();
            app.MapFallbackToFile("/index.html");
            return app;
        }

    }
}
