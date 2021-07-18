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
            services.AddServerSideBlazor();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHostingDefaults(connectToHost: true, useDefaultFiles: true, useStaticFiles: true);

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
