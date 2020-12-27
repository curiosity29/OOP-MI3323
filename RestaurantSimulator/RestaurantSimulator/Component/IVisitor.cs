using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    interface IVisitor
    {
        void Visit(IComponent component);
    }
}
