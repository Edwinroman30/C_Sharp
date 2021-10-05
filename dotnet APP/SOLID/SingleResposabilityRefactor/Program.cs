using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposabilityRefactor
{
    class Program
    {
        static void Main(string[] args)
        {

            CEmpleado empleado01 = new CEmpleado("Chupo",'M',32056f);

            CImpuestos.PagarImpuestos(empleado01);
            Console.ReadKey();


        }
    }
}
