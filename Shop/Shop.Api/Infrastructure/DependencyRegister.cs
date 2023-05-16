using AspNetCoreRateLimit;
using Shop.Api.Infrastructure.Gateways.Zibal;
using Shop.Api.Infrastructure.JwtUtil;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Shop.Api.Infrastructure;

public static class DependencyRegister
{
    public static void RegisterApiDependency(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddAutoMapper(typeof(MapperProfile).Assembly);
        service.AddTransient<CustomJwtValidation>();
        service.AddHttpClient<IZibalService, ZibalService>();

        service.AddCors(options =>
        {
            options.AddPolicy(name: "ShopApi",
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });

        service.AddMemoryCache();
        service.Configure<IpRateLimitOptions>(configuration.GetSection("IpRateLimiting"));
        service.Configure<IpRateLimitPolicies>(configuration.GetSection("IpRateLimitPolicies"));
        service.AddInMemoryRateLimiting();
        service.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
    }
}