using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {

        }

        public string FeatherColor { get; set; }

        public bool CanFly {get; set; }

        public string Diet { get; set; }

        public string BeakShape { get; set; }

    }
}
