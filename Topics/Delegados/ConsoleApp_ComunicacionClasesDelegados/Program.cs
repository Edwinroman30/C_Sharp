using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ComunicacionClasesDelegados
{
    class Program
    {
        static void Main(string[] args)
        {

            CPhone iphonex = new CPhone();

            iphonex.AddLevelFunc(new CPhone.DConsumo(BaterryConsume()));

            iphonex.RunnigAPP();

        }

        void BaterryConsume()
        {

            Console.WriteLine("The current battery status is {0}");
        }


    }
}
