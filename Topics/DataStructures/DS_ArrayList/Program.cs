using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# ArrayList is a non-generic collection. The ArrayList class represents an array
            //list and it can contain elements of any data types. The ArrayList class is defined
            //in the System. Collections namespace.

            ArrayList myList = new ArrayList();

            myList.Add(new PC("Dell",2,8));
            myList.Add(new PC("Sony", 2, 16));
            myList.Add(new PC("Hp", 4, 12));

            Console.WriteLine("Adding:");
            myList.Add("Something diferent");
            myList.Add(false);

            Console.WriteLine("IndexOf:");
            Console.WriteLine(myList.IndexOf("false"));

            Console.WriteLine("IndexOf:");
            Console.WriteLine(myList.IndexOf(false));

            Console.WriteLine("Count:");
            Console.WriteLine(myList.Count);

            Console.WriteLine("Capacity:");
            Console.WriteLine(myList.Capacity);

            foreach (var elem in myList)
            {
                Console.WriteLine("PC> {0}",  elem);
            }

        }
    }


    class PC
    {
        public string model;

        public PC(string pmodel, byte pcores, byte pram)
        {
            this.model = pmodel;
            Cores = pcores;
            Ram = pram;
        }

        public string Model { get { return this.model; } set { this.model = value; } }
        public byte Cores { get; set; }
        public byte Ram { get; set; }
    }



}
