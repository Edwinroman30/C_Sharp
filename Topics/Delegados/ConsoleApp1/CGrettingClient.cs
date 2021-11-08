using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CGrettingClient
    {
        public static void MorningGretting(string name)
        {
            Console.WriteLine("Good Mornign {0}, welcome to Delegates Game", name);
        }

        public static void NightGretting(string name)
        {
            Console.WriteLine("Good Night {0}, have a great night from Delegates Game", name);
        }
    }
}
