using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle("hinh tron");
            circle.radius = 10;
            Console.WriteLine("" + circle.calculateArea());
            
        }
    }
    public interface ShapeInterface_1
    {
        
        public bool st
        {
            get;
        }
        int doSomething();
    }
    public interface ShapeInterface_2
    {
        //void doSomething();
    }
    public abstract class Shape : ShapeInterface_2
    {
        protected string name;
        public Shape()
        {

        }
        public Shape(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public abstract double calculateArea();
        
        void doSomething()
        {

        }
    }

    class Circle : Shape
    {
        public Circle(string name):base()
        {
            
        }
        public double radius;

        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Square : Shape
    {
        public double side;
        public override double calculateArea()
        {
            return side * side;
        }
    }
}
