using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.HttpOverrides;
  
namespace DevextremeExamples
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            // Add framework services.
            //services.AddRazorPages().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddMvc();

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(25);//You can set Time   
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers().AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("AllowAllOrigins");

            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            else
            {
                // app.UseExceptionHandler("/Error/ErrorPage");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseMiddleware<ApiKeyMiddleware>(); 

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedProto
            });

            app.UseRewriter(new RewriteOptions().Add(
                       context =>
                       {
                           if (context.HttpContext.Request.Path == "/MicrosoftIdentity/Account/SignedOut")
                           { context.HttpContext.Response.Redirect("/Index"); }
                       })
           );
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=account}/{action=login}/{id?}");
            });
        }
    }
}
