using I3B_EvidaceKytek.Interfaces;
using I3B_EvidaceKytek.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3B_EvidaceKytek.Managers
{
    public class FlowerManager : IFlowerManager
    {
        private readonly IFlowerRepository _Repository;
        public FlowerManager(IFlowerRepository repository)
        {
            _Repository = repository;
        }
        public void Add(Flower flower)
        {
            _Repository.AddFlower(flower);
        }

        public IList<Flower> GetAll()
        {
            return _Repository.GetAll();
        }

        public Flower GetById(int? id)
        {
            return _Repository.Get(id);
        }

        public void Remove(Flower flower)
        {
            _Repository.DeleteFlower(flower);
        }

        public void Update(Flower flower)
        {
            throw new NotImplementedException();
        }
    }
}
