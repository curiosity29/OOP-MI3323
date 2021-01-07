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
                    dish = new Cafe(baseDish, new Bowl());
                    dict.Add("Cà phê", dish);
                    break;
                case "Trà sữa":
                    baseDish = new DishPart
                    {
                        name = "Trà sữa",
                        price = price_dict["Trà sữa"]
                    };
                    dish = new MilkTea(baseDish, new Bowl());
                    dict.Add("Trà sữa", dish);
                    break;
                case "Cơm":
                    baseDish = new DishPart
                    {
                        name = "Cơm",
                        price = price_dict["Cơm"]
                    };
                    dish = new RiceDish(baseDish, new Bowl());
                    dict.Add("Cơm", dish);
                    break;
                default:
                    throw new ArgumentException("Error: unrecognized dish type");
            }
            // how to make new instance with variable type?
            return dish;
        }
    }
}
