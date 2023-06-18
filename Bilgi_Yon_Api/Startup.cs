using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.NHibernate;
using EntityLayer.EntityMap;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Text;

namespace Bilgi_Yon_Api
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
           
            // var connectionString = "server=DESKTOP-83R1MUR;database=OGRENCI;user id=sa;password=1234;integrated security=true";

            //BENÝM BÝLGÝSAYARA GÖRE
            var connectionString = "server=DESKTOP-83R1MUR;database=OGRENCI;user id=sa;password=1234;persist security info=True;";



            services.AddSingleton<ISessionFactory>(x =>
            {
                return Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                    .Mappings(m =>
                    {

                        //MAPLEMELERÝ BURAYA YAZIYORUM
                        m.FluentMappings.AddFromAssemblyOf<OGRENCI_BILGI_MAP>();
                        m.FluentMappings.AddFromAssemblyOf<OGRENCI_NOT_MAP>();
                    })
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                    .BuildSessionFactory();
            });
            services.AddScoped<ISession>(x => x.GetRequiredService<ISessionFactory>().OpenSession());
           
            //YENÝ BÝR CONTROLLER EKLERKEN BURAYADA BU FORMATTA EKLENECEK
            
            services.AddScoped<IOGRENCI_BILGIDal, NHOGRENCI_BILGIDal>();
            services.AddScoped<IOGRENCI_BILGIService, OGRENCI_BILGIManager>();
            services.AddScoped<IOGRENCI_NOTDal, NHOGRENCI_NOTDal>();
            services.AddScoped<IOGRENCI_NOTService, OGRENCI_NOTManager>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bilgi_Yon_Api", Version = "v1" });
            });

            services.AddCors(p =>
            {
                p.AddPolicy("Api", ps =>
                {

                    ps.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddLogging();

            //JWT TOKEN
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "http://localhost", 
                    ValidAudience = "http://localhost", 
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bilgiyonapiprojesigelistirme")),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero


                };

            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bilgi_Yon_Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Api");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



        }
    }
}
