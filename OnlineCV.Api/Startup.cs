using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineCV.Data;

namespace OnlineCV.Api
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration conf)
        {
            _configuration = conf;

        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<JobbLibary>();
            //var conn = _configuration.GetConnectionString("");
            //// Register all services here:
            //services.AddDbContext<ApplicationDbContext>(options => options.);

            services.AddCors(option => option.AddPolicy("All", next => next
                                                                            .AllowAnyHeader()
                                                                            .AllowAnyOrigin()
                                                                            .AllowAnyMethod()));
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
        }
    }
}
