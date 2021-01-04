using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public abstract class Dish
    {
        protected string baseName;
        public string addonName;
        public string FullName { get => baseName + " " + addonName; }
        public Addon addon;
        public long price;
        protected Component tool;
        public Dish(string baseName, Component tool)
        {
            this.baseName = baseName;
            this.tool = tool;
        }
    }
}
