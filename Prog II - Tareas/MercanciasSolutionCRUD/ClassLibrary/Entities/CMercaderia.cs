using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class CMercaderia
    {

        public CMercaderia()
        {
            this.Status = "Activa";
            this.NoEliminable = 0;
            this.Existencia = 0;
        }

        public int IdMercancia { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public byte NoEliminable { get; set; }


    }
}
