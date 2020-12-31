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
    public partial class Form_Recipe : Form
    {

        public Form_Recipe()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red), 100, 100, 100, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
