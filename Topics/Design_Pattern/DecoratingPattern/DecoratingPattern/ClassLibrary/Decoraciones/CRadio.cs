using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratingPattern.ClassLibrary;

namespace DecoratingPattern.ClassLibrary.Decoraciones
{
    class CRadio : IComponente
    {
        private IComponente componenteADecorar;

        public CRadio(IComponente pcomponenteADecoara)
        {
            this.componenteADecorar = pcomponenteADecoara;
        }

        public double Coste()
        {
            //Aqui se ve ese agregado es la decoracion.
            return componenteADecorar.Coste() + 349000;
        }

        public string Funciona()
        {
            return this.componenteADecorar.Funciona() + " Radio ON...";
        }
    }
}
