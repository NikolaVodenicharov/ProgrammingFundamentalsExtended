using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var inputRectangle1 = ReadRectangle();
            var rectangle1 = CreateRectangle(inputRectangle1);

            var inputRectangle2 = ReadRectangle();
            var rectangle2 = CreateRectangle(inputRectangle2);

            var isInside = Rectangle.IsRectangle1InsideRectangle2(rectangle1, rectangle2);

            PrintAnswer(isInside);
        }

        private static void PrintAnswer(bool isInside)
        {
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }


        public static Rectangle CreateRectangle(double[] rectangleInfo)
        {
            return new Rectangle( rectangleInfo[0]
                                , rectangleInfo[1]
                                , rectangleInfo[2]
                                , rectangleInfo[3]);
        }

        public static double[] ReadRectangle()
        {
            return Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
        }
    }

    public class Rectangle
    {
        public double left;
        public double top;
        public double width;
        public double height;
        public double right
        {
            get {return this.left + this.width;}
        }
        double bottom
        {
            get { return this.top + this.height; }
        }

        public Rectangle (double left, double top, double width, double height)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
        }

        public static bool IsRectangle1InsideRectangle2(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle2.left <= rectangle1.left &&
                rectangle2.right >= rectangle1.right &&
                rectangle2.top <= rectangle1.top &&
                rectangle2.bottom >= rectangle1.bottom)
            {
                return true;
            }

            return false;
        }
    }
}
