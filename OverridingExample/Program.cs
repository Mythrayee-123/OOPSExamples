using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExample
{
    internal class Program
    {
        public virtual void M1()
        {
            Console.WriteLine("Hi this is M1 method from program class");
        }
    }
    class Program2 : Program
    {
        public override void M1()
        {
            Console.WriteLine("Hi this is M1 method from program2 class");
        }
        static void Main(string[] args)
        {
            Program2 obj2 = new Program2();
            obj2.M1();

            Program obj = obj2; // casting 
            obj.M1();
            Console.Read();
        }
    }
}
