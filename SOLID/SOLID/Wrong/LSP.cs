using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Wrong
{
    internal class LSPWrong
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Circle();
            Console.WriteLine(triangle.GetColor());
        }
    }

    public class Triangle
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }

        internal bool GetColor()
        {
            throw new NotImplementedException();
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

