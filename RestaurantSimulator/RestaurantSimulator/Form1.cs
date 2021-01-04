using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
namespace RestaurantSimulator
{
    public partial class Form1 : Form
    {
        List<CheckedListBox> Menu_List;
        const string filename = "Data Dish.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Order(object sender, EventArgs e)
        {
            List<string> order = GetOrder();
            string jsonString = "";
            foreach (object obj in order)
            {
                listview.Items.Add(obj.ToString());
                jsonString += obj.ToString();
            }

            WriteMenuToFile(jsonString);
            MessageBox.Show(jsonString);
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

        private List<string> GetOrder()
        {
            List<string> order = new List<string>();
            foreach(CheckedListBox list in Menu_List)
            {
                foreach(object obj in list.CheckedItems)
                {
                    order.Add(obj.ToString());
                }
            }
            return order;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Kitchen_Simulator().Show();
            Menu_List = new List<CheckedListBox>()
            {
                Menu_Noodle, Menu_Cafe, Menu_Fish
            };
        }
    }
}
