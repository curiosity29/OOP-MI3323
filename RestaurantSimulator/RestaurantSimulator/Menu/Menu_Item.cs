using System.Collections.Generic;
namespace RestaurantSimulator
{
    public class Menu_Item
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public long price { get; set; }
        public string tool { get; set; }

    }
   public class Response
    {
        public List<Menu_Item> response_data { get; set; }
    }
}