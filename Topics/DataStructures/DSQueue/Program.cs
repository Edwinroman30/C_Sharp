using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            //The generic queue is like the stack but instead of 
            //a LIFO("last in first out") functionality, it has FIFO("first in first out").
            //Represents a first -in, first -out collection of objects.
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.queue?view=net-5.0


            //Basic Sample:
            {
                //Queue myQueue = new Queue();
                //myQueue.Enqueue(1);
                //myQueue.Enqueue(2);
                //myQueue.Enqueue(3);

                //foreach (object ob in myQueue)
                //    Console.WriteLine(ob);
            }



            //MORE EXPECIFIC EXAMPLE:
            //Three main operations can be performed on a Queue and its elements:

            // -> Enqueue adds an element to the end of the Queue.

            // -> Dequeue removes the oldest element from the start of the Queue.

            // -> Peek returns the oldest element that is at the start of the Queue but does not remove it from the Queue.

            Queue<COrders> QOrders = new Queue<COrders>();

            COrders order1 = new COrders() { NumberOrder = 001 , Title = "Chinese Soup"};
            COrders order2 = new COrders() { NumberOrder = 002, Title = "Dominican Rice" };
            COrders order3 = new COrders() { NumberOrder = 003, Title = "Mexican Taccos" };

            QOrders.Enqueue(order1);
            QOrders.Enqueue(order2);
            QOrders.Enqueue(order3);

            //Importante, cuando se va a buscar o eliminar en una de las Estructuras de Datos
            //Se debe de comprobar la existencia de valores en la estructura de datos.

            foreach(COrders order in QOrders)
                Console.WriteLine(order.ShowIt());

            //Lets to proccess each order by order of coming

            Console.WriteLine("\n");

            (QOrders.Dequeue()).Process();

            Console.WriteLine("\n");

            foreach (COrders order in QOrders)
                Console.WriteLine(order.ShowIt());


        }

    }



    public class COrders
    {

        public int NumberOrder { get; set; }
        public string Title { get; set; }

        public string ShowIt()
        {
            return String.Format("Number of Order: {0} and Title: {1}", NumberOrder, Title);
        }

        public void Process()
        {
            Console.WriteLine("The order {0} has been procesed sucesfully :) ", NumberOrder);
        }

    }


}
