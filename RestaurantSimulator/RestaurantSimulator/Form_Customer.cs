using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace RestaurantSimulator
{
    public partial class Form_Customer : Form
    {
        const string menu_file = "..\\..\\DataSource\\Menu.json";
        const string price_file = "..\\..\\DataSource\\Price.json";
        const string order_file = "..\\..\\DataSource\\Order.json";

        //(control - typename) for each type
        Dictionary<CheckedListBox, string> Menu_List;
        // (typename - list of that type) for each type
        Dictionary<string, List<string>> order = new Dictionary<string, List<string>>();
        public Dictionary<string, long> price_dict = new Dictionary<string, long>();

        Bill bill = new Bill();
        int index = 0;

        List<Component> component ;
        Menu_Item item_all;
        public Form_Customer()
        {
            InitializeComponent();
            
            component = new List<Component>();
            string[] component_name = { "Tôm","Gà","Bò","Cá","Dừa","Sữa","Chocolate","Cacao","Khoai môn","Chân châu"};
            int[] component_quantity = { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            for(int i = 0; i < component_name.Count(); i++)
            {
                Component a = new Component();
                a.Name = component_name[i];
                a.Quantity = component_quantity[i];
                component.Add(a);
            }
            string output = JsonConvert.SerializeObject(component, Formatting.Indented);
            File.WriteAllText("D:\\component.json", output);
        }
        private void Form_Load(object sender, EventArgs e)
        {
            Menu_List = new Dictionary<CheckedListBox, string>()
            {
                { Menu_Noodle, "Mì" },
                { Menu_Cafe, "Cà phê" },
                { Menu_Fish, "Cá" }
            };
            Json<Dictionary<string,long>>.Read(price_file, ref price_dict);
            FlyFoodFactory.price_dict = price_dict;
        
        }

        
        private void AddOrder(object sender, EventArgs e)
        {
            GetOrder();
            int quantity = GetQuantity();
            Menu_Item item;
            Dish dish;
            //try
            //{
                foreach (string basename in order.Keys)
                {
                    dish = FlyFoodFactory.GetDish(basename);
                    foreach(string addonName in order[basename])
                    {
                        // modify flyweight
                        dish.addon = new DishPart()
                        {
                            name = addonName,
                            price = price_dict[addonName]
                        };
                        
                        item = new Menu_Item()
                        {
                            index = ++index,
                            name = dish.FullName,
                            price = dish.Price,
                            quantity = quantity,
                            tool = dish.tool.Name
                        };
                        bill.Add(item);
                    }
                }

                AddToList(bill);
                Json<Bill>.Write(menu_file, bill);
            Json<Bill>.Write(menu_file, bill);
                //MessageBox.Show(jsonString);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Error, but not crashed :D, and the error: " + ex.Message);
            //}
        }


        private void AddToList(Bill bill)
        {
            ListViewItem lsItem;
            foreach(Menu_Item item in bill.item_list)
            {
                lsItem = new ListViewItem(item.index.ToString());
                lsItem.SubItems.Add(item.name);
                lsItem.SubItems.Add(item.quantity.ToString());
                lsItem.SubItems.Add(item.price.ToString());
                lsItem.SubItems.Add(item.tool);

                listview.Items.Add(lsItem);
            }
        }

        private int GetQuantity()
        {
            return (int)numericUpDown1.Value;
        }


        private void GetOrder()
        {
            foreach (CheckedListBox list in Menu_List.Keys)
            {
                order[Menu_List[list]] = new List<string>();
                foreach (object obj in list.CheckedItems)
                {
                    order[Menu_List[list]].Add(obj.ToString());
                }
            }
        }

        private void Listview_remove(object sender, EventArgs e)
        {
            var item = listview.SelectedItems[0];

            listview.Items.Remove(item);
            bill.item_list.RemoveAt(item.Index);
        }

        private void Reset(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Customer().Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Order(object sender, EventArgs e)
        {
            new Form_Kitchen(this, this.text_table, this.text_bill, order).Show();

            Json<Dictionary<string, List<string>>>.Write(order_file, order);
            string jsonstring = File.ReadAllText(menu_file);

            var a = JsonConvert.DeserializeObject<Bill>(jsonstring);
            text_table.Text += (a.item_list)[0].name;
        }
    }
}
