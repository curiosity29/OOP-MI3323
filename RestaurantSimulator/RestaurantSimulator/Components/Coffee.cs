using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Coffee : Component
    {
        public override string Name
        {
            get { return "Coffee"; }
        }
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

    }
}
