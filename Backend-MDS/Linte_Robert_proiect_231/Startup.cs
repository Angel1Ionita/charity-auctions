using Linte_Robert_proiect_231.Data;
using Linte_Robert_proiect_231.Repositories.ComandaRepository;
using Linte_Robert_proiect_231.Repositories.ComentariuRepository;
using Linte_Robert_proiect_231.Repositories.Cos_ProdusRepository;
using Linte_Robert_proiect_231.Repositories.ProdusRepository;
using Linte_Robert_proiect_231.Repositories.UserRepository;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231
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
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Linte_Robert_proiect_231", Version = "v1" });
            });
            services.AddDbContext<Proiect_context>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Linte_Robert_Proiect231;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddTransient<IProdusRepository, ProdusRepository>();
            services.AddTransient<IComandaRepository, ComandaRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICosProdusRepository, CosProdusRepository>();
            services.AddTransient<IComentariuRepository, ComentariuRepository>();
            services.AddControllersWithViews()
                .AddNewtonsoftJson(option =>
                option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Linte_Robert_proiect_231 v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors( options =>
                options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
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
