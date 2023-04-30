using Ekobit.Ekoship.SmartHome.Data.Contracts;
using Ekobit.Ekoship.SmartHome.Data.Repositories;
using Ekobit.Ekoship.SmartHome.Desktop.Web.HttpClients;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Ekobit.Ekoship.SmartHome.Desktop.Web
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var form = ServiceProvider.GetRequiredService<FormSmartHomeWeb>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<ISmartHomeClient, SmartHomeClient>();

                    services.AddTransient<FormSmartHomeWeb>();
                });
        }
    }
}