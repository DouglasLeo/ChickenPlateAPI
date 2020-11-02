using ChikenPlatesApp.Data;
using ChikenPlatesApp.Models.Repositories;
using ChikenPlatesApp.Services;
using ChikenPlatesApp.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChikenPlatesApp
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
            services.AddDbContext<ChickenContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("default"), builder =>
                    builder.MigrationsAssembly("ChikenPlatesApp")));
            services.AddScoped<ISideDishService, SideDishServices>();

            services.AddScoped<ISideDishRepository, SideDishRepository>();

            services.AddScoped<SideDishServices>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
