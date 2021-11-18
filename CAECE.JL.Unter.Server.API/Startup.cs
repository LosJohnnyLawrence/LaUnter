using CAECE.JL.Unter.Server.Datos;
using CAECE.JL.Unter.Server.Datos.Repo;
using CAECE.JL.Unter.Server.Datos.Helpers;
using CAECE.JL.Unter.Server.Servicios;
using CAECE.JL.Unter.Server.Servicios.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAECE.JL.Unter.Notificaciones;
using CAECE.JL.Unter.Notificaciones.Helpers;

namespace CAECE.JL.Unter.Server.API
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
            services.AddControllers();
            services.AddDbContext<ContextoDatosUnter>(builder => builder.UseSqlServer(Configuration.GetConnectionString("MainDB")));
           
            services.AgregarServiciosCore<ServicioFacturacion, ServicioAsmOrden, ServicioTrackOrden, ServicioMenu, ServicioMesas, ServicioMozos>();

            services.AgregarServiciosNotificacion<ConectorNotificacion>();

            services.AgregarReposCore<RepoEstadoPreparacion, RepoMenu, RepoMesa, RepoMozos, RepoOrden>();
            services.AgregarPerfilesNegocioAutomapper();
          


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CAECE.JL.Unter.Server.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CAECE.JL.Unter.Server.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
