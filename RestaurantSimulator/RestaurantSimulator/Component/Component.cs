using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{

    public abstract class Component
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public abstract void Accept();
    }
}
