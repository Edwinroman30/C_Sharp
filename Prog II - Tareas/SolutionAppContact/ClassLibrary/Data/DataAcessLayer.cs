using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class DataAcessLayer
    {
        private string __stringConnetion;

        public DataAcessLayer()
        {
            //FROM A XML
            __stringConnetion = System.Configuration.ConfigurationManager.ConnectionStrings["ContactDB"].ToString();
        }

        #region CRUD OPERATIONS

        #region INSERT
        public void InsertContact(CContact contact) 
        {
            try
            {
                using (var conn = new SqlConnection(this.__stringConnetion))
                {
                   
                        conn.Open();
                        string query = @"
                                  INSERT INTO Tbl_Contacts (Firstname,Lastname,Phone,Address) 
                                    VALUES (@FirstName,@LastName,@Phone,@Address)";

                        using (var command = new SqlCommand(query, conn))
                        {
                            //Lo realice de manera directa en vez de crear un objeto con su nombre...
                            command.Parameters.Add(new SqlParameter("@FirstName", contact.FirstName));
                            command.Parameters.Add(new SqlParameter("@LastName", contact.LastName));
                            command.Parameters.Add(new SqlParameter("@Phone", contact.Phone));
                            command.Parameters.Add(new SqlParameter("@Address", contact.Address));

                            command.ExecuteNonQuery();
                        }

                        conn.Close();

                }
                
            }
            catch (Exception e)
            {
                //Recordar manejar la execepcion
                throw e;
            }

        }
        #endregion

        #region SELECT
        public List<CContact> GetContacts(string toSearch = null)
        {
            List<CContact> listContacts = new List<CContact>();

            try
            {
               
                using (var conn = new SqlConnection(this.__stringConnetion))
                {
                    conn.Open();

                    string queryGetContacts;

                
                        queryGetContacts = @"SELECT [id_contact],[Firstname],[Lastname],[Phone],[Address]
                                                FROM [WinFormContact].[dbo].[Tbl_Contacts]";
                 

                    using (var command = new SqlCommand(queryGetContacts, conn))
                    {

                        if (!string.IsNullOrEmpty(toSearch))
                        {
                            queryGetContacts = @"SELECT [id_contact],[Firstname],[Lastname],[Phone],[Address]
                                                FROM [WinFormContact].[dbo].[Tbl_Contacts]
                                                WHERE [Firstname] LIKE @name";
                            
                            command.CommandText = queryGetContacts;
                            command.Parameters.Add(new SqlParameter("@name", $"%{toSearch}%"));
                            
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            //THat why the model is important.
                            CContact contactoAnadir = new CContact()
                            {
                                idContact = Convert.ToInt32(reader["id_contact"]),
                                FirstName = reader["Firstname"].ToString(),
                                LastName = reader["Lastname"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString()
                            };

                            listContacts.Add(contactoAnadir);
                        }

                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
            //Retorno de la lista completita...
            return listContacts;
        }
        #endregion

        #region UPDATE
        public void UpdateContact(CContact contact)
        {
            try
            {
                using (var conn = new SqlConnection(__stringConnetion))
                {
                    conn.Open();

                    string updateQuery = @"
                                              UPDATE Tbl_Contacts 
                                                SET Firstname = @FirstName,
                                                    Lastname = @LastName,
                                                    Phone= @Phone,
                                                    Address = @Address
                                                WHERE id_contact = @idContact";

                    
                    using (var command = new SqlCommand(updateQuery,conn))
                    {
                        command.Parameters.Add(new SqlParameter("@FirstName", contact.FirstName));
                        command.Parameters.Add(new SqlParameter("@LastName", contact.LastName));
                        command.Parameters.Add(new SqlParameter("@Phone", contact.Phone));
                        command.Parameters.Add(new SqlParameter("@Address", contact.Address));
                        command.Parameters.Add(new SqlParameter("@idContact", contact.idContact));

                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception)
            {
                //manejar la execepcion.
                throw;
            }
      
        }
        #endregion

        #region DELETE
        public void DeleteContact(int idContact)
        {
            try
            {
                using (var conn = new SqlConnection(__stringConnetion))
                {
                    conn.Open();

                    string updateQuery = @"
                                              Delete FROM Tbl_Contacts 
                                                WHERE id_contact = @idContact";


                    using (var command = new SqlCommand(updateQuery, conn))
                    {
                        command.Parameters.Add(new SqlParameter("@idContact", idContact));
                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception)
            {
                //manejar la execepcion.
                throw;
            }

        }
        #endregion

        #endregion

    }
}
