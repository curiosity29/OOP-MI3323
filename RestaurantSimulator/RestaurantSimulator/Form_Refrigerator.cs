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
    public partial class Form_Refrigerator : Form
    {
        Refrigerator refrigerator;
        public Form_Refrigerator()
        {
            InitializeComponent();
        }

        private void Form_Refrigerator_Load(object sender, EventArgs e)
        {
            refrigerator = new Refrigerator();
            refrigerator.list_component = new List<Component>()
            {
                //new Carrot()
                //{
                //    Name = "cà rốt",
                //    Status = "OK"
                //}
                //, new Fish()
                //{
                //    Name = "Cá",
                //    Status = "Tươi"
                //}
                //, new Potato()
                //{
                //    Name = "Củ khoai",
                //    Status = "Mọc mầm"
                //}
            };
            dataGridView1.DataSource = refrigerator.list_component;
            
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selectedProp = dataGridView1.SelectedRows[0].DataBoundItem as Component;
   

            }
            catch(Exception ex)
            {
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
