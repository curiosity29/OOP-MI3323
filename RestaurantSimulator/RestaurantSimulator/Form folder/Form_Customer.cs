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
        #region data
        const string file_menu = @"..\..\DataSource\Menu.json";
        const string file_price = @"..\..\DataSource\Price.json";
        const string file_order = @"..\..\DataSource\Order.json";
        const string file_special = @"..\..\DataSource\Special.json";
        #endregion


        #region init
        //(control - typename) for each type
        Dictionary<CheckedListBox, string> Menu_List;
        // (typename - list of that type) for each type
        Dictionary<string, List<string>> order = new Dictionary<string, List<string>>();
        //(dishname - price)
        public Dictionary<string, long> price_dict = new Dictionary<string, long>();

        private Dictionary<string, List<string>> order_special;
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
                { Menu_Milktea, "Trà sữa" },
                { Menu_Rice, "Cơm" },
            };

            NewOrder();
            // read menu price
            try
            {
                //read price order
                Json<Dictionary<string, long>>.Read(file_price, ref price_dict);
                Form_Factory.price_dict = price_dict;
                //read special order
                Json<Dictionary<string, List<string>>>.Read(file_special, ref order_special);
            }
            catch
            {
                MessageBox.Show("Không load được file");
            }
        }

        internal void Serve(string food)
        {
            m_txt_table.Text += food + "\n";
        }

        private void NewOrder()
        {
            order = new Dictionary<string, List<string>>()
            {
                {"Mì", new List<string>() },
                {"Cà phê", new List<string>() },
                {"Trà sữa", new List<string>() },
                {"Cơm", new List<string>() }
            };
        }
        #endregion


        #region control sequence
        private void AddOrder(object sender, EventArgs e)
        {
            var ordering = GetOrdering();
            int quantity = GetQuantity();
            string note = GetNote();
            int index = listview.Items.Count;
            AddOrder(ordering, index, quantity, note);
        }
        private void Modify_Item(object sender, EventArgs e)
        {
            try
            {

                var item = listview.SelectedItems[0];
                new Form_ModifyItem(item).Show();
            }
            catch
            {
                //
            }
        }


        private void Listview_remove(object sender, EventArgs e)
        {

            try
            {
                var item = listview.SelectedItems[0];
                item.Remove();
                ResetListIndex();
                int quantity = int.Parse(item.SubItems[3].Text);

            }
            catch
            {
                //
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            this.Hide();
            //this.Refresh();
            new Form_Customer().Show();
        }


        
        private void Order_Special(object sender, EventArgs e)
        {
            var ordering = order_special;
            int quantity = GetQuantity();
            string note = GetNote();
            int index = listview.Items.Count;
            AddOrder(ordering, index, quantity, note);
            Order();
        }


        #endregion


        #region intersection
        private void Order(object sender, EventArgs e)
        {
            this.Hide();
            Order();
        }


        #endregion


        #region method
        private void Order()
        {

            // make order from item in listview
            foreach (ListViewItem item in listview.Items)
            {
                order[item.SubItems[1].Text].Add(item.SubItems[2].Text);
            }

            //lưu file order
            Json<Dictionary<string, List<string>>>.Write(file_order, order);

            //bật bếp
            try
            {
                this.Hide();
                new Form_Kitchen(this, order).ShowDialog();
                this.Show();
            }
            catch
            {
                this.Hide();
                new Form_Feature().Show();
                this.Show();
            }

            NewOrder();

        }

        private void AddOrder(Dictionary<string, List<string>> ordering, int index, int quantity, string note)
        {
            Dish dish;
            try
            {
                foreach (string basename in ordering.Keys)
                {
                    if (ordering[basename].Count == 0) continue;

                    dish = Form_Factory.GetDish(basename);
                    foreach (string addonName in ordering[basename])
                    {
                        // modify flyweight
                        dish.addon = new DishPart()
                        {
                            name = addonName,
                            price = price_dict[addonName]
                        };
                        ListViewItem lsItem;

                        index++;
                        lsItem = new ListViewItem(index.ToString());
                        lsItem.SubItems.Add(dish.baseDish.name);
                        lsItem.SubItems.Add(dish.addon.name);
                        lsItem.SubItems.Add(quantity.ToString());
                        lsItem.SubItems.Add((dish.Price * quantity).ToString());
                        lsItem.SubItems.Add(note);
                        listview.Items.Add(lsItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error upon adding item, and the error is: " + ex.Message);
            }
        }
        private void ResetListIndex()
        {
            int index = 0;
            foreach (ListViewItem lsItem in listview.Items)
            {
                index++;
                lsItem.Text = index.ToString();
            }
        }
        private string GetNote()
        {
            return richTextBox_note.Text;
        }
        private int GetQuantity()
        {
            return (int)numericUpDown1.Value;
        }
        private Dictionary<string, List<string>> GetOrdering()
        {
            Dictionary<string, List<string>> ordering 
                = new Dictionary<string, List<string>>();
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

        #endregion
    }
}
