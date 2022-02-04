using GymManager.ApplicationServices.EquipmentTypes;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipTypes;
using GymManager.ApplicationServices.Navigation;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Collections.Generic;
using System.Globalization;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "server=localhost;port=3306;database=gymmanager;user=root;password=root;CharSet=utf8;Sslmode=none;Pooling=false;AllowPublicKeyRetrieval=True";

            services.AddDbContext<GymManagerContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<GymManagerContext>()
                .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddTransient<IMembersAppService, MembersAppService>();

            services.AddTransient<IEquipmentTypeAppServices, EquipmentTypesAppServices>();

            services.AddTransient<IMembershipTypesAppServices, MembershipTypesAppServices>();

            services.AddTransient<IRepository<int, MembershipType>, MembershipTypesRepository>();

            services.AddTransient<IRepository<int, Member>, MembersRepository>();

            services.AddTransient<IRepository<int, EquipmentType>, EquipmentTypeRepository>();

            services.AddTransient<IMenuAppService, MenuAppService>();

            services.AddWkhtmltopdf();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var defaultDateCulture = "es-MX";
            var ci = new CultureInfo(defaultDateCulture);

            // Configure the localization middleware 
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo>
                {
                    ci,
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    ci,
                }
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
