using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Chef
    {
        private static Chef chef;
        string dataBase = "data.txt";
        Dictionary<string, Recipe> recipe_dict;
        Dictionary<string, Addon> dict;
        private Chef()
        {
            // get data
        }
        //singleton
        public static Chef THeChef
        {
            get => chef;
        }
        public Dish MakeDish(string name)
        {
            Recipe recipe;
            if (dict.ContainsKey(name))
            {
                recipe = recipe_dict[name];
                //take components, could be different from recipe since manager could have adapted
                List<Component> component_List = Manager.TheManager.GetComponents(recipe.component_List);

            }
            else
            {
                recipe = Make_Recipe(name);
                recipe_dict.Add(name, recipe);
            }
            return recipe.Cook();
        }
        //extentsion for completely new Dish, not yet
        public Recipe Make_Recipe(string name)
        {
            throw new NotImplementedException();
        }
    }
}
