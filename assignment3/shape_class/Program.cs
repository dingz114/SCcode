using System;
namespace shape_class
{ 
   internal class Program
    {
        abstract class Shape
        {
            public double x, y;
            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public abstract double getArea();
            public abstract bool isLegal();
        }
        class Rectangle : Shape
        {
            public Rectangle(double width, double height) : base(width, height)
            {
            }
            public override double getArea()
            {
                return x * y;
            }
            public override bool isLegal()
            {
                if (x != y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Circle : Shape
        {
            double radius;
            public Circle(double radius) : base(radius, radius)
            {
                this.radius = radius;
            }
            public override double getArea()
            {
                return Math.PI * radius * radius;
            }
            public override bool isLegal()
            {
                if (radius > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Square : Rectangle
        {
            double side;
            public Square(double side) : base(side, side)
            {
                this.side = side;
            }
            public override double getArea()
            {
                return side * side;
            }
            public override bool isLegal()
            {
                if (side > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Triangle : Shape
        {
            double c;
            public Triangle(double a, double b, double c) : base(a, b)
            {
                this.c = c;
            }
            public override double getArea()
            {
                double p = (x + y + c) / 2;
                return Math.Sqrt(p * (p - x) * (p - y) * (p - c));
            }
            public override bool isLegal()
            {
                if (x + y > c && x + c > y && y + c > x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10, 20);
            if (r1.isLegal()) Console.WriteLine("长方形合法，面积："+r1.getArea());
            Circle c1 = new Circle(10);
            if (c1.isLegal()) Console.WriteLine("圆形合法，面积："+c1.getArea());
            Square s1 = new Square(10);
            if (s1.isLegal()) Console.WriteLine("正方形合法，面积："+s1.getArea());
            Triangle t1 = new Triangle(20,20,90);
            if (t1.isLegal()) Console.WriteLine("三角形合法，面积："+t1.getArea());
        }
    }
}
