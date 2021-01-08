using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Bubble_tea:Component
    {
        public override string Name
        {
            get { return "Bubble_tea"; }
        }
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
