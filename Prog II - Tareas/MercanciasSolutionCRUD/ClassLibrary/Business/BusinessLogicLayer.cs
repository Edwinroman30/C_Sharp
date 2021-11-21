using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using ClassLibrary.Data;

namespace ClassLibrary.Bussines
{

    public class BusinessLogicLayer
    {

        private DataAcessLayer _dataAcessLayer;

        public BusinessLogicLayer()
        {
            _dataAcessLayer = new DataAcessLayer();
        }

        #region CARGANDO DATA AL GRIDVIEW
        public List<CMercaderia> GetMercaderia(string toSearch = null)
        {
            return _dataAcessLayer.GetMercaderias(toSearch);
        }

        //GUARDA y ACTUALIZA NUEVOS DATOS:
        public CMercaderia SaveMercaderia(CMercaderia mercaderia)
        {
            if (mercaderia.IdMercancia == 0)
                //Se va a insertar porque el INT de la propiedad al no tener un valor asignado se iniciara en 0.
                this._dataAcessLayer.InsertMercaderia(mercaderia);
            else
                //Se va a actualizar porque si tiene un ID definido.
                this._dataAcessLayer.UpdateMercaderia(mercaderia);

            return mercaderia;
        }

        //ELIMINAR DATOS
        public bool DeleteMercancia(int Idmercancia)
        {
            if(Idmercancia > 0)
            {
                this._dataAcessLayer.DeleteMercancia(Idmercancia);
                return true;
            }
            else
            {
                return false;
            }
                 
        }
        
        #endregion

    
    
    }


}
