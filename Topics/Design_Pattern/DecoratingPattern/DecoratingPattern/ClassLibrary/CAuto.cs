using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratingPattern.ClassLibrary
{
    public class CAuto : IComponente
    {
        /*
           El auto es el objeto a decorar.
         */

        private string modelo;
        private string caracteristica;
        private double costo;
        
        public CAuto(string pmodelo, string pcaracteristicas, double pcosto)
        {
            this.modelo = pmodelo;
            this.caracteristica = pcaracteristicas;
            this.costo = pcosto;
        }

        public double Coste()
        {
            return this.costo;
        }

        public string Funciona()
        {
            return "Encendiendo motores.";
        }

        public void isOpen(bool status = false)
        {
            if (status)
                Console.WriteLine("Esta cerrada");
            else
                Console.WriteLine("Esta abierta");
        }


        public override string ToString()
        {
            return string.Format("Model: {0} details: {1}", this.modelo,this.caracteristica);
        }


    }
}
