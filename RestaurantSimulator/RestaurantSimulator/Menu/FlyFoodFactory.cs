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

            switch(basename)
            // how to make new instance with variable type?
            return new NoodleDish();
        }
    }
}
