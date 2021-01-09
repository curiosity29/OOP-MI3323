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
    public partial class Form_ModifyItem : Form
    {
        ListViewItem item;
        public Form_ModifyItem(ListViewItem item)
        {
            InitializeComponent();
            this.item = item;
            listview.Items.Add((ListViewItem)item.Clone());
        }

        private void Modify(object sender, EventArgs e)
        {
            item.SubItems[3].Text = numericUpDown1.Value.ToString();
            item.SubItems[5].Text = richTextBox1.Text;
            this.Close();
        }
    }
}
