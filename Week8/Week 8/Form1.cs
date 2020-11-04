using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult _dr = DialogResult.None;
            //_dr = MessageBox.Show("Bạn đã nhấn nút", "Thông báo", MessageBoxButtons.YesNoCancel);
            switch (_dr)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    label1.Text = "Yes";
                    break;
                case DialogResult.No:
                    label1.Text = "No";
                    break;
                default:
                    break;
            }
            OpenFileDialog _ofd = new OpenFileDialog();
            _dr = _ofd.ShowDialog();
            switch (_dr)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    label1.Text = "OK";
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    label1.Text = "Yes";
                    break;
                case DialogResult.No:
                    label1.Text = "No";
                    break;
                default:
                    break;
            }
        }
        Graphics _g;
        Pen _redPen;
        Pen _whitePen;
        Point old = new Point(0, 0);
        private void Draw()
        {
            _redPen = new Pen(Color.Red, 3);
            _whitePen = new Pen(Color.WhiteSmoke, 3);

            Point p2 = new Point(350, 450);
            Point p1 = new Point(300, 400);

            Rectangle _r = new Rectangle(250, 350, 50, 50);

            _g.DrawEllipse(_redPen, _r);
            _g.DrawRectangle(_redPen, _r);
            Brush _br = new SolidBrush(Color.Green);

            _g.FillEllipse(_br, _r);
            _g.DrawLine(_redPen, p1, p2);
            _g.DrawLine(_redPen, 300, 450, 350, 450);
            _g.DrawLine(_redPen, 200, 400, 350, 450);
        }
        private void Draw(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void MouseMoving(object sender, MouseEventArgs e)
        {
            if (_g != null)
            {
                Point p1 = new Point(0,0);
                _g.DrawLine(_whitePen, old, p1);
                Point p2 = e.Location;
                _g.DrawLine(_redPen, p1, p2);
                old = p2;
                Draw();
                DangerZone();
            }
        }

        private void DangerZone()
        {
            _g.RotateTransform(-0.02f);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _g = panel1.CreateGraphics();
        }

        private void stop(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {

            }
        }
    }
}
