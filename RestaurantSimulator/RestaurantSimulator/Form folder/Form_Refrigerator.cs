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
        BindingList<component_refrigerator> list ;
        public Form_Refrigerator()
        {
            InitializeComponent();
        }

        private void Form_Refrigerator_Load(object sender, EventArgs e)
        {
            refrigerator = new Refrigerator();
            refrigerator.list_component = new List<component_refrigerator>();
            
            string json = File.ReadAllText(@"..\..\DataSource\read_re_re.json");
            refrigerator.list_component = JsonConvert.DeserializeObject<List<component_refrigerator>>(json);
           
            list = new BindingList<component_refrigerator>(refrigerator.list_component);
           
            dataGridView1.DataSource = list;


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
            refrigerator.list_component = list.ToList();
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
            try
            {
                var row = dataGridView1.SelectedRows[0];
                var component = row.DataBoundItem as component_refrigerator;
                list.RemoveAt(row.Index);

            }
            catch
            {
                
            }


        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            new Forrm_Adapter(refrigerator.list_component).Show();
        }
    }
}
