using Ekobit.Ekoship.SmartHome.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IUnitRepository
    {
        public IEnumerable<Unit> GetAll();

        public Unit? GetById(int id);

        public int Create(Unit unit);

        public int Update(Unit unit);

        public bool Delete(int id);
    }
}
