using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3B_EvidaceKytek.models
{
    public class Flower
    {
        public int Id { get; set; } // PK v DB
        public string Name { get; set; }
        public string Genus { get; set; }
        public string Color { get; set; }


        public override string? ToString()
        {
            return $"{Name} ({Genus}, {Color})";
        }
    }

    
}
