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
    public partial class Form_Kitchen : Form
    {
        bool OK = false;
        Form_Customer form_customer;
        Dictionary<string, List<string>> order;
        public Form_Kitchen(Form_Customer form_customer, Dictionary<string, List<string>> order)
        {
            InitializeComponent();
            this.form_customer = form_customer;
            this.order = order;
            try
            {
                text_holding.Text = Serve_next();
            }
            catch(Exception)
            {
                MessageBox.Show("Đề nghị có món để đầu bếp còn làm");
                this.Close();
            }

        }
        
        private string Serve_next()
        {
            foreach(string key in order.Keys)
            {
                if(order[key].Count != 0)
                {
                    string s = order[key][0];
                    order[key].RemoveAt(0);
                    return key + " " + s;
                }    
            }
            throw new Exception();
        }

        private void EditRecipe(object sender, EventArgs e)
        {
            new Form_Recipe().Show();
        }

        private void Serve(object sender, EventArgs e)
        {
            //text_table.Text += text_holding.Text + "\n";
            try
            {
                if(OK)
                {
                    form_customer.Serve(text_holding.Text + "\n");
                    text_holding.Text = Serve_next();
                    OK = false;
                }
                else
                {
                    MessageBox.Show("Đơi nhà bếp một tí, đang làm");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đề nghị có món để đầu bếp còn làm");
                this.Close();
                form_customer.Show();
            }
            
        }

        private void MakeDish(object sender, EventArgs e)
        {
            Form_MakeDish frm = new Form_MakeDish();
            frm.ShowDialog();
            OK = frm.OK;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form_Recipe_2().Show();
        }

        private void Open_Factory(object sender, EventArgs e)
        {
            new Form_Factory().Show() ;
        }
    }
}
