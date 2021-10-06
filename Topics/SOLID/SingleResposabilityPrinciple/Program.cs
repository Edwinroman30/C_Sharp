using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposabilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado emp = new CEmpleado("Edwin", 'M', 28599f);
           
            Console.WriteLine(emp.ToString());
            emp.PagarImpuestos();

            Console.ReadKey();
        }
    }
}
