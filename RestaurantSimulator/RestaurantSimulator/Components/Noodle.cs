using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Noodle : Component
    {
        public override string Name
        {
            get { return "Noodle"; }
        }
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

    }
}
