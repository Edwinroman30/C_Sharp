using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposabilityPrinciple
{
    class CEmpleado
    {
        private string _nombre;
        private char _sexo;
        private float _salario;

        public CEmpleado(string pnombre, char psexo, float psalario)
        {

            this._nombre = pnombre;
            this._sexo = psexo;
            this._salario = psalario;
        }

        public override string ToString()
        {
            return "Nombre, " + this._nombre + " y su sueldo es " + this._salario;
        }

        //En las dos ultimos violan este principio SingleResponsability
        private float CalcularImpuestos ()
        {
            return (this._salario * 0.27f);
        }

        public void PagarImpuestos()
        {
            float impuestos = this.CalcularImpuestos();
            Console.WriteLine("Usted, {1} debe de pagar de impuestos {0}.", impuestos, this._nombre);
        }

    }
}
