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
    public class UnitRepository : IUnitRepository
    {
        private readonly SmartHomeContext _context;

        public UnitRepository(SmartHomeContext context)
        {
            this._context = context;
        }
        public int Create(Unit unit)
        {
            _context.Units.Add(unit);
            _context.SaveChanges();
            return unit.Id;
        }

        public bool Delete(int id)
        {
            var unitToDelete = _context.Units.FirstOrDefault(x => x.Id == id);
            if (unitToDelete == null)
            {
                return false;
            }

            _context.Units.Remove(unitToDelete);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Unit> GetAll()
        {
            return _context.Units;
        }

        public Unit? GetById(int id)
        {
            return _context.Units.FirstOrDefault(x => x.Id == id);
        }

        public int Update(Unit unit)
        {
            _context.Units.Update(unit);
            _context.SaveChanges();
            return unit.Id;
        }
    }
}
