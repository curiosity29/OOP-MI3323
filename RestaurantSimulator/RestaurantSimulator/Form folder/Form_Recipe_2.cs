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
    public partial class Form_Recipe_2 : Form
    {
        string Current_Component;

        List<Component> listcomponents = new List<Component>();
        bool new_component = false;
        public Form_Recipe_2()
        {
            InitializeComponent();
            Current_Component = "";
            listboxComponent.SelectedIndex = 0;
        }
        private Component GetComponent(string item)
        {
            switch (item)
            {
                case "Tea":
                    {
                        return new Tea();
                    }
                case "Noodle":
                    {
                        return new Noodle();
                    }
                case "Rice":
                    {
                        return new Rice();
                    }
                case "Coffee":
                    {
                        return new Coffee();
                    }
                case "Milk":
                    {
                        return new Milk();
                    }
                default:
                    {
                        throw new Exception();
                    }
            }
        }
        private IVisitor GetVisitor(string item)
        {
            switch (item)
            {
                case "Wash":
                    {
                        return new WashVisitor();
                    }
                case "Fry":
                    {
                        return new FryVisitor();
                    }
                case "Chop":
                    {
                        return new ChopVisitor();
                    }
                case "Boil":
                    {
                        return new BoilVisitor();
                    }
                default:
                    {
                        throw new Exception();
                    }
            }
        }

            private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            new_component = true;
            if (listcomponents.Count != 0)
            {
                Component component = listcomponents[listcomponents.Count - 1];
                listcomponents.RemoveAt(listcomponents.Count - 1);
            }
            foreach (Component component1 in listcomponents)
            {
                richTextBox1.Text += component1.Name + ":\n";
                foreach (IVisitor visitor in component1.visitors)
                {
                    richTextBox1.Text += "\t" + component1.Accept(visitor) + "\n";
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            try
            {
                if (new_component)
                {

                    Current_Component = (string)listboxComponent.SelectedItem;
                    listcomponents.Add(GetComponent(Current_Component));
                    listcomponents[listcomponents.Count - 1].Quantity = (int)numericUpDown1.Value;
                    richTextBox1.Text += Current_Component + ":\n";
                    new_component = false;
                }
                richTextBox1.Text += "\t" + listcomponents[listcomponents.Count - 1].Accept(GetVisitor(button.Text)) + "\n";
                listcomponents[listcomponents.Count - 1].visitors.Add(GetVisitor(button.Text));
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
            catch (Exception)
            {
                //
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe(listcomponents, textBox1.Text);
            List<Recipe> recipes = new List<Recipe>();
            try
            {
                string raw = File.ReadAllText(@"..\..\DataSource\Test2.json");
                dynamic list = JsonConvert.DeserializeObject<dynamic>(raw);
                if (list != null)
                {
                    foreach (dynamic element in list)
                    {
                        Recipe recipe1 = new Recipe((string)element.Name);
                        foreach (dynamic c in element.component_List)
                        {
                            Component component;
                            if (c.Name == "Noodle")
                            {
                                component = new Noodle();
                            }
                            else if (c.Name == "Rice")
                            {
                                component = new Rice();
                            }
                            else if (c.Name == "Coffee")
                            {
                                component = new Coffee();
                            }
                            else if (c.Name == "Tea")
                            {
                                component = new Tea();
                            }
                            else if (c.Name == "Milk")
                            {
                                component = new Milk();
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
            recipes.Add(recipe);
            string data = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(@"D:\Test2.json", data);
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new_component = true;
            show_component.Text = numericUpDown1.Value + " " + listboxComponent.Text;
        }
    }
}
