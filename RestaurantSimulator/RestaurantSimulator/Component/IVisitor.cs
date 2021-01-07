using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public interface IVisitor
    {
        string Visit(Fish fish);
        string Visit(Coffee coffee);
        string Visit(Carrot carrot);
        string Visit(Potato potato);
        string Visit(Noodle noodle);
    }
}
