using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratingPattern.ClassLibrary
{
    public interface IComponente
    {
        //Puede ser una interfaz o clase abstracto

        public double Coste();
        public string Funciona();

    }
}
