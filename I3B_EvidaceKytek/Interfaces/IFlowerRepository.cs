using I3B_EvidaceKytek.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3B_EvidaceKytek.Interfaces
{
    public interface IFlowerRepository
    {
        public void AddFlower(Flower flower);
        public void UpdateFlower(Flower flower);
        public void DeleteFlower(Flower flower);
        public Flower Get(int? id);
        public IList<Flower> GetAll();
    }
}
