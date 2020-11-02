using ChikenPlatesApp.Models;
using ChikenPlatesApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChikenPlatesApp.Data
{
    public class SideDishRepository : ISideDishRepository
    {
        private readonly ChickenContext _context;

        public SideDish SideDishId { get; private set; }

        public SideDishRepository(ChickenContext context)
        {
            _context = context;
        }
        public SideDish Create(SideDish sideDish)
        {
            _context.SideDishes.Add(sideDish);
            return sideDish;
        }

        public void Delete(SideDish sideDish)
        {
            _context.SideDishes.Remove(sideDish);

        }

        public SideDish Get(long sideDishId)
        {
            return _context.SideDishes.Find(sideDishId);
        }

        public IEnumerable<SideDish> GetAll()
        {
            return _context.SideDishes.ToList();
        }

        public SideDish Update(SideDish sideDish)
        {
            _context.SideDishes.Update(sideDish);
            return sideDish;
        }

       

        public void Dispose()
        {
            
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
