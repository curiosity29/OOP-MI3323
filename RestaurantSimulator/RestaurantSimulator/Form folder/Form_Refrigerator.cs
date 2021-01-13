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
            refrigerator.list_component = new List<component_refrigerator>();
            //{
            //    new component_refrigerator()
            //    {
            //        Name = "cà rốt",
            //        quantity = 50,
            //    }
            //    , new component_refrigerator()
            //    {
            //        Name = "cà chua",
            //        quantity = 50,
            //    }
            //    , new component_refrigerator()
            //    {
            //        Name = "khoai tây",
            //        quantity = 50,
            //    }
            //};
            string json = File.ReadAllText(@"..\..\DataSource\read_re_re.json");
            refrigerator.list_component = JsonConvert.DeserializeObject<List<component_refrigerator>>(json);
            //string jsonString = JsonConvert.SerializeObject(refrigerator.list_component, Formatting.Indented);
            //File.WriteAllText("D:\\read_re_re.json", jsonString);
            dataGridView1.DataSource = refrigerator.list_component;


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selectedProp = dataGridView1.SelectedRows[0].DataBoundItem as Component;


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

        private void button1_Click(object sender, EventArgs e)
        {
            refrigerator.list_component = (List<component_refrigerator>)dataGridView1.DataSource;
            string jsonString = JsonConvert.SerializeObject(refrigerator.list_component, Formatting.Indented);
            File.WriteAllText(@"..\..\DataSource\read_re_re.json", jsonString);
            dataGridView1.ReadOnly = true;
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void Remove(object sender, EventArgs e)
        {
            refrigerator.list_component.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dataGridView1.DataSource = refrigerator.list_component;
            //private void button3_Click(object sender, EventArgs e)
            //{
            //    new Forrm_Adapter(refrigerator.list_component).Show();
            //}

            //private void button3_Click(object sender, EventArgs e)
            //{
            //        new Forrm_Adapter(refrigerator.list_component).Show();
            //    }
        }

        private void button_adapter_Click(object sender, EventArgs e)
        {
            new Forrm_Adapter(refrigerator.list_component).Show();
        }
    }
}
