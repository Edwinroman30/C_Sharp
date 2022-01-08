using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratingPattern.ClassLibrary.Decoraciones
{
    class CSuspencion : IComponente
    {
        //Especifica a quien se va a decorar.
        private IComponente componenteADecorar;

        public CSuspencion(IComponente pcomponenteADecorar)
        {
            this.componenteADecorar = pcomponenteADecorar;
        }

        public double Coste()
        {
            //Aqui se ve ese agregado es la decoracion.
            return componenteADecorar.Coste() + 600000;
        }

        public string Funciona()
        {
            return this.componenteADecorar.Funciona() + " Suspencion nueva era!";
        }
    }
}
