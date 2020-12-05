using OptionalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsChallenge
{
    class LoopsChallenge
    {
        static void Main(string[] args)
        {
            string challenge = "Supercalifragilisticexpialidocious";
            int letterCount = 0;
            foreach (char letter in challenge)
            {
                Console.WriteLine(letter);
                letterCount++;
                
            }
            Console.WriteLine(letterCount);
            foreach (char letter in challenge)
            {
                if (letter == 'i'||letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or an l");
                }
            }
            DateTime myBday = new DateTime(1994, 12, 20);
            User user = new User("Connor", "Braeger", 1, myBday);
            Console.WriteLine(user.FullName());
            Console.WriteLine("Age in years: " + user.AgeInYears());
            Console.ReadKey();
        }
    }
}
