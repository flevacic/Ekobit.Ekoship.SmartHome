
using Ekobit.Ekoship.SmartHome.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IDeviceTypeRepository
    {
        public IEnumerable<DeviceType> GetAll();

        public DeviceType? GetById(int id);

        public int Create(DeviceType deviceType);

        public int Update(DeviceType deviceType);

        public bool Delete(int id);
    }
}
