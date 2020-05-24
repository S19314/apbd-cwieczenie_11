using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Cwieczenie11.Models;

namespace Cwieczenie11
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


            services.AddDbContext<DoctorsDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
            });

            
            services.AddDbContext<PatientDbContext>(options => 
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
            });

            services.AddDbContext<MedicamentsDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
            });

           

            services.AddDbContext<PrescriptionsDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
            });
            
            services.AddDbContext<Prescription_MedicamentsDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
            });

            services.AddDbContext<DbInitializateContext>(
                options => {
                    options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19314;Integrated Security=True");
                }    
            );

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
