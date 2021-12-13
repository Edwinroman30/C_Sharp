using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Linq;

namespace ConsoleAppIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Edwin\Documents\C_Sharp\Topics\XML_Solution\ConsoleAppIntro\Resources\WikimediaXML.xml";

          
            //  Usando XmlDocument
                UsingXmlDocument(path);

            //Exite otro metodo, tal vez el mas optimo llamado 
            //XmlReader
            //Usando LinQ


            //Writing XML documents with XMLWritter:
            UsingXMLWritter(@"C:\Users\Edwin\Documents\C_Sharp\Topics\XML_Solution\ConsoleAppIntro\Resources\");

            //Writting XML documents with XmlDocument:
            UsingXMLDocumentToCreate(@"C:\Users\Edwin\Documents\C_Sharp\Topics\XML_Solution\ConsoleAppIntro\Resources\");

        }



        private static void UsingXmlDocument(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path); //Para leerlo desde una ruta en especifico.

            XmlNodeList nodeList = xmlDoc.SelectNodes(@"/ Wikimedia/projects/project/editions/edition");

            foreach (XmlNode xmlNode in nodeList)
            {
                Console.WriteLine(xmlNode.Attributes["language"].Value);
            }

        }

        //Forma de escribir un XML (Faster X)
        private static void UsingXMLWritter(string path)
        {
            XmlWriter xmlWriter = XmlWriter.Create(path+@"\ContactsXML.xml");

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Contacts");

            xmlWriter.WriteStartElement("Contac");
            xmlWriter.WriteAttributeString("PhoneNumber", "1 39233244");
            xmlWriter.WriteString("Jonny Pujols");
            xmlWriter.WriteEndElement();


            xmlWriter.WriteStartElement("Contac");
            xmlWriter.WriteAttributeString("PhoneNumber", "809 3829932");
            xmlWriter.WriteString("Ramona Lamarche");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Contac");
            xmlWriter.WriteAttributeString("PhoneNumber", "302 2212324");
            xmlWriter.WriteString("Maciano Tech");


            xmlWriter.WriteEndDocument(); //Cierra en automatico todos los tags abiertos. Pero no en orden

            xmlWriter.Close(); //Borra de memoria el objeto.


        }

        
        //Forma de escribir un XML, pero con un estilo POO
        private static void UsingXMLDocumentToCreate(string path)
        {
            XmlDocument xmlDoc = new XmlDocument(); 
            
            //Este nos proporciona una serie de metodos que nos
            //permite general mas objetos.

            //Definimos un nodo raiz o padre.
            XmlNode rootNode = xmlDoc.CreateElement("Contacts");

            xmlDoc.AppendChild(rootNode);

            XmlNode contactNode = xmlDoc.CreateElement("Contact");
            XmlAttribute contactAttr = xmlDoc.CreateAttribute("phoneNumber");
            contactAttr.Value = "930 233 422";
            contactNode.InnerText = "Ramona Orbe";

            contactNode.Attributes.Append(contactAttr);

            rootNode.AppendChild(contactNode);

            //Reutilizacion de los objetos creados:

            contactNode = xmlDoc.CreateElement("Contact");
            contactAttr = xmlDoc.CreateAttribute("phoneNumber");
            contactAttr.Value = "8291823422";

            contactNode.Attributes.Append(contactAttr);


            contactAttr = xmlDoc.CreateAttribute("age");
            contactAttr.Value = "24";

            contactNode.Attributes.Append(contactAttr);
            contactNode.InnerText = "Julian Pepejuil";

            rootNode.AppendChild(contactNode);


            //Por ultimo salvar el documentos en un lugar?

            xmlDoc.Save(path + @"\ContactsXML2.xml");

        }



    }
}
