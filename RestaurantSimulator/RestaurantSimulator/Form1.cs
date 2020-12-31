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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            (new Kitchen_Simulator()).Show();
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red), 100, 100, 100, 100);
        }


    }
}
