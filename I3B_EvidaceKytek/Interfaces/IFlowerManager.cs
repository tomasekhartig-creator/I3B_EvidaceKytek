using I3B_EvidaceKytek.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3B_EvidaceKytek.Interfaces
{
    public interface IFlowerManager
    {
        public void Add(Flower flower);
        public void Remove(Flower flower);
        public Flower GetById(int? id);
        public IList<Flower> GetAll();
        public void Update(Flower flower);
    }
}
