using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program()
        {
            var a = new Vecto3D(2, -1, 3);
            var b = new Vecto3D(1, 2, 4);
            Console.WriteLine("Tich co huong a va b la: ");
            (a / b).print();

            var c = new Vecto3D(5, 2, -3);
            var d = new Vecto3D(4, 5, -6);
            double volume = (
                (b - a) * ((c - a) / (d - a))
                );
            Console.WriteLine("the tich: " + volume);
        }
    }

    public class Diem3D
    {
        public double x, y, z;
        public double length;
        
        public Diem3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static double GetDistance(Diem3D diem1, Diem3D diem2)
        {
            var v1 = new Vecto3D(diem1);
            var v2 = new Vecto3D(diem2);
            return (v2 - v1).Getlength();
        }
    }
    public class Vecto3D
    {
        public double x, y, z;
        public Vecto3D()
        {
        }
        public Vecto3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vecto3D(Diem3D diem)
        {
            this.x = diem.x;
            this.y = diem.y;
            this.z = diem.z;
        }
        public Vecto3D(Diem3D diem1, Diem3D diem2)
        {
            this.x = diem2.x - diem1.x;
            this.y = diem2.y - diem1.y;
            this.z = diem2.z - diem1.z;
        }
        public static Vecto3D operator + (Vecto3D v1, Vecto3D v2)
        {
            var v = new Vecto3D();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        public static Vecto3D operator - (Vecto3D v1, Vecto3D v2)
        {
            var v = new Vecto3D();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        public static double operator * (Vecto3D v1, Vecto3D v2)
        {
            return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
        }
        public static Vecto3D operator / (Vecto3D v1, Vecto3D v2)
        {
            var v = new Vecto3D();
            v.x = v1.y * v2.z - v1.z * v2.y;
            v.y = v1.z * v2.x - v1.x * v2.z;
            v.z = v1.x * v2.y - v1.y * v2.x;
            return v;
        }
        public double Getlength()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public static double Angle(Vecto3D v1, Vecto3D v2)
        {
            return Math.Acos( (v1 * v2) / (v1.Getlength() * v2.Getlength() ) );
        }
        public static Vecto3D operator * (Vecto3D v, double k)
        {
            return new Vecto3D(v.x * k, v.y * k, v.z * k);
        }

        public static Vecto3D Bisection(Vecto3D v1, Vecto3D v2)
        {
            return ((v1 * v2.Getlength()) + (v2 * v1.Getlength()));
        }

        public void print()
        {
            Console.Write("({0},{1},{2})", this.x, this.y, this.z);
        }
    }
}
