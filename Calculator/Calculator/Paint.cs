using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math;

namespace Calculator
{
    public partial class Paint : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Red, 3);
        List<Point> pointList = new List<Point>();
        public Paint()
        {
            InitializeComponent();
            g = panel.CreateGraphics();
        }

        private void Draw_hbh(object sender, EventArgs e)
        {
            Point p1 = pointList[0];
            Point p2 = pointList[1];
            Point p3 = pointList[2];
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            Draw_hbh(pen, p1, p2, p3);
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
        }

        private void Draw_hhbh(object sender, EventArgs e)
        {
            Point p1 = pointList[0];
            Point p2 = pointList[1];
            Point p3 = pointList[2];
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            Point p11 = pointList[3];
            Draw_hhbh(pen, p1, p2, p3, p11);
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


        }
        private static Point Add(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        private void Panel_Click(object sender, MouseEventArgs e)
        {
            pointList.Add(e.Location);
            g.DrawEllipse(pen, e.X, e.Y, 3, 3);
        }
    }
}
