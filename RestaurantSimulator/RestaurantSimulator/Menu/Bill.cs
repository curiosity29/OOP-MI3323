using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Bill
    {

        public List<Menu_Item> item_list = new List<Menu_Item>();
        public void Add(List<Menu_Item> items)
        {
            item_list.AddRange(items);
        }
        public void Add(Menu_Item item)
        {
            item_list.Add(item);
        }
    }
}
