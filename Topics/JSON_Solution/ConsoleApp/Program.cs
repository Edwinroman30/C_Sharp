using ConsoleApp.Models;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp
{
    class Program
    {
        private readonly static string _Path = @"C:\Users\Edwin\Documents\C_Sharp\Topics\JSON_Solution\ConsoleApp\JSON_Sources\Contact.json";
        static void Main(string[] args)
        {

            //Obteniendo una lista pre-definida para fines de ejemplo:
            //List<CContacs> listToSerialice = GetContacs();

            //Serializando un objeto.
            //JSONSerialization(_Path, listToSerialice);

            //-----------------------------------------------------------------------------

            //string JSONFile = LoadingJSONFromFile(_Path);
            //DeserializeJSON(JSONFile);


        }

        #region "Creating a JSON"
        private static void JSONSerialization(string path, List<CContacs> listContacts)
        {
            string stringJSON = JsonConvert.SerializeObject(listContacts, Formatting.Indented);
            //File.WriteAllText(path,stringJSON); 

            //Console.WriteLine(stringJSON);
        }

        private static List<CContacs> GetContacs()
        {
            List<CContacs> listContacs = new List<CContacs>
            {
                new CContacs
                {
                    Name = "Jely Code",
                    Address = new CAddress()
                    {
                        Street = "Ave. 27 Febrero",
                        Number = 23,
                        City = new CCity()
                        {
                            Name = "STG Este",
                            Country = new CCountry
                            {
                                Name = "Dominican Republic",
                                Code = "DR"
                            }
                        }
                    },
                    Phone = new List<CPhone>
                    {
                    new CPhone() {TypePhone = "Home Phone", Phone = "33-23234-234"},
                    new CPhone() {TypePhone = "Personal Phone", Phone = "00-23323-122"}
                    },
                    DateOfBirth = new DateTime(1994,2,23)
                },

                new CContacs
                {
                    Name = "Francis",
                    Address = new CAddress()
                    {
                        Street = "Juan Marcelino",
                        Number = 19,
                        City = new CCity()
                        {
                            Name = "Mexico City",
                            Country = new CCountry
                            {
                                Name = "Mexico",
                                Code = "MX"
                            }
                        }
                    },
                    Phone = new List<CPhone>
                    {
                    new CPhone() {TypePhone = "Home Phone", Phone = "33-23234-234"},
                    new CPhone() {TypePhone = "Personal Phone", Phone = "00-23323-122"}
                    },
                    DateOfBirth = new DateTime(2000,3,30)


                },
                new CContacs
                {
                    Name = "Pastian D'Xruz",
                    Address = new CAddress()
                    {
                        Street = "Rey Luis II",
                        Number = 4,
                        City = new CCity()
                        {
                            Name = "Barcelona",
                            Country = new CCountry
                            {
                                Name = "Spain",
                                Code = "ES"
                            }
                        }
                    },
                    Phone = new List<CPhone>
                    {
                    new CPhone() {TypePhone = "Home Phone", Phone = "33-23234-234"},
                    new CPhone() {TypePhone = "Personal Phone", Phone = "00-23323-122"}
                    },
                    DateOfBirth = new DateTime(1990,8,2)

                },




            };



            return listContacs;
        }

        #endregion

        #region "Loading JSON"

        private static string LoadingJSONFromFile(string path)
        {
            string contactJSONFromFile;

            using (var reader = new StreamReader(path))
            {

                contactJSONFromFile = reader.ReadToEnd();
                reader.Close();
            }

            return contactJSONFromFile;
        }

        private static void DeserializeJSON(string JSONFile)
        {
            //Aqui consultaremos un dato:

            var obj = JsonConvert.DeserializeObject<List<CContacs>>(JSONFile);

            Console.WriteLine(string.Format("Name: {0} and I'm from {1}",obj[1].Name,obj[1].Address.City.Country.Name));

        }

        //Leyendo JSON, el cual no tenemos un objeto modelo para la deserializacion CON JsonTextReader

        private static void UsingJSONTextReader(string ContactJSONFromFile)
        {
            //Con esto se lee el objeto parte por parte.

            JsonTextReader reader = new JsonTextReader(new StreamReader(ContactJSONFromFile));

            while (reader.Read())
            {
                if(reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Values: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }

            }
            

        }


        #endregion


    }
}
