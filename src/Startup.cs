using Conesoft.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Home
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostingDefaults();

            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseHostingDefaults(connectToHost: true, useDefaultFiles: true, useStaticFiles: true);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
