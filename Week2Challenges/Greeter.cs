using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Greeter
    {
        public void SayHello(string name)//Takes in name, outputs greeting
        {
            Console.WriteLine("Hello " + name + "!");
        }
        public void SayFarewell(string name)//Takes in name, outputs farewell
        {
            Console.WriteLine("Goodbye " + name + "!");
        }
        public void TemporalMessage()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour < 12)
            {
                Console.WriteLine("Good morning!");
            }else if (currentTime.Hour < 15)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (currentTime.Hour< 19)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }


        }
    }
}
