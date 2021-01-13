using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Dish_adapter
    {
        public Recipe base_food;
        public Recipe topping_food;
        public Dish_adapter(Recipe base_food, Recipe topping_food)
        {
            this.base_food = base_food;
            this.topping_food = topping_food;
        }
    }
}
