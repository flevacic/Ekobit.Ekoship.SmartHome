using Ekobit.Ekoship.SmartHome.Model.Models.Address;
using Ekobit.Ekoship.SmartHome.Model.Models.Device;
using Ekobit.Ekoship.SmartHome.Model.Models.DeviceType;
using Ekobit.Ekoship.SmartHome.Model.Models.Home;
using Ekobit.Ekoship.SmartHome.Model.Models.Unit;

namespace Ekobit.Ekoship.SmartHome.Desktop.Web.HttpClients
{
    public interface ISmartHomeClient
    {
        Task<IEnumerable<HomeList>> GetAllHomes();

        Task<IEnumerable<DeviceList>> GetAllDevices();

        Task<IEnumerable<AddressDetails>> GetAllAddresses();

        Task<IEnumerable<DeviceTypeDetails>> GetAllDeviceTypes();

        Task<IEnumerable<UnitDetails>> GetAllUnits();
    }
}
