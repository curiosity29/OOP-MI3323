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

        //this shoulde be private, but that make it cant be modify in factory form
        public static Dictionary<string, Dish> Dict
        {
            get => dict;
        }

        public static Dish GetDish(string baseName)
        {
            if (Dict.ContainsKey(baseName)) return Dict[baseName];
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
                    Dict.Add("Mì", dish);
                    break;

                case "Cà phê":
                    baseDish = new DishPart
                    {
                        name = "Cà phê",
                        price = price_dict["Cà phê"]
                    };
                    dish = new Cafe(baseDish, new Bowl());
                    Dict.Add("Cà phê", dish);
                    break;

                case "Trà sữa":
                    baseDish = new DishPart
                    {
                        name = "Trà sữa",
                        price = price_dict["Trà sữa"]
                    };
                    dish = new MilkTea(baseDish, new Bowl());
                    Dict.Add("Trà sữa", dish);
                    break;

                case "Cơm":
                    baseDish = new DishPart
                    {
                        name = "Cơm",
                        price = price_dict["Cơm"]
                    };
                    dish = new RiceDish(baseDish, new Bowl());
                    Dict.Add("Cơm", dish);
                    break;

                default:
                    throw new ArgumentException("Error: unrecognized dish type");
            }

            return dish;
        }
    }
}
