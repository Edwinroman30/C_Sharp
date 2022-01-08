using System;
using DecoratingPattern.ClassLibrary;
using DecoratingPattern.ClassLibrary.Decoraciones;

namespace DecoratingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente porche = new CAuto("Porche II", "Una cosa alta gama", 780000);

            Console.WriteLine( porche.ToString() );
            Console.WriteLine( porche.Coste() );

            porche = new CRadio(porche);

            Console.WriteLine( porche.Funciona() );
            Console.WriteLine( porche.Coste() );

            porche = new CSuspencion( porche );

            Console.WriteLine( porche.Funciona() );
            Console.WriteLine( porche.Coste() );

            //Aqui estaria eliminando todas las decoraciones regresando al estado defaul.
            porche = new CAuto("Porche II", "Una cosa alta gama", 780000);
            porche.Funciona();

            Console.WriteLine(porche.Funciona());
            Console.WriteLine(porche.Coste());
        }

    }
}
