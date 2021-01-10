using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public interface IVisitor
    {
        string Visit(Tea tea);
        string Visit(Bubble_tea bubble_tea);
        string Visit(Taro taro);
        string Visit(Milk milk);
        string Visit(Coconut coconut);
        string Visit(Chicken chicken);
        string Visit(Fish fish);
        string Visit(Shrimp shrimp);

        string Visit(Coffee coffee);
        string Visit(Carrot carrot);
        string Visit(Potato potato);
        string Visit(Noodle noodle);
        string Visit(Rice rice);
        string Visit(Beef beef);
    }
}
