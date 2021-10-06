using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable EmisoraTimeTable = new Hashtable();

            EmisoraTimeTable.Add("99.3", "Monday");
            EmisoraTimeTable.Add("99.7", "Tuesday");
            EmisoraTimeTable.Add("104.9", "Wednesday");

            foreach (DictionaryEntry datos in EmisoraTimeTable)
                Console.WriteLine("Emisora: {0}, Days: {1}", datos.Key, datos.Value);

            //Borrando por el key
            EmisoraTimeTable.Remove("104.9");

            //Otra manera de recorrerlo:
            Console.WriteLine("\n");

            ICollection valores = EmisoraTimeTable.Values;
            foreach (string valor in valores)
                Console.WriteLine("El valor es {0}",valor);

            

        }
    }
}
