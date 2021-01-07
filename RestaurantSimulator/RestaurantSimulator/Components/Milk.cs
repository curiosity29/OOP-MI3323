using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Milk:Component
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
        public override string ToString()
        {
            return "Milk";
        }
    }
}
