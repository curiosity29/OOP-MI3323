using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Cafe : Dish
    {
        public Cafe(DishPart baseDish, Component tool) : base(baseDish, tool)
        {

        }
    }
}
