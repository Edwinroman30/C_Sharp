using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Definicion del delegado,  en el ambito de una clase.
        private delegate void DDelegado(string name);
        
        //Definicion de otro delegado,  en el ambito de una clase.
        //delegate void Dsumador(string mess, int num1, int num2);

        static void Main(string[] args)
        {

            //Asignacion o Delegacion.
            DDelegado Dsaludar = new DDelegado(CGrettingClient.MorningGretting);

            Dsaludar("Edwin");

            //Reutilizacion del delegado:

            Dsaludar = new DDelegado (CGrettingClient.NightGretting);

            Dsaludar("Roiner");

            //Asignacion o Delegacion.
            //Dsumador Dsumar = new Dsumador(CSumador.Sumar);

            //Dsumar("La suma es:", 33, 2);

        }

    }

}
