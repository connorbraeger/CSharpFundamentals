using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Week2Challenges
    {
        static void Main(string[] args)
        {
            Greeter test = new Greeter();
            string name = "Connor";
            test.SayHello(name);

            test.SayFarewell(name);
            test.TemporalMessage();
        }
    }
}
