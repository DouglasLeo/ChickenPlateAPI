using ChikenPlatesApp.Models;
using ChikenPlatesApp.Models.Repositories;
using ChikenPlatesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChikenPlatesApp.Services
{
    public class SideDishServices : ISideDishService
    {
        private readonly ISideDishRepository _repo;
        public SideDishServices(ISideDishRepository repo)
        {
            _repo = repo;
        }

        public ISideDishRepository Repo { get; }

        public SideDish Create(SideDish sideDish)
        {
            return _repo.Create(sideDish);
        }

        public void Delete(long sideDishId)
        {
            throw new NotImplementedException();
        }

        public SideDish Get(long sideDishId)
        {
            return _repo.Get(sideDishId);
        }

        public List<SideDish> GetAll()
        {
            return _repo.GetAll().ToList();
        }

        public void SaveChanges()
        {
            _repo.SaveChanges();
        }

        public SideDish Update(SideDish sideDish)
        {
            throw new NotImplementedException();
        }
    }
}
