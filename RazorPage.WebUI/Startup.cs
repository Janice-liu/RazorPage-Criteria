using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPage.Core.Mapping;
using RazorPage.Core.Repos;
using RazorPage.Data;
using RazorPage.Data.Store;
using RazorPage.Repos;

namespace RazorPage.WebUI
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
            ZebraMapper.Initialize();
            services.AddScoped<IConnection, Connection>(x => new Connection(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDataContextFactory<Zebra_DBDataContext>, DataContextFactory>();
            services.AddScoped<IGoodsRepo,GoodsRepo>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
