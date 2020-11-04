using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //sinhvien = FormDangNhap.sinhvien;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            string info = "";
            info += "Họ tên: " + Hoten.Text;

            info += "\nQuê quán: " + Quequan.Text;

            info +="\nNgày sinh: " + Ngaysinh.Value;

            info += "\nGiới tính: ";
            if (Male.Checked) info += Male.Text;
            if (Female.Checked) info += Female.Text;

            info += "\nFree time: ";
            if (Xemphim.Checked) info += Xemphim.Text + ", ";

            if (Choi.Checked) info += Choi.Text;
            if (NgheNhac.Checked) info += NgheNhac.Text + ", ";

            info += "\nThể thao: ";
            foreach (string s in Thethao.SelectedItems)
                info += " - " + s;

            info += "\nĐọc: ";
            foreach (string s in Doc.CheckedItems)
                info += " - " + s;


            Info.Text = info;
            //MessageBox.Show(checkedListBox1.CheckedItems[0].ToString());
        }
    }
}
