using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSumador
    {

        public static void Sumar(string messg, int num1, int num2)
        {
            Console.WriteLine(messg);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2).ToString());
        }


    }
}
