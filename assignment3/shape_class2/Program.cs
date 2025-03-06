using System;
namespace shape_class2
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area() 
        { 
            return Math.PI * radius * radius; 
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width* height;
        }
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(string type, params double[] dim)
        {
            switch (type.ToLower())
            {
                case "circle":
                    return new Circle(dim[0]);
                case "rectangle":
                    return new Rectangle(dim[0], dim[1]);
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string shapeType = random.Next(2) == 0 ? "Circle" : "Rectangle";
                if (shapeType == "Circle")
                {
                    shapes.Add(ShapeFactory.CreateShape(shapeType, random.NextDouble() * 10));
                }
                else
                {
                    shapes.Add(ShapeFactory.CreateShape(shapeType, random.NextDouble() * 10, random.NextDouble() * 10));
                }
            }
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }

            Console.WriteLine($"Total area of all shapes: {totalArea}");
        }
    }
}