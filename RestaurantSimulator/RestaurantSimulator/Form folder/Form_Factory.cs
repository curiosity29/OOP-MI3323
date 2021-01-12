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

        public Form_Factory()
        {
            InitializeComponent();
        }

        private void Form_Refrigerator_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FlyFoodFactory.dict.Values;
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

        }
    }
}
