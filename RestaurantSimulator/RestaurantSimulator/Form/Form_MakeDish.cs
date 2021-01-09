using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace RestaurantSimulator
{
    public partial class Form_MakeDish : Form
    {
        List<Recipe> recipes1;
        List<Recipe> recipes2;
        public Form_MakeDish()
        {
            InitializeComponent();
        }
        public void Write_recpies_to_json(string filename, object recipes)
        {
            string data = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(filename, data);
        }
        public List<Recipe> Read_recipes_from_Json(string filename)
        {
            List<Recipe> recipes = new List<Recipe>();
            string raw = File.ReadAllText(filename);
            try
            {
                dynamic list = JsonConvert.DeserializeObject<dynamic>(raw);
                if (list != null)
                {
                    foreach (dynamic element in list)
                    {
                        Recipe recipe1 = new Recipe((string)element.Name);
                        foreach (dynamic c in element.component_List)
                        {
                            Component component;
                            if (c.Name == "Fish")
                            {
                                component = new Fish();
                            }
                            else if (c.Name == "Carrot")
                            {
                                component = new Carrot();
                            }
                            else if (c.Name == "Potato")
                            {
                                component = new Potato();
                            }
                            else if (c.Name == "Chicken")
                            {
                                component = new Chicken();
                            }
                            else if (c.Name == "Coconut")
                            {
                                component = new Coconut();
                            }
                            else if (c.Name == "Coffee")
                            {
                                component = new Coffee();
                            }
                            else if (c.Name == "Milk")
                            {
                                component = new Milk();
                            }
                            else if (c.Name == "Noodle")
                            {
                                component = new Noodle();
                            }
                            else if (c.Name == "Shrimp")
                            {
                                component = new Shrimp();
                            }
                            else if (c.Name == "Taro")
                            {
                                component = new Taro();
                            }
                            else if (c.Name == "Rice")
                            {
                                component = new Rice();
                            }
                            else if (c.Name == "Bubble tea")
                            {
                                component = new Bubble_tea();
                            }
                            else if (c.Name == "Tea")
                            {
                                component = new Tea();
                            }
                            else
                            {
                                throw new Exception();
                            }
                            component.Quantity = c.Quantity;
                            foreach (dynamic v in c.visitors)
                            {
                                IVisitor visitor;
                                if (v.Type == 1)
                                {
                                    visitor = new ChopVisitor();
                                }
                                else if (v.Type == 2)
                                {
                                    visitor = new FryVisitor();
                                }
                                else if (v.Type == 3)
                                {
                                    visitor = new WashVisitor();
                                }
                                else if (v.Type == 4)
                                {
                                    visitor = new BoilVisitor();
                                }
                                else
                                {
                                    throw new Exception();
                                }
                                component.visitors.Add(visitor);
                            }
                            recipe1.component_List.Add(component);
                        }
                        recipes.Add(recipe1);
                    }
                }      
            }
            catch
            {
                //
            }
            return recipes;
        }

        private void Form_MakeDish_Load(object sender, EventArgs e)
        {
            recipes1 = Read_recipes_from_Json(@"D:\Test2.json");
            recipes2 = Read_recipes_from_Json(@"D:\Test.json");
            foreach (Recipe r in recipes1)
            {
                listbox1.Items.Add(r.Name);
            }
            foreach (Recipe r in recipes2)
            {
                listbox2.Items.Add(r.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recipes1.RemoveAt(listbox1.SelectedIndex);
            listbox1.Items.RemoveAt(listbox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Write_recpies_to_json(@"D:\Test2.json", recipes1);
                Write_recpies_to_json(@"D:\Test.json", recipes2);
                Write_recpies_to_json(@"D:\T2.json", recipes1[listbox1.SelectedIndex]);
                Write_recpies_to_json(@"D:\T.json", recipes2[listbox2.SelectedIndex]);
                Recipe recipe1 = recipes1[listbox1.SelectedIndex];
                Recipe recipe2 = recipes2[listbox2.SelectedIndex];
                //Refrigerator refrigerator = new Refrigerator();
                string json = File.ReadAllText("D:\\read_re_re.json");
                List<component_refrigerator> component_refrigerator = JsonConvert.DeserializeObject<List<component_refrigerator>>(json);
                int i;
                foreach (component_refrigerator a in component_refrigerator)
                {
                    if (a.Name == recipe1.component_List[0].Name)
                    {
                        i = a.quantity - recipe1.component_List[0].Quantity;
                        if (i <= 0)
                        {
                            if (MessageBox.Show("Out-of-stock " + a.Name + "Do you want to adapt " + a.Name + "?", "INFORM",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            a.quantity = i;
                        }
                    }
                    else if (a.Name == recipe2.component_List[0].Name)
                    {
                        i = a.quantity - recipe2.component_List[0].Quantity;
                        if (i <= 0)
                        {
                            MessageBox.Show("Out-of-stock " + a.Name, "INFORM");
                        }
                        else
                        {
                            a.quantity = i;
                        }
                    }
                }
                string jsonString = JsonConvert.SerializeObject(component_refrigerator, Formatting.Indented);
                File.WriteAllText("D:\\read_re_re.json", jsonString);
                MessageBox.Show("The dish has cooked", "INFORM");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose item to cook");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recipes2.RemoveAt(listbox2.SelectedIndex);
            listbox2.Items.RemoveAt(listbox2.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Refrigerator().Show();
        }
    }
}
