using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asignacion o Delegacion, face de construccion del delegado.
            Delegado Dsaludar = new Delegado(CGrettingClient.MorningGretting);

            Dsaludar("Edwin");

            Dsumador Dsumar = new Dsumador(CSumador.Sumar);

            Dsumar("La suma es:", 33, 2);

        }

        //Definicion del delegado, al igual que en el ambito de una clase.
        delegate void Delegado(string name);

        delegate void Dsumador(string mess, int num1, int num2);

    }



    class CSumador{

        public static void Sumar(string messg, int num1, int num2)
        {
            Console.WriteLine(messg);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2).ToString());
        }

    }


    class CGrettingClient
    {

        public static void MorningGretting(string name)
        {
            Console.WriteLine("Good Mornign {0}, welcome to Delegates Game", name);
        }

    }

}
