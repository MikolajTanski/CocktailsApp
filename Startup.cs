using System;
using Drinks_app.Data;
using Drinks_app.Middleware;
using Drinks_app.Models;
using Drinks_app.Repositories;
using Drinks_app.Repositories.IRepositories;
using Drinks_app.Services;
using Drinks_app.Services.Helpers.IdentityRoles;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;
using Serilog;
using Serilog.Events;

namespace Drinks_app
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ErrorHandling>();
            services.AddScoped<ICocktailRecipeService, CocktailRecipeService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<ICocktailRecipeRepository, CocktailRecipeRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddAutoMapper(typeof(Startup));
            
            services.AddDistributedMemoryCache();
            //sesja 30 minut dla zalogowanych 
            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });


            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "UniversityCocktailsApp", Version = "v1" });
            });
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            /////
            var roleBuilder = new IdentityRoleBuilder();
            roleBuilder.CreateRole(services, "Admin").Wait();
            roleBuilder.CreateRole(services, "SuperAdmin").Wait();
            /////
             Log.Logger = new LoggerConfiguration()
                 .WriteTo.File("logging/logging-.txt", rollingInterval: RollingInterval.Day)
                 .WriteTo.File("errors/error-.txt", restrictedToMinimumLevel: LogEventLevel.Error, rollingInterval: RollingInterval.Day)
                 .WriteTo.File("registration/user-registration.log", rollingInterval: RollingInterval.Day)
                 .WriteTo.File("logging/user-logging.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            /////

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                 builder =>
                                 {
                                     builder.WithOrigins("https://localhost:44335", "http://localhost:4200", "http://localhost:8100")
                                                         .AllowAnyHeader()
                                                         .AllowAnyMethod();
                                 });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Drinks_app v1"));
            }
            app.UseSession();
            
             app.UseSerilogRequestLogging(); // Log HTTP requests
            
             app.UseMiddleware<ErrorHandling>();
            
             app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
