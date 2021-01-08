using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{

    public abstract class Component
    {
        public List<IVisitor> visitors = new List<IVisitor>();
        public virtual string Name { get; }

        public abstract string Accept(IVisitor visitor);
        public int Quantity { get; set; }
    }
    
}
