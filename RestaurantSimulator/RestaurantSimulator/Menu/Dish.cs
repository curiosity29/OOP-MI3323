using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public abstract class Dish
    {
        public DishPart baseDish;
        public DishPart addon;
        public string FullName { get => baseDish.name + " " + addon.name; }
        public long Price { get => (long)(0.95 * (baseDish.price + addon.price)); }
        public Component tool;
        public Dish(DishPart baseDish, Component tool)
        {
            this.baseDish = baseDish;
            this.tool = tool;
        }
    }
}
