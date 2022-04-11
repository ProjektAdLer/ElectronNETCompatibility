using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ElectronWrapper;

/// <summary>
/// Indirection so we don't have to reference ElectronNET.API directly in AuthoringTool
/// </summary>
public static class StartupExtensions
{
    public static IServiceCollection AddElectronInternals(this IServiceCollection services)
    {
        services.AddElectron();
        
        return services;
    }

    public static IServiceCollection AddElectronWrappers(this IServiceCollection services)
    {
        services.AddSingleton<IWindowManagerWrapper, WindowManagerWrapper>();
        services.AddSingleton<IDialogWrapper, DialogWrapper>();
        return services;
    }

    public static IApplicationBuilder ConfigureElectronWindow(this IApplicationBuilder appBuilder)
    {
        if (HybridSupport.IsElectronActive)
            Task.Run(async () =>
            {
                var options = new BrowserWindowOptions
                {
                    Fullscreenable = true,
                };
                return await Electron.WindowManager.CreateWindowAsync(options);
            });
        
        //exit app on all windows closed
        Electron.App.WindowAllClosed += () => Electron.App.Exit();
        return appBuilder;
    }

    public static IWebHostBuilder UseElectronWrapper(this IWebHostBuilder webHostBuilder, string[] args) =>
        webHostBuilder.UseElectron(args);
}