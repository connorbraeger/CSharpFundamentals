using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit \"Y\" then enter to continue or hit \"N\" then enter to Clear the Console and continue ");

            string UserInput = Console.ReadLine();
            if (UserInput == "Y")
            {
                KeyToContinue();
            }
            else if (UserInput == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm going to close the program when you hit enter");
            }

            

            KeyToContinueWithClearConsole();
            Console.ReadLine();

            //Functions below this line

            void KeyToContinue()
            {


                Console.WriteLine("Hit Enter to continue on with the code...");
                Console.ReadLine();
            }
            void ClearConsole(){           
            Console.Clear();
            
            }
            void KeyToContinueWithClearConsole(){

                KeyToContinue();
                ClearConsole();
            }
        }
    }


}
            //acts as our program's .exe file, aka executable. This is the file we double click on to start any program

            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class
            //Console.WriteLine("Congratulations! You've cleared the console!");