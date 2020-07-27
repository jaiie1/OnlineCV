using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using OnlineCV.Data;
using OnlineCv.Libary.Interface;
using OnlineCv.Libary;

namespace OnlineCV.Api
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
              
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var conn = _config.GetConnectionString("OnlineCv");
            //// Register all services here:
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conn));
            //services.BuildServiceProvider().GetService<ApplicationDbContext>().Database.Migrate();
            services.AddSingleton<JobbLibary>();
            services.AddCors(option => option.AddPolicy("All", next => next
                                                                            .AllowAnyHeader()
                                                                            .AllowAnyOrigin()                                                                            
                                                                            .AllowAnyMethod()));

            services.AddTransient<IJobbrepository, JobbRepository>();
        }        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                
            }

            app.UseRouting();

            app.UseCors("All");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            MockData.FillIfEmpty(ctx);
        }
    }
}
