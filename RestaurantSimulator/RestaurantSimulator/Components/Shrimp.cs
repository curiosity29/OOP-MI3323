using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Shrimp : Component
    {
        public override string Name
        {
            get { return "Shrimp"; }
        }
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
