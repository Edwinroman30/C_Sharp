using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposabilityRefactor
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

        public string Nombre
        {
            get { return this._nombre; }
        }

        public float Salario
        {
            set
            {
                if (value > 0)
                    this._salario = value;
                else
                    this._salario = 0;
            }

            get
            {
                return this._salario;
            }
        }



        public override string ToString()
        {
            return "Nombre, " + this._nombre + " y su sueldo es " + this._salario;
        }

    }
}
