using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp_InitExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var pairsNumbers = from num in numbers
                               where (num % 2 == 0)
                               select num;



            foreach (var number in pairsNumbers)
            {
                Console.WriteLine("Pairs number from 1 to 9, {0}", number);
            }


            //Con arreglos, buscar la letra 'v'

            string cadena = "Un dia vi una vaca vestida de uniforme.";

            var letterV = from letter in cadena.Split(" ")
                          where letter.Contains('v')
                          select letter;


            foreach (var unit in letterV)
            {
                Console.WriteLine("Estos empiezan con v: {0}", unit);
            }

            Console.WriteLine("---------------------------------------");





        }
    }
}
