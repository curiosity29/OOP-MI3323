using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Chef
    {
        public Chef chef;
        string dataBase = "data.txt";
        List<Recipe> recipe_List;
        private Chef()
        {
            // get data
        }
        //singleton
        Chef THeChef
        {
            get => chef;
        }
        public Dish Cook(string DishName)
        {
            throw new NotImplementedException();
        }
    }
}
