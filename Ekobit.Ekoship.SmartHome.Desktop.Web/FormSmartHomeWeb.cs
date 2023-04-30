using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Desktop.Web.HttpClients;
using Ekobit.Ekoship.SmartHome.Model.Models.Address;
using Ekobit.Ekoship.SmartHome.Model.Models.Device;
using Ekobit.Ekoship.SmartHome.Model.Models.DeviceType;
using Ekobit.Ekoship.SmartHome.Model.Models.Home;
using Ekobit.Ekoship.SmartHome.Model.Models.Unit;

namespace Ekobit.Ekoship.SmartHome.Desktop.Web
{
    public partial class FormSmartHomeWeb : Form
    {
        private readonly ISmartHomeClient _smartHomeClient;

        private IEnumerable<HomeList> _homes = null!;
        private IEnumerable<DeviceList> _devices = null!;
        private IEnumerable<AddressDetails> _addresses = null!;
        private IEnumerable<DeviceTypeDetails> _deviceTypes = null!;
        private IEnumerable<UnitDetails> _units = null!;

        public FormSmartHomeWeb(ISmartHomeClient smartHomeClient)
        {
            InitializeComponent();

            _smartHomeClient = smartHomeClient;

            Task.Run(() => SetDataSources()).Wait();
        }

        private async Task SetDataSources()
        {
            _homes = new List<HomeList>();
            _homes = await _smartHomeClient.GetAllHomes();
            dataGridViewHomes.DataSource = _homes;

            _devices = new List<DeviceList>();
            _devices = await _smartHomeClient.GetAllDevices();
            dataGridViewDevices.DataSource = _devices;

            _addresses = new List<AddressDetails>();
            _addresses = await _smartHomeClient.GetAllAddresses();
            dataGridViewAddresses.DataSource = _addresses;

            _deviceTypes = new List<DeviceTypeDetails>();
            _deviceTypes = await _smartHomeClient.GetAllDeviceTypes();
            dataGridViewDeviceTypes.DataSource = _deviceTypes;

            _units = new List<UnitDetails>();
            _units = await _smartHomeClient.GetAllUnits();
            dataGridViewUnits.DataSource = _units;
        }
    }
}