using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReusability
{
    internal class Program
    {
        public void Palindrome()
        {
            Console.WriteLine("enter a string");
            string response = Console.ReadLine();
            response = response.ToLower();
            string reverseString = "";
            for (int i = response.Length - 1; i >= 0; i--)
            {
                reverseString += response[i];
            };
            if (response == reverseString)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
    class Program2 : Program   // Single Inheritence // Levl-1
    {
    }
    class Program3 : Program2  // Level-2
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Palindrome();

            Program2 obj2 = new Program2();
            obj2.Palindrome();

            Console.ReadLine();

        }
    }
}
