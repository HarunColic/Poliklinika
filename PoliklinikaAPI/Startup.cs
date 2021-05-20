using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.Helpers;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.Mappers;
using PoliklinikaAPI.Services;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaAPI
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
            services.AddCors();

            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen();
            services.AddDbContext<DBContext>(
            options => options.UseSqlServer("name=cs1"),
            ServiceLifetime.Transient);

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddScoped<UserBaseInterface<Korisnik, KorisnikVM, SignUpKorisnikVM>, UserBaseService<Korisnik, KorisnikVM, SignUpKorisnikVM>>();
            services.AddScoped<UserBaseInterface<Doktor, DoktorVM, CreateDoktorVM>, UserBaseService<Doktor, DoktorVM, CreateDoktorVM>>();
            services.AddScoped<UserBaseInterface<Tehnicar, TehnicarVM, CreateTehnicarVM>, UserBaseService<Tehnicar, TehnicarVM, CreateTehnicarVM>>();
            services.AddScoped<AuthenticationInterface, AuthenticationService>();
            services.AddScoped<BaseInterface<Osoblje, OsobljeVM>, BaseService<Osoblje, OsobljeVM>>();
            services.AddScoped<BaseInterface<Nalaz, NalazVM>, BaseService<Nalaz, NalazVM>>();
            services.AddScoped<BaseInterface<Odjel, OdjelVM>, BaseService<Odjel, OdjelVM>>();

            services.AddIdentity<User, Role>()
                    .AddEntityFrameworkStores<DBContext>()
                    .AddDefaultTokenProviders();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthorization();


            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseMiddleware<JwtMiddleware>();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
