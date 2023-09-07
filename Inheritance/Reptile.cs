using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {

        }

        public string Habitat { get; set; }

        public bool IsVenomous { get; set; }

        public string Diet { get; set; }

        public int AverageWeight { get; set; }
    }
}
