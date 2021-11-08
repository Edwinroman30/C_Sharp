using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ComunicacionClasesDelegados
{
    class CPhone
    {
        public delegate void  DConsumo(int level);
        private int __battery;

        private DConsumo __dConsumo;

        public int Battery { get => __battery; set => __battery = value; }

        public CPhone()
        {
            this.Battery = 100;
        }

        public void AddLevelFunc(DConsumo pconsumo)
        {
            this.__dConsumo = pconsumo;
        }

        public void RunnigAPP()
        {

            Console.WriteLine("The app name xxx is working....");
            
            if(Battery > 70)
            {
                __dConsumo(Battery);
            }

        }

    }
}
