using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class FlyFoodFactory
    {
        public static Dictionary<string, long> price_dict = new Dictionary<string, long>();

        private static Dictionary<string, Dish> dict = new Dictionary<string, Dish>();

        public static Dish GetDish(string baseName)
        {
            if (dict.ContainsKey(baseName)) return dict[baseName];
            Dish dish;
            DishPart baseDish;
            switch (baseName)
            {
                case "Mì":
                    baseDish = new DishPart 
                    { 
                        name = "Mì", 
                        price = price_dict["Mì"] 
                    };
                    dish = new NoodleDish(baseDish, new Bowl());
                    dict.Add("Mì", dish);
                    break;
                case "Cà phê":
                    baseDish = new DishPart
                    {
                        name = "Cà phê",
                        price = price_dict["Cà phê"]
                    };
                    dish = new NoodleDish(baseDish, new Bowl());
                    dict.Add("Cà phê", dish);
                    break;
                case "Cá":
                    baseDish = new DishPart
                    {
                        name = "Cá",
                        price = price_dict["Cá"]
                    };
                    dish = new NoodleDish(baseDish, new Bowl());
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
