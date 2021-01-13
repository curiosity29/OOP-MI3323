using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestaurantSimulator
{
    public partial class Form_Factory : Form
    {
        BindingList<Dish> list = new BindingList<Dish>();
        public Form_Factory()
        {
            InitializeComponent();
        }

        private void Form_Factory_Load(object sender, EventArgs e)
        {
            var dict = FlyFoodFactory.Dict;
            foreach(KeyValuePair<string,Dish> pair in dict)
            {
                list.Add(pair.Value);
            }
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selectedProp = dataGridView1.SelectedRows[0].DataBoundItem as Dish;


            }
            catch (Exception)
            {

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void Remove(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            var dish = row.DataBoundItem as Dish;

            list.RemoveAt(row.Index);
            FlyFoodFactory.Dict.Remove(dish.baseDish.name);
        }
    }
}
