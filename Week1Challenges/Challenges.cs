using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void ChallengesTest()
        {
            string firstName = "Connor";
            string lastName = "Braeger";
            int age = 26;

            string[] favoriteVideoGamesArray = { "Final Fantasy VII", "Legend of Zelda: Breath of the Wild", "Super Smash Brothers Ultimate", "Hades" };
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime currentDate = DateTime.Now;
            DateTime myBirthday = new DateTime(1994, 8, 20);
            DateTime luckyDate = new DateTime(1977, 7, 7);
            listOfDates.Add(currentDate);
            listOfDates.Add(myBirthday);
            listOfDates.Add(luckyDate);

            int sum = age + 7;
            Console.WriteLine(sum);

            int diff = age - 7;
            Console.WriteLine(diff);

            int prod = age * 7;
            Console.WriteLine(prod);

            int quot = age / 7;
            Console.WriteLine(quot);

            int remainder = age % 7;
            Console.WriteLine(remainder);

            Console.WriteLine("Please provide the number of hours of sleep you get a night:");
            //string sleepHoursString = Console.ReadLine();
            //int sleepHoursInt = Int32.Parse(sleepHoursString);

            int sleepHours = 9;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (sleepHours < 8 && sleepHours > 4)
            {
                Console.WriteLine("Bummer!");

            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string dayGrade = "Great";

            switch (dayGrade)
            {
                case "Great":
                    Console.WriteLine("That is Amazing!");
                    break;

                case "Good":
                    Console.WriteLine("I'm glad to hear that!");
                    break;
                case "Okay":
                    Console.WriteLine("Could always be worse!");
                    break;
                case "Bad":
                    Console.WriteLine("I'm sorry to hear that!");
                    break;
                case ":(":
                    Console.WriteLine("You need a drink!");
                    break;


            }
        }
        
    }
}
