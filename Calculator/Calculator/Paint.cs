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
using System.Drawing.Drawing2D;

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
            g1 = pictureBox.CreateGraphics();
            Reset();
        }
        private void Reset()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bitmap);
        }
        #region helper
        public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
        {
            return new Vector3(
                vector1.Y * vector2.Z - vector1.Z * vector2.Y,
                vector1.Z * vector2.X - vector1.X * vector2.Z,
                vector1.X * vector2.Y - vector1.Y * vector2.X);
        }

        public static float Dot(Vector3 vector1, Vector3 vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
        }
        public double VectorLength(Vector3 v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }
        private static Point Add(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        #endregion
        private void Draw_hbh(object sender, EventArgs e)
        {
            try
            {
                for (int i = 2; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                Draw_hbh(pen, pointList);
            }
            catch (Exception)
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


        private void PictureBox_Click(object sender, MouseEventArgs e)
        {
            pointStack.Push(e.Location);
            g1.DrawEllipse(pen, e.X, e.Y, 3, 3);
        }

        private void SaveAs(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("This file is not OK");
                }
        }

        private void Redraw(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            try
            {
                pointList[index] = pointStack.Pop();
                Reset();
                Draw_hhbh(pen, pointList);

            }
            catch (Exception)
            {
                MessageBox.Show("mark your point first");
            }
        }


        private Vector2 Calculte_Coordinate(Point a, Point b,
            Point pointO, Vector2 vectorI, Vector2 vectorJ)
        {
            Vector2 ab = new Vector2(b.X - a.X, b.Y - a.Y);
            var coordinate = Pt2An.Solve(vectorI.X, vectorI.Y, vectorJ.X, vectorJ.Y, ab.X, ab.Y);
            return new Vector2((float)coordinate[0], (float)coordinate[1]);
        }
        private double Calculate_Volume(Point p1, Point p2, Point p3, Point p11,
            Point pointO, Vector2 vectorI, Vector2 vectorJ, Vector2 vectorK)
        {
            Vector2 v12 = Calculte_Coordinate(p1, p2, pointO, vectorI, vectorJ);
            Vector2 v13 = Calculte_Coordinate(p1, p3, pointO, vectorI, vectorJ);
            Vector2 v14 = Calculte_Coordinate(p1, p11, pointO, vectorI, vectorJ);
            return Calculate_Volume(
                new Vector3(v12.X, v12.Y, 0),
                new Vector3(v13.X, v13.Y, 0),
                new Vector3(v14.X, v14.Y, (p11.Y - p1.Y) / vectorK.Y)
                );
        }
        private double Calculate_Volume(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            return Math.Abs(Dot(v1, Cross(v2, v3)));
        }


        #region hard coding
        Point pointO = new Point(505, 376);
        Vector2 vectorI = new Vector2(43.375f, -8.625f);
        Vector2 vectorJ = new Vector2(24.875f, 15.125f);
        Vector2 vectorK = new Vector2(0, -47);

        private void Calculate_Volume(object sender, EventArgs e)
        {
            MessageBox.Show(Calculate_Volume(
                pointList[0], pointList[1], pointList[2], pointList[3],
                pointO, vectorI, vectorJ, vectorK).ToString());
        }



        private void Calculate_Area(object sender, EventArgs e)
        {
            MessageBox.Show(Calculate_Area(
                pointList[0], pointList[1], pointList[2], pointList[3],
                pointO, vectorI, vectorJ, vectorK).ToString());
        }

        private double Calculate_Area(Point p1, Point p2, Point p3, Point p11,
            Point pointO, Vector2 vectorI, Vector2 vectorJ, Vector2 vectorK)
        {
            Vector2 v12 = Calculte_Coordinate(p1, p2, pointO, vectorI, vectorJ);
            Vector2 v13 = Calculte_Coordinate(p1, p3, pointO, vectorI, vectorJ);
            Vector2 v14 = Calculte_Coordinate(p1, p11, pointO, vectorI, vectorJ);
            Vector3 v1 = new Vector3(v12.X, v12.Y, 0);
            Vector3 v2 = new Vector3(v13.X, v13.Y, 0);
            Vector3 v3 = new Vector3(v14.X, v14.Y, (p11.Y - p1.Y) / vectorK.Y);
            return 2 * VectorLength(Cross(v1, v2)) + 
                2 * VectorLength(Cross(v1, v3)) + 
                2 * VectorLength(Cross(v2, v3));

        }
        #endregion
    }
}
