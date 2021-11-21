using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary.Entities;

namespace ClassLibrary.Data
{
    class DataAcessLayer
    {
        public DataAcessLayer()
        {
            
        }

        private SqlConnection OpenDB()
        {
          return new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MiPrimeraVez;Data Source=DESKTOP-B9L1G5M"); ;
        }


        #region SELECT
        public List<CMercaderia> GetMercaderias(string toSearch)
        {
            List<CMercaderia> listMercaderia = new List<CMercaderia>();

            try
            {

                using (var conn = OpenDB())
                {
                    conn.Open();

                    string queryGetMercancia = @"SELECT [IdMercancia] ,[Descripcion],[Existencia],[Comentario],
                                          [Status],[NoEliminable] FROM [Mercaderia]";


                    using (var command = new SqlCommand(queryGetMercancia, conn))
                    {

                        if (!string.IsNullOrEmpty(toSearch))
                        {
                            queryGetMercancia = @"SELECT [IdMercancia] ,[Descripcion],[Existencia],[Comentario]
                                            ,[Status],[NoEliminable] FROM [MiPrimeraVez].[dbo].[Mercaderia]
                                                WHERE [Descripcion] LIKE @descripcion";

                            command.CommandText = queryGetMercancia;
                            command.Parameters.Add(new SqlParameter("@descripcion", $"%{toSearch}%"));

                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CMercaderia mercaderiaAnadir = new CMercaderia();

                            mercaderiaAnadir.IdMercancia = Convert.ToInt32(reader["IdMercancia"]);
                            mercaderiaAnadir.Descripcion = reader["Descripcion"].ToString();
                            mercaderiaAnadir.Existencia = Convert.ToInt32(reader["Existencia"]);
                            mercaderiaAnadir.Status = (reader["Status"]==DBNull.Value)?"Active": reader["Status"].ToString();
                            mercaderiaAnadir.NoEliminable = (reader["NoEliminable"]==DBNull.Value)? byte.MinValue : Convert.ToByte(reader["NoEliminable"]);
                            mercaderiaAnadir.Comentario = reader["Comentario"].ToString();
                           
                            listMercaderia.Add(mercaderiaAnadir);
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
            return listMercaderia;
        }
        
        
        #endregion


        #region INSERT
        public void InsertMercaderia(CMercaderia mercaderia)
        {
            try
            {
                using (var conn = OpenDB())
                {

                    conn.Open();
                    string query = @"
                                  INSERT INTO Mercaderia ([Descripcion],[Existencia],[Comentario],[Status],[NoEliminable]) 
                                  VALUES (@Descripcion,@Existencia,@Comentario,@Status,@NoEliminable)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        //Lo realice de manera directa en vez de crear un objeto con su nombre...
                        command.Parameters.Add(new SqlParameter("@Descripcion", mercaderia.Descripcion));
                        command.Parameters.Add(new SqlParameter("@Existencia", (mercaderia.Existencia>0)?mercaderia.Existencia:0));
                        command.Parameters.Add(new SqlParameter("@Comentario", mercaderia.Comentario));
                        command.Parameters.Add(new SqlParameter("@Status", mercaderia.Status));
                        command.Parameters.Add(new SqlParameter("@NoEliminable", mercaderia.NoEliminable));

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


        #region UPDATE
        public void UpdateMercaderia(CMercaderia cMercaderia)
        {
            try
            {

            string queryUpdate = @"
            UPDATE Mercaderia   SET[Descripcion] = @Descripcion, [Existencia] = @Existencia, [Comentario] = @Comentario,
            [Status] = @Status, [NoEliminable] = @NoEliminable
            WHERE IdMercancia = @IdMercaderia
            ";

            using (var conn = OpenDB())
            {
                 conn.Open();

                    using (var command = new SqlCommand(queryUpdate,conn))
                    {
                        command.Parameters.Add(new SqlParameter("@IdMercaderia", cMercaderia.IdMercancia));
                        command.Parameters.Add(new SqlParameter("@Descripcion", cMercaderia.Descripcion));
                        command.Parameters.Add(new SqlParameter("@Existencia", (cMercaderia.Existencia < 0) ? cMercaderia.Existencia : 0));
                        command.Parameters.Add(new SqlParameter("@Comentario", cMercaderia.Comentario));
                        command.Parameters.Add(new SqlParameter("@Status", cMercaderia.Status));
                        command.Parameters.Add(new SqlParameter("@NoEliminable", cMercaderia.NoEliminable));

                        command.ExecuteNonQuery();
                    }

                conn.Close();
            }


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region DELETE

        public void DeleteMercancia(int idMercancia) 
        {
            try
            {
                using (var conn = OpenDB())
                {
                    conn.Open();


                    string queryDelete = @"DELETE FROM [Mercaderia] WHERE IdMercancia = @idMercancia";

                    using(var command = new SqlCommand(queryDelete,conn))
                    {
                        command.Parameters.Add(new SqlParameter("@idMercancia",idMercancia));

                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw;
                //Recordar manejar la excepcion
            }
            
        }

        #endregion


    }

}
