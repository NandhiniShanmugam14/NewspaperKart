//using Intuit.Ipp.Data;
using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Provider;
using JWTAuthorizationAPI.Repository;
using JWTAuthorizationAPI.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAdmin<Admintbl>, Admintbl>();
            services.AddScoped<IAdminRepo<Admintbl>, AdminRepo>();
            services.AddScoped<IAdminServ<Admintbl>, AdminServ>();
            services.AddScoped<IAdminAuthProvider<Admintbl>, AdminAuthProvider>();

            services.AddScoped<ICustomer<Customertbl>, Customertbl>();
            services.AddScoped<ICustomerRepo<Customertbl>, CustomerRepo>();
            services.AddScoped<ICustomerServ<Customertbl>, CustomerServ>();
            services.AddScoped<ICustomerAuthProvider<Customertbl>, CustomerAuthProvider>();

            services.AddScoped<IVendor<Vendortbl>, Vendortbl>();
            services.AddScoped<IVendorRepo<Vendortbl>, VendorRepo>();
            services.AddScoped<IVendorServ<Vendortbl>, VendorServ>();
            services.AddScoped<IVendorAuthProvider<Vendortbl>, VendorAuthProvider>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JWTAuthorizationAPI", Version = "v1" });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
            services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JWTAuthorizationAPI v1"));
            }
            loggerFactory.AddLog4Net();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
