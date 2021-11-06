using PPEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEFCore.DataAccessLayer
{
    public class Repository
    {
        //Desde esta biblioteca de clases se realizo una Reference al proyecto "PPEFCore.Entities". (Solo una nota)
        //Se podrian las operaciones CRUD de la entidades.
        public Category AddCategory(Category categoryToAdd)
        {
            try
            {

                //Crear conexion.
                var conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = "Server=.;Database=demo;Trusted_Connection=True;";
                conn.Open();

                //Configurar el comando.
                var comm = new System.Data.SqlClient.SqlCommand();
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = 
                    $"INSERT INTO Tbl_Categories (CategoryName) Values ('{categoryToAdd.CategoryName}');" +
                    $"SELECT @@IDENTITY;";
                 var result =  comm.ExecuteScalar();

                categoryToAdd.CategoryID = Convert.ToInt32(result);

                //Obtener el resultado.
                //Liberar Recursos.

                comm.Dispose();
                conn.Dispose();

                return categoryToAdd; //Retorno del mismo objeto, pero con su Identificador incluido.

                }
                catch(Exception ex)
                {
                    throw ex;
                }
            //El problema aqui es que este codigo se repetira por cada clase por lo que mejor seria
            //hacer un refactor, osea optimizar todo esto.
            
            //Es mejor usar parametro donde se espefica el tipo de datos, tambien esta forma trae o provocatia inyecciones 
            // por lo que debemos de evitarlas. Este codigo tiene mucho que mejorar.


        }


        public Product AddProduct(Product productToAdd)
        {
            return productToAdd; //Retorno Temporal
        } 

    }
}
