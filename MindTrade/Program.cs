using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MindTrade.Data;
using MindTrade.Helper;
namespace MindTrade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Gerado pelo entityframework
            builder.Services.AddDbContext<MindTradeContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MindTradeContext") ?? throw new InvalidOperationException("Connection string 'MindTradeContext' not found.")));

            //Serviços do razor
            builder.Services.AddRazorPages()
                .AddRazorRuntimeCompilation();

            //Serviços do httpContextAcessor
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Definindo qual classe a interface sessao vai instanciar
            builder.Services.AddScoped<ISessao,  Sessao>();

            //
            builder.Services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Habilitando sessões no projeto
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}