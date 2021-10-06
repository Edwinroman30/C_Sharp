using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Stack is the same as Generic List but operates on a LIFO principle (last in, first out), like in a company:
            //the last people hired are the first people fired, or in a stack of cards: the last cards you put on top of the deck
            //and the first cards you take off the top of the deck, hence the name stack. A good use of the generic stack is to
            //keep track of actions that the user has performed in your application so that you can roll these actions back.
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-5.0

            {
                ////We can create it like a non-safeType
                //  Stack mystack = new Stack();

                ////Or like a safeType
                ////Stack<int> mystack = new Stack<int>();


                //mystack.Push(1);
                //mystack.Push(2);
                //mystack.Push(3);
                //mystack.Push(4);

                //mystack.Push("MU");

                //foreach (var num in mystack)
                //{
                //    if (num.GetType().IsValueType)
                //        Console.WriteLine("{0} is type of: {1}", num, (num).GetType());
                //    else
                //        Console.WriteLine("Es otra cosa pero no un numero > {0}",num);
                //}

                //Console.WriteLine("My last items {0}, ", mystack.Peek());

                ////Console.ReadKey();

            }


            // Web browsers back buttoms work with the (LIFO) algoritm, let's make a simulation...

            Stack<string> stUrl = new Stack<string>();

            Console.WriteLine("Please, insert the url:");
            for(int i=0; i < 3; i++)
            {
                stUrl.Push(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Console.WriteLine("The last page that you visited was: {0}",stUrl.Peek());
            stUrl.Clear();
 

        }
    }
}
