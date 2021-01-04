using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    class FlyFoodFactory
    {
        private Dictionary<string, Dish> dict;
        public Dish GetDish(string baseName)
        {
            if (dict.ContainsKey(baseName)) return dict[baseName];
            Dish dish;
            KeyValuePair<string, Dish> pair;
            switch(baseName)
            {
                case "Mì":
                    dish = new NoodleDish("Mì", new Bowl());
                    dict.Add("Mì", dish);
                    break;
                case "Cà phê":
                    dish = new Cafe("Cà phê", new Cup());
                    dict.Add("Cà phê", dish);
                    break;
                case "Cá":
                    dish = new Cafe("Cá", new Plate());
                    dict.Add("Cá", dish);
                    break;
                default:
                    throw new ArgumentException("Error: unrecognized dish type");
            }
            // how to make new instance with variable type?
            return dish;
        }
    }
}
