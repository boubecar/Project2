
using Microsoft.AspNetCore.Builder;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;
using System.Reflection;
using Project_5S.Data.Context;
using Project_5S.Infra.Ioc;
using Project_5S.Api.Mapper;

namespace Project_5S.Api
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
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Masque saisie tresorerie V1", Version = "v1" });
            });

            services.AddDbContext<Project_5SContext>(options =>
            {
                
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection"));
            
            }
        );
            services.AddControllers();


            services.AddMediatR(typeof(Startup));
   var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfiles());
            });
           IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(Assembly.GetExecutingAssembly());

            DependencyContainer.RegisterServices(services);


            ///cors
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin",
            //        options =>
            //        options.AllowAnyOrigin()
            //            .AllowAnyHeader()
            //            .AllowAnyMethod()

            //        );
            //});

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                   .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

              
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Masque saisie tresorerie V1");
                });

            }
            //app.UseCors("AllowOrigin");



            //app.UseRouting();

            //app.UseAuthorization

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
