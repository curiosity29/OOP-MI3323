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
        delegate void ClickHandler(object sender, MouseEventArgs e);
        Graphics g, g1;
        Pen pen = new Pen(Color.Red, 3);
        Stack<Point> pointStack = new Stack<Point>();
        Point[] pointList = new Point[4];
        Bitmap bitmap;
        ClickHandler clickHandler;
        public Paint()
        {
            InitializeComponent();
            g1 = pictureBox.CreateGraphics();
            clickHandler = new ClickHandler(Mark_circle);
            Reset();
        }
        private void Reset()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox.Image = bitmap;
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
        private static Point Subtract(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        #endregion

        #region draw

        private void Draw_hbh_regis(object sender, EventArgs e)
        {
            clickHandler = new ClickHandler(Mark_circle);
            pointStack.Clear();
            clickHandler += Draw_hbh;
        }
        private void Draw_hbh(object sender, EventArgs e)
        {
            if (pointStack.Count > 2)
            {
                for (int i = 2; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                Draw_hbh(pen, pointList);
            }
        }

        private void Draw_hbh(Pen pen, Point[] pointList)
        {
            Draw_hbh(pen, pointList[0], pointList[1], pointList[2]);
        }
        /// <summary>
        ///     p1--------p3
        ///    /         /   
        ///   /         /
        ///  p2--------p4
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
            if (pointStack.Count > 3)
            {
                for (int i = 3; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                Draw_hhbh(pen, pointList);
            }
        }
        private void Draw_hhbh_regis(object sender, EventArgs e)
        {
            clickHandler = new ClickHandler(Mark_circle);
            pointStack.Clear();
            clickHandler += Draw_hhbh;
        }
        /// <summary>
        ///    p11-------p13
        ///    /|        /|
        ///   / |       / |
        /// p12-------p14 |
        ///  |  |      |  |
        ///  |  p1-----|--p3
        ///  | /       | /   
        ///  |/        |/
        ///  p2--------p4
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="pointList"></param>
        private void Draw_hhbh(Pen pen, Point[] pointList)
        {
            //pen.DashStyle = DashStyle.Dash;
            pointList = Hhbh_normalize(pointList);
            for (int i = 1; i < 4; i++)
                g.DrawLine(pen, pointList[0], pointList[i]);
            //pen.DashStyle = DashStyle.Dash;

            Point p4 = Add(pointList[1],
                    Subtract(pointList[2], pointList[0]));
            Point Height = Subtract(pointList[3], pointList[0]);
            Point p12 = Add(pointList[1], Height);
            Point p13 = Add(pointList[2], Height);
            Point p14 = Add(p4, Height);

            Draw_hbh(pen, p14, p12, p13);
            Draw_hbh(pen, p14, p12, p4);
            Draw_hbh(pen, p14, p13, p4);
        }
        //underconstruction ... 
        private Point[] Hhbh_normalize(Point[] pointList)
        {
            Point Height = Subtract(pointList[3], pointList[0]);
            float y0 = pointList[0].Y;
            Point p4 = Add(pointList[1],
                    Subtract(pointList[2], pointList[0]));
            if (pointList[1].Y > y0)
            {
                if (pointList[2].Y > y0)
                    return pointList;   //take p1
                else
                {   //take p3
                    Swap(ref pointList[0], ref pointList[2]);
                    pointList[1] = p4;
                    pointList[3] = Add(pointList[0], Height);
                }
            }
            else if (pointList[2].Y > y0)
            {   //take p2
                Swap(ref pointList[0], ref pointList[1]);
                pointList[2] = p4;
                pointList[3] = Add(pointList[0], Height);
            }
            else
            {   //take p4
                pointList[0] = p4;
                pointList[3] = Add(pointList[0], Height);
            }
            if (Height.Y > 0)
            {
                Swap(ref pointList[0], ref pointList[3]);
                pointList[1] = Add(pointList[1], Height);
                pointList[2] = Add(pointList[2], Height);
            }
            return pointList;
        }
        private void Swap(ref Point a, ref Point b)
        {
            Point temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        ///    p11-------p13
        ///    /|        /|
        ///   / |       / |
        /// p12-------p14 |
        ///  |  |      |  |
        ///  |  p1-----|--p3
        ///  | /       | /   
        ///  |/        |/
        ///  p2--------p4
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

        #endregion


        private void PictureBox_Click(object sender, MouseEventArgs e)
        {
            // draw red dot and save click location
            pointStack.Push(e.Location);
            clickHandler(sender, e);
        }
        private void Mark_circle(object sender, MouseEventArgs e)
        {
            g1.DrawEllipse(pen, e.X, e.Y, 3, 3);
        }
        #region file

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

        #endregion

        private void Redraw_regis(object sender, EventArgs e)
        {
            pointStack.Clear();
            clickHandler = new ClickHandler(Mark_circle);
            clickHandler += Redraw;
        }
        private void Redraw(object sender, EventArgs e)
        {
            int index = comboBox_redraw.SelectedIndex;
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


        #region calculate something

        private Vector2 Normalize_Vector(Point a, Point b,
            Point pointO, Vector2 vectorI, Vector2 vectorJ)
        {
            Vector2 ab = new Vector2(b.X - a.X, b.Y - a.Y);
            var coordinate = Pt2An.Solve(vectorI.X, vectorI.Y, vectorJ.X, vectorJ.Y, ab.X, ab.Y);
            return new Vector2((float)coordinate[0], (float)coordinate[1]);
        }
        private double Calculate_Volume(Point p1, Point p2, Point p3, Point p11,
            Point pointO, Vector2 vectorI, Vector2 vectorJ, Vector2 vectorK)
        {
            Vector2 v12 = Normalize_Vector(p1, p2, pointO, vectorI, vectorJ);
            Vector2 v13 = Normalize_Vector(p1, p3, pointO, vectorI, vectorJ);
            Vector2 v14 = Normalize_Vector(p1, p11, pointO, vectorI, vectorJ);
            return Calculate_Volume(
                new Vector3(v12.X, v12.Y, 0),
                new Vector3(v13.X, v13.Y, 0),
                new Vector3(v14.X, 0, (p11.Y - p1.Y) / vectorK.Y)
                );
        }
        private double Calculate_Volume(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            return Math.Abs(Dot(v1, Cross(v2, v3)));
        }

        #endregion

        #region hard coding
        Point pointO = new Point(505, 376);
        Vector2 vectorI = new Vector2(347 / 8f, 69 / 8f);
        Vector2 vectorJ = new Vector2(200 / 8f, -118 / 8f);
        Vector2 vectorK = new Vector2(0, -235 / 5);

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

        private void Clear(object sender, EventArgs e)
        {
            Reset();
        }

        private void ShowPoint(object sender, MouseEventArgs e)
        {
            // vector from 0 to mouse location
            Vector2 v = Normalize_Vector(pointO, e.Location, pointO, vectorI, vectorJ);
            textBox_X.Text = v.X.ToString();
            textBox_Y.Text = v.Y.ToString();
            textBox1.Text = (e.X - pointO.X).ToString();
            textBox2.Text = (e.Y - pointO.Y).ToString();
        }

        private double Calculate_Area(Point p1, Point p2, Point p3, Point p11,
            Point pointO, Vector2 vectorI, Vector2 vectorJ, Vector2 vectorK)
        {
            Vector2 v12 = Normalize_Vector(p1, p2, pointO, vectorI, vectorJ);
            Vector2 v13 = Normalize_Vector(p1, p3, pointO, vectorI, vectorJ);
            Vector2 v14 = Normalize_Vector(p1, p11, pointO, vectorI, vectorJ);
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
