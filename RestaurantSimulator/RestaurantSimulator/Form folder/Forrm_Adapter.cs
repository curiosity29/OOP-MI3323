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
    public partial class Forrm_Adapter : Form
    {
        List<component_refrigerator> component_refrigerator;
        public Forrm_Adapter(List<component_refrigerator> component_refrigerator)
        {
            InitializeComponent();
            this.component_refrigerator = component_refrigerator;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Forrm_Adapter_Load(object sender, EventArgs e)
        {
            foreach (component_refrigerator r in component_refrigerator)
            {
                listBox1.Items.Add(r.Name);
            }
            foreach (component_refrigerator r in component_refrigerator)
            {
                listBox2.Items.Add(r.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected_list_box_1 = (string)listBox1.SelectedItem;
            string selected_list_box_2 = (string)listBox2.SelectedItem;
            int i = 0;
            Dictionary<string, string> adapt_component;
            string json = File.ReadAllText("..\\..\\DataSource\\adapter_component.json");
            adapt_component = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);
            foreach(string a in adapt_component.Keys.ToList())
            {
                if(a == selected_list_box_1)
                {
                    adapt_component[a] = selected_list_box_2;
                    i = 1;
                }
            }
            if (i == 0)
            {
                adapt_component.Add(selected_list_box_1, selected_list_box_2);
            }
            string jsonString = JsonConvert.SerializeObject(adapt_component, Formatting.Indented);
            File.WriteAllText("..\\..\\DataSource\\adapter_component.json", jsonString);
            this.Close();
        }
    }
}
