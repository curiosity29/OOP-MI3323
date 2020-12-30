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
    public partial class Kitchen_Simulator : Form
    {
        public Kitchen_Simulator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Kitchen_Simulator()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_Refrigerator().Show();
        }
    }
}
