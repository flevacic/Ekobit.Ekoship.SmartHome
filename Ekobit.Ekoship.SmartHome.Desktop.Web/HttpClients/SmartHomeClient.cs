using Ekobit.Ekoship.SmartHome.Model.Models.Address;
using Ekobit.Ekoship.SmartHome.Model.Models.Device;
using Ekobit.Ekoship.SmartHome.Model.Models.DeviceType;
using Ekobit.Ekoship.SmartHome.Model.Models.Home;
using Ekobit.Ekoship.SmartHome.Model.Models.Unit;
using System.Text.Json;

namespace Ekobit.Ekoship.SmartHome.Desktop.Web.HttpClients
{
    internal class SmartHomeClient : ISmartHomeClient
    {
        private const string BaseApiAddress = "https://localhost:7169/";
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public readonly HttpClient _httpClient;

        public SmartHomeClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseApiAddress);

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<IEnumerable<HomeList>> GetAllHomes()
        {
            var httpResponse = await _httpClient.GetAsync("home");
            var jsonHomes = await httpResponse.Content.ReadAsStringAsync();
            var homes = JsonSerializer.Deserialize<IEnumerable<HomeList>>(jsonHomes, _jsonSerializerOptions);
            return homes;
        }

        public async Task<IEnumerable<DeviceList>> GetAllDevices()
        {
            var httpResponse = await _httpClient.GetAsync("device");
            var jsonDevices = await httpResponse.Content.ReadAsStringAsync();
            var devices = JsonSerializer.Deserialize<IEnumerable<DeviceList>>(jsonDevices, _jsonSerializerOptions);
            return devices;
        }

        public async Task<IEnumerable<AddressDetails>> GetAllAddresses()
        {
            var httpResponse = await _httpClient.GetAsync("address");
            var jsonAddresses = await httpResponse.Content.ReadAsStringAsync();
            var addresses = JsonSerializer.Deserialize<IEnumerable<AddressDetails>>(jsonAddresses, _jsonSerializerOptions);
            return addresses;
        }

        public async Task<IEnumerable<DeviceTypeDetails>> GetAllDeviceTypes()
        {
            var httpResponse = await _httpClient.GetAsync("deviceType");
            var jsonDeviceTypes = await httpResponse.Content.ReadAsStringAsync();
            var deviceTypes = JsonSerializer.Deserialize<IEnumerable<DeviceTypeDetails>>(jsonDeviceTypes, _jsonSerializerOptions);
            return deviceTypes;
        }

        public async Task<IEnumerable<UnitDetails>> GetAllUnits()
        {
            var httpResponse = await _httpClient.GetAsync("unit");
            var jsonUnits = await httpResponse.Content.ReadAsStringAsync();
            var units = JsonSerializer.Deserialize<IEnumerable<UnitDetails>>(jsonUnits, _jsonSerializerOptions);
            return units;
        }
    }
}
