using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing.Imaging;

namespace Calculator
{
    public partial class Paint : Form
    {
        Graphics g, g1;
        Pen pen = new Pen(Color.Red, 3);
        Stack<Point> pointStack = new Stack<Point>();
        Point[] pointList = new Point[4];
        Bitmap bitmap;
        public Paint()
        {
            InitializeComponent();
            
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g1 = pictureBox.CreateGraphics();
        }

        private void Draw_hbh(object sender, EventArgs e)
        {
            try
            {
                for (int i = 2; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                Draw_hbh(pen, pointList);
            }
            catch(Exception)
            {
                MessageBox.Show("mark your point first");
            }
        }

        private void Draw_hbh(Pen pen, Point[] pointList)
        {
            Draw_hbh(pen, pointList[0], pointList[1], pointList[2]);
        }
        /// <summary>
        ///     p2--------p4
        ///    /         /   
        ///   /         /
        ///  p1--------p3
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        private void Draw_hbh(Pen pen, Point p1, Point p2, Point p3)
        {
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p4, p2);
            g.DrawLine(pen, p4, p3);
            pictureBox.Image = bitmap;
        }

        private void Draw_hhbh(object sender, EventArgs e)
        {
            try
            {
                for (int i = 3; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                Draw_hhbh(pen, pointList);
            }
            catch (Exception)
            {
                MessageBox.Show("mark your point first");
            }
        }
        private void Draw_hhbh(Pen pen, Point[] pointList)
        {
            Draw_hhbh(pen, pointList[0], pointList[1], pointList[2], pointList[3]);
        }

        /// <summary>
        ///    p12-------p14
        ///    /|        /|
        ///   / |       / |
        /// p11-------p13 |
        ///  |  |      |  |
        ///  |  p2-----|--p4
        ///  | /       | /   
        ///  |/        |/
        ///  p1--------p3
        ///  </summary>
        /// <param name="pen"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p11"></param>
        private void Draw_hhbh(Pen pen, Point p1, Point p2, Point p3, Point p11)
        {
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            Point p1ToP11 = new Point(p11.X - p1.X, p11.Y - p1.Y);
            Point p12 = Add(p2, p1ToP11);
            Point p13 = Add(p3, p1ToP11);
            Point p14 = Add(p4, p1ToP11);

            Draw_hbh(pen, p1, p2, p3);
            Draw_hbh(pen, p11, p12, p13);
            g.DrawLine(pen, p1, p11);
            g.DrawLine(pen, p2, p12);
            g.DrawLine(pen, p3, p13);
            g.DrawLine(pen, p4, p14);
            pictureBox.Image = bitmap;
        }
        private static Point Add(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        private void PictureBox_Click(object sender, MouseEventArgs e)
        {
            pointStack.Push(e.Location);
            g1.DrawEllipse(pen, e.X, e.Y, 3, 3);
        }

        private void SaveAs(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);
                //bmp.Save(@"C:\Users\doman\OneDrive\Desktop\bitmap.jpg");
                bmp.Save(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch(Exception)
                {
                    MessageBox.Show("This file is not OK");
                }
        }
        private void Clean()
        {
            g.Clear(Color.White);
            pictureBox.Image = bitmap;
        }
        private void Redraw(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            try
            {
                pointList[index] = pointStack.Pop();
                Clean();
                Draw_hhbh(pen, pointList);
                
            }
            catch(Exception)
            {
                MessageBox.Show("mark your point first");
            }
        }

        private double Calculate_Volume(Point p1, Point p2, Point p3, Point p11)
        {
            Vector2 v12 = new Vector2(p2.X - p1.X, p2.Y - p1.Y);
            //Vector2 v23 = new Vector2(p2.)

            throw new NotImplementedException();
        }
    }
}
