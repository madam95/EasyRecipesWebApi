using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRecipesWebApi.Domain.Repositories;
using EasyRecipesWebApi.Domain.Services;
using EasyRecipesWebApi.Persistence.Contexts;
using EasyRecipesWebApi.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EasyRecipesWebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EasyRecipesContext>(opt =>
                opt.UseSqlServer(Configuration["EasyRecipesApiConnection:ConnectionString"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IIngredientRepository, IngredientsRepository>();
            services.AddScoped<IIngredientService, IngredientService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
