using System;

namespace HelloWorld
{
    class Program
    {
       
        public static string Greeting(string name){
            
            return "What up boy, " + name; 
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Greeting("Edwin"));

        }


       

    }
}
