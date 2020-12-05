using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsReviewQuiz3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
            DateTime mybd = new DateTime(1994, 8, 20);
            test.AgeFromBirthday(mybd);
            Console.ReadKey();
            DateTime date = new DateTime(1994, 12, 10);
            test.AgeFromBirthday(date);
            Console.ReadKey();
            test.FizzBuzz(50);
            Console.ReadKey();
            string intstring = "2";
            int testInt = test.Parser(intstring);
            Console.WriteLine(testInt);
            Console.ReadLine();
            string name = "connor";
            test.Greeting(name);
            double testdouble =test.IntDivider(12, 5);
            Console.WriteLine(testdouble);
            Console.ReadLine();
            int compare = test.CompareInts(100, 2);
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
    class MyClass
    {
        public void AgeFromBirthday(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear >= birthday.DayOfYear)
            {
                Console.WriteLine(age);
            }
            else
            {
                age = age - 1;
                Console.WriteLine(age);
            }

        }
        public void FizzBuzz(int number)
        {
            for (int testNum = 1; testNum <= number; testNum++)
            {
                if ((testNum % 3 == 0) & ((testNum % 5 == 0)))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (testNum % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((testNum % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {

                    Console.WriteLine(testNum);
                }
            }
        }public int Parser(string input)
        {
            return int.Parse(input);
        }
        public void Greeting(string name)
        {
            Console.WriteLine($"Good Morning {name}!");
        }
        public double IntDivider(int num1, int num2)
        {
            double doub1 = (double)num1;
            double doub2 = (double)num2;
            double doubQuot = doub1 / doub2;
            return doubQuot;
        }
        public int CompareInts(int num1, int num2)
        {
            int largerInt = num1 > num2 ? num1 : num2;
            return largerInt;
        }
    }
}
