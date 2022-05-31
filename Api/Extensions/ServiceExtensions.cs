using Api.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                    );
            });

        //public static void ConfigureLoggerService(this IServiceCollection services) =>
        //    services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigurePostrgreSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApplicationContext>(
                opts => opts.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRESQL_CONNECTION_STRING")),
                ServiceLifetime.Transient
                );

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IFoodRepository, FoodRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            //services.AddScoped<IFoodService, FoodService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IReportService, ReportService>();
            //services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IIdentityService, IdentityService>();
            //services.AddHttpClient<INutritionixClient, NutritionixClient>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            //var builder = services.AddIdentity<User, IdentityRole>(o =>
            //{
            //    o.Password.RequireDigit = true;
            //    o.Password.RequireLowercase = false;
            //    o.Password.RequireUppercase = false;
            //    o.Password.RequireNonAlphanumeric = false;
            //    o.Password.RequiredLength = 10;
            //    o.User.RequireUniqueEmail = true;
            //})
            //.AddEntityFrameworkStores<MealsContext>()
            //.AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            //var jwtSettings = configuration.GetSection("JwtSettings");
            //var secretKey = jwtSettings["secretkey"]; // Environment.GetEnvironmentVariable("SECRET");
            //services.AddAuthentication(opt =>
            //{
            //    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = jwtSettings["validIssuer"],
            //        ValidAudience = jwtSettings["validAudience"],
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
            //    };
            //});
        }
    }
}
