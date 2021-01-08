﻿using System;
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

        #region init
        //(control - typename) for each type
        Dictionary<CheckedListBox, string> Menu_List;
        // (typename - list of that type) for each type
        Dictionary<string, List<string>> order = new Dictionary<string, List<string>>();
        public Dictionary<string, long> price_dict = new Dictionary<string, long>();

        List<Component> component ;
        public Form_Customer()
        {
            InitializeComponent();
            component = new List<Component>();
            string[] component_name = { "Tôm","Gà","Bò","Cá","Dừa","Sữa","Chocolate","Cacao","Khoai môn","Chân châu"};
            int[] component_quantity = { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            //for(int i = 0; i < component_name.Count(); i++)
            //{
            //    Component a = new Component();
            //    a.Name = component_name[i];
            //    a.Quantity = component_quantity[i];
            //    component.Add(a);
            //}
            //Chef chef = Chef.THeChef;
            //Manager manager = Manager.TheManager;
            //component = new List<Component>();
            //string[] component_name = { "Tôm","Gà","Bò","Cá","Dừa","Sữa","Chocolate","Cacao","Khoai môn","Chân châu"};
            //int[] component_quantity = { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            //Bubble_tea bubble_tea 

            //string output = JsonConvert.SerializeObject(component, Formatting.Indented);
            //File.WriteAllText("D:\\component.json", output);
        }
        private void Form_Load(object sender, EventArgs e)
        {
            Menu_List = new Dictionary<CheckedListBox, string>()
            {
                { Menu_Noodle, "Mì" },
                { Menu_Cafe, "Cà phê" },
                { Menu_Milktea, "Trà sữa" },
                { Menu_Rice, "Cơm" },
            };
            order = new Dictionary<string, List<string>>()
            {
                {"Mì", new List<string>() },
                {"Cà phê", new List<string>() },
                {"Trà sữa", new List<string>() },
                {"Cơm", new List<string>() }
            };
            Json<Dictionary<string,long>>.Read(price_file, ref price_dict);
            FlyFoodFactory.price_dict = price_dict;
        }

        #endregion


        private void AddOrder(object sender, EventArgs e)
        {
            var ordering = GetOrdering();
            int quantity = GetQuantity();
            int index;
            Dish dish;
            //try
            //{
                foreach (string basename in ordering.Keys)
                {
                    dish = FlyFoodFactory.GetDish(basename);
                    foreach(string addonName in ordering[basename])
                    {
                        // modify flyweight
                        dish.addon = new DishPart()
                        {
                            name = addonName,
                            price = price_dict[addonName]
                        };
                        
                        order[basename].Add(addonName);

                        ListViewItem lsItem;

                    index = listview.Items.Count;
                    index++;
                    lsItem = new ListViewItem(index.ToString());
                    lsItem.SubItems.Add(dish.baseDish.name);
                    lsItem.SubItems.Add(dish.addon.name);
                    lsItem.SubItems.Add(quantity.ToString());
                    lsItem.SubItems.Add((dish.Price*quantity).ToString());
                    lsItem.SubItems.Add(dish.tool.Name);
                    listview.Items.Add(lsItem);
                    }
                }

                //ResetList(bill);


                //MessageBox.Show(jsonString);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Error, but not crashed :D, and the error: " + ex.Message);
            //}
        }


        private void ResetListIndex()
        {
            int index = 0;
            foreach(ListViewItem lsItem in listview.Items)
            {
                index++;
                lsItem.Text = index.ToString();
            }
        }

        private int GetQuantity()
        {
            return (int)numericUpDown1.Value;
        }


        private Dictionary<string, List<string>> GetOrdering()
        {
            Dictionary<string, List<string>> ordering = new Dictionary<string, List<string>>();
            foreach (CheckedListBox list in Menu_List.Keys)
            {
                ordering[Menu_List[list]] = new List<string>();
                foreach (object obj in list.CheckedItems)
                {
                    ordering[Menu_List[list]].Add(obj.ToString());
                }
            }
            return ordering;
        }

        private void Listview_remove(object sender, EventArgs e)
        {
            var item = listview.SelectedItems[0];
            item.Remove();
            ResetListIndex();
            order[item.SubItems[1].Text].Remove(item.SubItems[2].Text);
        }

        private void Reset(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Customer().Show();
        }


        private void Order(object sender, EventArgs e)
        {
            new Form_Kitchen(this, this.text_table, this.text_bill, order).Show();

            Json<Dictionary<string, List<string>>>.Write(order_file, order);

            string jsonstring = File.ReadAllText(menu_file);

            //var a = JsonConvert.DeserializeObject<>(jsonstring);
            //text_table.Text += (a.item_list)[0].name;
        }
    }
}
