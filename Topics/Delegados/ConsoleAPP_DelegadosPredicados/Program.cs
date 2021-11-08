using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_DelegadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello");
        }

        public static bool NumerosPrimos(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (i % i == 0) return true;
                else return false;
            }

        }

    }
}
