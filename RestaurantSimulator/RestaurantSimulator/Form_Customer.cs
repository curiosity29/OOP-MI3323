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
        Dictionary<CheckedListBox, string> Menu_List;
        const string filename = "Data Dish.txt";
        const string prize_file = "Prize.txt";
        Dictionary<string, long> prize_dict = new Dictionary<string, long>()
        {
            //{ "Mì Xào gà", 100 }
        }
        ;
        public Form_Customer()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new Form_Kitchen(this, this.text_table, this.text_bill).Show();
            Menu_List = new Dictionary<CheckedListBox, string>()
            {
                { Menu_Noodle, "Mì" },
                { Menu_Cafe, "Cà phê" },
                { Menu_Fish, "Cá" }
            };
            LoadMenu(prize_file);
        }

        public void LoadMenu(string file_prize)
        {
            string json = File.ReadAllText(prize_file);
            prize_dict = JsonConvert.DeserializeObject<Dictionary<string, long>>(json);
            //File.WriteAllText(prize_file, JsonConvert.SerializeObject(prize_dict));
        }
        private void Order(object sender, EventArgs e)
        {
            List<string> order = GetOrder();
            string jsonString = "";
            int index = 0;
            int quantity = GetQuantity();
            Menu_Item item;
            Bill bill = new Bill();
            //try
            //{
                foreach (object obj in order)
                {
                    item = new Menu_Item()
                    {
                        index = ++index,
                        dish = obj.ToString(),
                        quantity = quantity,
                        prize = prize_dict[obj.ToString()],
                        note = "nothing"
                    };
                    bill.Add(item);
                }

                AddToList(bill);
                jsonString = JsonConvert.SerializeObject(bill);
                WriteMenuToFile(jsonString);
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
                lsItem.SubItems.Add(item.dish);
                lsItem.SubItems.Add(item.quantity.ToString());
                lsItem.SubItems.Add(item.prize.ToString());
                lsItem.SubItems.Add(item.note);

                listview.Items.Add(lsItem);
            }
        }

        private int GetQuantity()
        {
            return (int)numericUpDown1.Value;
        }


        private List<string> GetOrder()
        {
            List<string> order = new List<string>();

            foreach (CheckedListBox list in Menu_List.Keys)
            {
                foreach (object obj in list.CheckedItems)
                {
                    order.Add(Menu_List[list] + " " + obj.ToString());
                }

            }

            return order;
        }
        private void WriteMenuToFile(string jsonString)
        {
            try
            {
                File.WriteAllText(filename, jsonString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listview_remove(object sender, EventArgs e)
        {
            listview.Items.Remove(listview.SelectedItems[0]);
        }
    }
}
