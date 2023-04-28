using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly SmartHomeContext _context;

        public DeviceRepository(SmartHomeContext context)
        {
            this._context = context;
        }
        public int Create(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return device.Id;
        }

        public bool Delete(int id)
        {
            var deviceToDelete = _context.Devices.FirstOrDefault(x => x.Id == id);
            if (deviceToDelete == null)
            {
                return false;
            }

            _context.Devices.Remove(deviceToDelete);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Devices;
        }

        public Device? GetById(int id)
        {
            return _context.Devices.FirstOrDefault(x => x.Id == id);
        }

        public int Update(Device device)
        {
            _context.Devices.Update(device);
            _context.SaveChanges();
           return device.Id;
        }
    }
}
