using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Recipe
    {

        public List<Component> component_List;
        public string Name;
        public Recipe(string Name)
        {
            component_List = new List<Component>();
            this.Name = Name;
        }
        public Recipe(List<Component> component_List, string Name)
        {
            this.component_List = component_List;
            this.Name = Name;
        }
        public Recipe()
        {
            component_List = new List<Component>();
            Name = "";
        }
        public override string ToString()
        {
            return Name;
        }
        public Dish Cook()
        {
            throw new NotImplementedException();
        }
    }
}
