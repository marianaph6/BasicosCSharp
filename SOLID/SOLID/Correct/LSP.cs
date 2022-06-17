using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Correct
{
    internal class LSP
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}

