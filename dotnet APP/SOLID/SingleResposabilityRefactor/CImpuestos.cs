using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposabilityRefactor
{
    class CImpuestos
    {

        private static float CalcularImpuestos(CEmpleado empleado)
        {
            return (empleado.Salario * 0.27f);
        }

        public static void PagarImpuestos(CEmpleado empleado)
        {
            float impuestos = CalcularImpuestos(empleado);
            Console.WriteLine("Usted, {1} debe de pagar de impuestos {0}.", impuestos, empleado.Nombre);
        }

    }
}
