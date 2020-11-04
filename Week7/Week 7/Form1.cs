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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (userList.ContainsKey(nick.Text))
                if (pass.Text == userList[nick.Text])
                {
                    (new Form2()).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            else
                {
                    MessageBox.Show("Sai tên đăng nhập");
                }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
