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
    public class DeviceTypeRepository : IDeviceTypeRepository
    {
        private readonly SmartHomeContext _context;

        public DeviceTypeRepository(SmartHomeContext context)
        {
            this._context = context;
        }
        public int Create(DeviceType deviceType)
        {
            _context.DeviceTypes.Add(deviceType);
            _context.SaveChanges();
            return deviceType.Id;
        }

        public bool Delete(int id)
        {
            var deviceType = _context.DeviceTypes.FirstOrDefault(x => x.Id == id);
            if(deviceType == null)
            {
                return false;
            }
            _context.DeviceTypes.Remove(deviceType);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<DeviceType> GetAll()
        {
            return _context.DeviceTypes;
        }

        public DeviceType? GetById(int id)
        {
            return _context.DeviceTypes.FirstOrDefault(x => x.Id == id); 
        }

        public int Update(DeviceType deviceType)
        {
            _context.DeviceTypes.Update(deviceType);
            _context.SaveChanges();
            return deviceType.Id;
        }
    }
}
