using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Cafe : Dish
    {
        public Cafe(DishPart baseDish, Bowl tool) : base(baseDish, tool)
        {

        }
    }
}
