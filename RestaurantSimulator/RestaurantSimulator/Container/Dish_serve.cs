using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Dish_serve
    {
        List<component_refrigerator> component_refrigerator;
        public Dish_serve(List<component_refrigerator> component_refrigerators)
        {
            this.component_refrigerator = component_refrigerators;
        }
        public Recipe base_food;
        public Recipe topping_food;
        public Dish_serve(Recipe base_food, Recipe topping_food)
        {
            this.base_food = base_food;
            this.topping_food = topping_food;
        }
        public Recipe get_base_food()
        {
            return this.base_food;
        }
        public Recipe get_topping_food()
        {
            return this.topping_food;
        }
        Form_MakeDish a = new Form_MakeDish();
        
    }             
}      

