using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Application.MappingProfiles;
using EFCorePractice.Application.Services;
using EFCorePractice.Data.Context;
using EFCorePractice.Data.Interfaces;
using EFCorePractice.Data.Repository;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.MappingProfiles;
using EFCorePractice.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCorePractice
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
            ConfigureRepositories(services);
            ConfigureViewServices(services);
            ConfigureApplicationServices(services);

            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.UserMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.UserMappingProfile));

            services.AddControllersWithViews();

            services.AddDbContext<PracticeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PracticeDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
        }

        private void ConfigureViewServices(IServiceCollection services)
        {
            services.AddScoped<IUserViewService, UserViewService>();
            services.AddScoped<IOrderViewService, OrderViewService>();
            services.AddScoped<IItemViewService, ItemViewService>();
        }

        private void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IItemService, ItemService>();
        }
    }
}
