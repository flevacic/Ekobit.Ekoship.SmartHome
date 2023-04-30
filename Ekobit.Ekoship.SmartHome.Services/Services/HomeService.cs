﻿using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Data.Contracts;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public IEnumerable<Home> GetAllHomes()
        {
            return _homeRepository.GetAll().ToList();
        }

        public Home? GetHomeById(int id)
        {
            return _homeRepository.GetById(id);
        }

        public int CreateHome(Home home)
        {
            var newHomeId = _homeRepository.Create(home);
            return newHomeId;
        }

        public int UpdateHome(Home home)
        {
            var newHomeId = _homeRepository.Update(home);
            return newHomeId;
        }

        public bool DeleteHome(int id)
        {
            var isDeleted = _homeRepository.Delete(id);
            return isDeleted;
        }
    }
}
