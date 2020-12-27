using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public abstract class Dish
    {
        public string name;
        public Recipe recipe;
        public AddOn addOn;
        public long price;
        public IComponent container;
    }
}
