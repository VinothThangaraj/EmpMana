
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EmpManagement.Startup))]

namespace EmpManagement
{
    public partial class Startup
    {
        /// <summary>
        /// App Configuration
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuthAsync(app);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AnyOrigin", builder =>
            //    {
            //        builder
            //            .AllowAnyOrigin()
            //            .AllowAnyMethod();
            //    });
            //});
        }
        public void Configure(IApplicationBuilder app)
        {
           // app.UseCors(builder => builder
           // .AllowAnyOrigin()
           // .AllowAnyMethod()
           // .AllowAnyHeader()
           // .AllowCredentials());
        }
    }
}
