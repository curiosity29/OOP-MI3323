using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSimulator.Method;
namespace RestaurantSimulator
{
    public partial class Form_Recipe : Form
    {
        string Current_Component;

        List<Component> listcomponents = new List<Component>();
        public Form_Recipe()
        {
            InitializeComponent();
            Current_Component = "";
            listboxComponent.SelectedIndex = 0;
        }
        private Component GetComponent(string item)
        {
            switch (item)
            {
                case "Fish":
                    {
                        return new Fish();
                    }
                case "Noodle":
                    {
                        return new Noodle();
                    }
                case "Carrot":
                    {
                        return new Carrot();
                    }
                case "Coffee":
                    {
                        return new Coffee();
                    }
                case "Potato":
                    {
                        return new Potato();
                    }
                default:
                    {
                        throw new Exception();
                    }
            }    
        }
        private IVisitor GetVisitor (string item)
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
                default:
                    {
                        throw new Exception();
                    }
            }
        }



        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Current_Component != (string)listboxComponent.SelectedItem)
            {

                Current_Component = (string)listboxComponent.SelectedItem;
                listcomponents.Add(GetComponent(Current_Component));
                richTextBox1.Text += Current_Component + ":\n";
            }
            richTextBox1.Text += "\t" + listcomponents[listcomponents.Count - 1].Accept(GetVisitor(button.Text)) + "\n";
            listcomponents[listcomponents.Count - 1].visitors.Add(GetVisitor(button.Text));
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if(listcomponents.Count != 0)
            {
                Component component = listcomponents[listcomponents.Count - 1];
                listcomponents.RemoveAt(listcomponents.Count - 1);
                if(component.visitors.Count > 1)
                {
                    component.visitors.RemoveAt(component.visitors.Count-1);
                    listcomponents.Add(component);
                }    
            }    
            foreach(Component component1 in listcomponents)
            {
                richTextBox1.Text += component1.ToString() + ":\n";
                foreach(IVisitor visitor in component1.visitors)
                {
                    richTextBox1.Text += "\t" + component1.Accept(visitor) + "\n";
                }    
            }    
        }
    }
}
