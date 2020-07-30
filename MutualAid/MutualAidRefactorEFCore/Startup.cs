using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Application.Services;
using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Repository;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Services;
using AutoMapper;
using MutualAidRefactorEFCore.Data.Auth;

namespace MutualAidRefactorEFCore
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
            ConfigureApplicationServices(services);
            ConfigureRepositories(services);
            ConfigureViewServices(services);
            //ConfigureAuth(services);


            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.UserMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.UserMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.AcceptedRequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.AcceptedRequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.RequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.RequestMappingProfile));

            services.AddControllersWithViews();

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
            });

            services.AddDbContext<MutualAidContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MutualAidConnection")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

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
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IAcceptedRequestRepository, AcceptedRequestRepository>();
        }

        private void ConfigureViewServices(IServiceCollection services)
        {
            services.AddScoped<IUserViewService, UserViewService>();
            services.AddScoped<IRequestViewService, RequestViewService>();
            services.AddScoped<IAcceptedRequestViewService, AcceptedRequestViewService>();
            services.AddScoped<IAuthProviderViewService, AuthProviderViewService>();
        }

        private void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IAcceptedRequestService, AcceptedRequestService>();
            services.AddScoped<IAuthProviderService, AuthProviderService>();
        }

        //private void ConfigureAuth(IServiceCollection services)
        //{
        //    services.AddScoped<IAuthProvider, AuthProvider>();
        //}
    }
}
