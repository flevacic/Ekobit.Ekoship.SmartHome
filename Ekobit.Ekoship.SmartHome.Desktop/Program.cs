using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Contracts;
using Ekobit.Ekoship.SmartHome.Data.Repositories;
using Ekobit.Ekoship.SmartHome.Services;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Ekobit.Ekoship.SmartHome.Desktop
{
    internal static class Program
    {
        private const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SmartHome;Integrated Security=True";

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var form = ServiceProvider.GetRequiredService<FormSmartHome>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<SmartHomeContext>(options =>
                                    options.UseSqlServer(ConnectionString));

                    services.AddTransient<IHomeRepository, HomeRepository>();
                    services.AddTransient<IDeviceRepository, DeviceRepository>();
                    services.AddTransient<IAddressRepository, AddressRepository>();
                    services.AddTransient<IDeviceTypeRepository, DeviceTypeRepository>();
                    services.AddTransient<IUnitRepository, UnitRepository>();

                    services.AddTransient<IHomeService, HomeService>();
                    services.AddTransient<IDeviceService, DeviceService>();
                    services.AddTransient<IAddressService, AddressService>();
                    services.AddTransient<IDeviceTypeService, DeviceTypeService>();
                    services.AddTransient<IUnitService, UnitService>();

                    services.AddTransient<FormSmartHome>();
                });
        }
    }
}