using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    // Static methods can be used with a new instance of the class
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            // Adding DbContext to connect to DB
            services.AddDbContext<DataContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            // CORS to stop cross site scripting
            services.AddCors();

            // And scope our token
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}