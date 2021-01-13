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
            //số lượng
            var item_quantity = item.SubItems[3];
            //giá
            var item_price = item.SubItems[4];
            //ghi chú
            var item_note = item.SubItems[5];

            int quantity = (int)numericUpDown1.Value;

            //sửa giá tiền
            item_price.Text = (
                int.Parse(item_price.Text) * quantity / int.Parse(item_quantity.Text)
                ).ToString();

            //sửa số lượng
            item_quantity.Text = quantity.ToString();

            //sửa ghi chú
            item_note.Text = richTextBox1.Text;

            this.Close();
        }
    }
}
