using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using EFDataAuth.Test.Domain;
using Microsoft.EntityFrameworkCore;
using MiniApps.Core.Extension;
using DataTest.Domain.Mapping;
using MiniApps.Core.Interface;
using EFDataAuth.Test.Domain.Data;

namespace DataTest
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
            var conString = Configuration.GetConnectionString("Default");
            services.AddDbContext<MyTestDbContext>(option =>
            {
                option.UseSqlServer(conString);
            });
            services.AddTransient(typeof(DbContext), typeof(MyTestDbContext));

            services.AddMvc();
            services.AddEFMappings();
            services.AddScoped<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
