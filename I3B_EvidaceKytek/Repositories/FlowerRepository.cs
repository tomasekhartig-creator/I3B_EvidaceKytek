using I3B_EvidaceKytek.Database;
using I3B_EvidaceKytek.Interfaces;
using I3B_EvidaceKytek.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3B_EvidaceKytek.Repositories
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly FlowerContext _context;

        public FlowerRepository(FlowerContext context)
        {
            _context = context;
        }

        public void AddFlower(Flower flower)
        {
            _context.Add(flower);
            _context.SaveChanges(); //toto realne ulozi zmeny do Db
        }

        public void DeleteFlower(Flower flower)
        {
            if(!_context.Flowers.Any(f => f.Id == flower.Id))
                {
                return;
            }
            try
            {
                _context.Flowers.Remove(flower);
                _context.SaveChanges();
            }
            catch
            {
                _context.Entry(flower).State = EntityState.Unchanged; // v pripade neuspechu vratime zmeny entity flower
                throw;
            }

            
        }

        public Flower Get(int? id)
        {
           if(id == null)
            
                throw new Exception("ID must be inserted!");

            return _context.Flowers.Find(id) ?? null;
        }

        public IList<Flower> GetAll()
        {
            return _context.Flowers.AsNoTracking().ToList();
        }

        public void UpdateFlower(Flower flower)
        {
            _context.Entry(flower).State = EntityState.Modified;
        }
    }
}
