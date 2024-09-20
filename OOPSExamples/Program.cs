using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPSExamples
{
    internal class Employee
    {
        int empid;  //Declaration
        string empname = "Dasharad";  // Intialization

        public void Hello()
        {
            int x = 100;
            Console.WriteLine("Hello Welcome to oops concepts");
        }
        public void M1()
        {

        }
        public void CaliculateEMI()
        {

            //10-20 line code 
        }
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


            Console.ReadLine();
        }
        public void Palindrome1()
        {

            Console.WriteLine("enter a string");
            string response = Console.ReadLine();
            response = response.ToLower();
            //Compare the  charecters
            bool IsPalindrome = true;
            int firstcharecter = 0;
            int lastcharecter = response.Length - 1;

            do
            {

                if (response[firstcharecter] != response[lastcharecter])
                {
                    IsPalindrome = false;

                    break;

                }
                firstcharecter++;
                lastcharecter--;
            } while (firstcharecter < lastcharecter);
            if (IsPalindrome)
            {

                Console.WriteLine("It is  a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }
            Console.ReadLine();

        }
        public void PrinNumber()
        {
            for (int k = 1; k <= 12; k++)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
        public void EvenNumber()
        {
            int i = 0;

            for (i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


        }
        public void OddNumber()
        {
            int i = 0;

            for (i = 0; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


        }
        public void ReverseString()
        {
            Console.WriteLine("Enter a string");
            string Reverse = Console.ReadLine();
            for (int i = Reverse.Length - 1; i >= 0; i--)
            {


                Console.Write(Reverse[i]);
            }
            Console.ReadLine();

        }
        public void PrintNumbersInCircle()
        {
            int radius = 5;
            double dist;

            for (int i = 0; i <= 2 * radius; i++)
            {
                for (int j = 0; j <= 2 * radius; j++)
                {
                    dist = Math.Sqrt((i - radius) * (i - radius) + (j - radius) * (j - radius));

                    if (dist > radius - 0.5 && dist < radius + 0.5)
                    {

                        Console.Write("*");



                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            } Console.ReadLine();
        }
        public void PrimeNumbers()
        {

            Console.WriteLine("Below are prime numbers between 0 and 100!");
           
            for (int i = 2; i <= 10; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= 10; j++)
                {
                    if ((i % j == 0) && (i!=j))
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }Console.ReadLine();
        }

         public void displaynumbers()
        {
            int i;
           for ( i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
           
            Console.ReadLine();
        }
        
        public void Pyramid()
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)  //Rows 
            {
                // Print spaces left side 
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //classname object name= new classname();
            Employee obj = new Employee();
            //obj.Palindrome();
            //obj.Palindrome1();
            // obj.PrinNumber();
            //obj.PrintNumbersInCircle();
            //obj.OddNumber();
            //obj.ReverseString();
            // obj.PrintNumbersInCircle();
            //obj.Pyramid();
            //obj.PrimeNumbers();
            obj.displaynumbers();
        }
    }
}
