using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Data.Contracts
{
    public interface IAddressRepository
    {
        public IEnumerable<Address> GetAll();

        public Address? GetById(int id);

        public int Create(Address address);

        public int Update(Address address);

        public bool Delete(int id);
    }
}
