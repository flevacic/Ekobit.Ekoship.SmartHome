using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Ekobit.Ekoship.SmartHome.Desktop
{
    public partial class FormSmartHome : Form
    {
        private readonly IHomeService _homeService;
        private readonly IDeviceService _deviceService;
        private readonly IAddressService _addressService;
        private readonly IDeviceTypeService _deviceTypeService;
        private readonly IUnitService _unitService;

        private IEnumerable<Home> _homes = null!;
        private IEnumerable<Device> _devices = null!;
        private IEnumerable<Address> _addresses = null!;
        private IEnumerable<DeviceType> _deviceTypes = null!;
        private IEnumerable<Unit> _units = null!;

        public FormSmartHome(IHomeService homeService, IDeviceService deviceService, IAddressService addressService,
                             IDeviceTypeService deviceTypeService, IUnitService unitService)
        {
            InitializeComponent();

            _homeService = homeService;
            _deviceService = deviceService;
            _addressService = addressService;
            _deviceTypeService = deviceTypeService;
            _unitService = unitService;

            SetDataSources();
        }

        private void SetDataSources()
        {
            _homes = new List<Home>();
            _homes = _homeService.GetAllHomes();
            dataGridViewHomes.DataSource = _homes;

            _devices = new List<Device>();
            _devices = _deviceService.GetAllDevices();
            dataGridViewDevices.DataSource = _devices;

            _addresses = new List<Address>();
            _addresses = _addressService.GetAllAddresses();
            dataGridViewAddresses.DataSource = _addresses;

            _deviceTypes = new List<DeviceType>();
            _deviceTypes = _deviceTypeService.GetAllDeviceTypes();
            dataGridViewDeviceTypes.DataSource = _deviceTypes;

            _units = new List<Unit>();
            _units = _unitService.GetAllUnits();
            dataGridViewUnits.DataSource = _units;
        }
    }
}