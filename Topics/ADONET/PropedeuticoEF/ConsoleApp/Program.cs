using PPEFCore.DataAccessLayer;
using PPEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var category01 = new Category();
            var helper = new Repository();

            category01.CategoryName = "Enlatados";
            
            var dataRecibida = helper.AddCategory(category01);

            Console.WriteLine("CategoryID: {0}  - CategoryName: {1}",dataRecibida.CategoryID, dataRecibida.CategoryName);
            Console.ReadLine();
        }
    }
}
