using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExample
{
    internal class Program
    {
        /// <summary>
        ///     This methos will return Area of a square
        /// </summary>
        /// <param name="a"></param>
        public void Area(int a)
        {
            Console.WriteLine("Area Of a Square" + (a * a));
        }
        /// <summary>
        ///      This methos will return Area of a Rectangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Area(int a, int b)
        {
            Console.WriteLine("Area Of a Rectangle " + (a * b));
        }
        /// <summary>
        ///    This methos will return Area of a  Trinagle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Area(int a, int b, int c)
        {
            Console.WriteLine("Area of a Trinagle" + (a * b * c));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Area(10);
            Console.Read();
        }
    }
}
