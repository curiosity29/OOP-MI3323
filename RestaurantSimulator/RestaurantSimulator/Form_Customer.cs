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
        //(control - typename) for each type
        Dictionary<CheckedListBox, string> Menu_List;
        // (typename - list of that type) for each type
        Dictionary<string, List<string>> order = new Dictionary<string, List<string>>();
        const string filename = "Data Dish.txt";
        const string price_file = "Price.txt";
        public Dictionary<string, long> price_dict = new Dictionary<string, long>();
        int index = 0;
        public Form_Customer()
        {
            InitializeComponent();

        }
        private void Form_Load(object sender, EventArgs e)
        {
            Menu_List = new Dictionary<CheckedListBox, string>()
            {
                { Menu_Noodle, "Mì" },
                { Menu_Cafe, "Cà phê" },
                { Menu_Fish, "Cá" }
            };
            ReadJson(price_file, ref price_dict);
            FlyFoodFactory.price_dict = price_dict;
        }

        public void ReadJson<T>(string file, ref T obj)
        {
            string json = File.ReadAllText(file);
            obj = JsonConvert.DeserializeObject<T>(json);
        }
        private void WriteJson<T>(string filename, T obj)
        {
            string jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filename, jsonString);
        }
        private void AddOrder(object sender, EventArgs e)
        {
            GetOrder();
            int quantity = GetQuantity();
            Menu_Item item;
            Bill bill = new Bill();
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
                WriteJson(filename, bill);
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
            listview.Items.Remove(listview.SelectedItems[0]);
        }

        private void Reset(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Customer().Show();
        }

        private void Open_Kitchen(object sender, EventArgs e)
        {
            new Form_Kitchen(this, this.text_table, this.text_bill, order).Show();
        }
    }
}
