using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BusinessLogicLayer
    {
        private DataAcessLayer _dataAcessLayer;
        
        public BusinessLogicLayer()
        {
            _dataAcessLayer = new DataAcessLayer();
        }

        #region Methods
        public List<CContact> GetContacts(string toSearch = null)
        {
            return _dataAcessLayer.GetContacts(toSearch);
        }

        public CContact SaveContact(CContact contact)
        {
            if (contact.idContact == 0) 
                //Se va a insertar porque el INT de la propiedad al no tener un valor asignado se iniciara en 0.
                this._dataAcessLayer.InsertContact(contact);
            else
                //Se va a actualizar porque si tiene un ID definido.
                this._dataAcessLayer.UpdateContact(contact);

            return contact;
        }

        public void DeleteContact(int idContact)
        {
            this._dataAcessLayer.DeleteContact(idContact); 
        }
        #endregion

    }
}
