using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            //Edward Tanguay said: (Intro)
            //Generic List gives you a type-secure way to keep objects in collections.In this lesson we'll look at how
            //programming was done before generic lists and how generic lists make your development life easier.
            //https://www.youtube.com/watch?v=D3ANkQyLq-c

            // array: are type-safe, cons: number of fixed items.
            // ArrayList:  flexible number of items, cons: is'not type-safe.
            // List<TypeOfValue> : is best option than two befores.

            //Using arrays
            {
                int[] scores = new int[] { 67,77,97,90 };
                foreach (int score in scores)
                    Console.WriteLine(score);

                //If we wanna to insert a new items, we cannot because it is fixed to work with 4 items.
                //scores[4] = 90;
            }

            Console.WriteLine("\n");

            //-------------------------------------------------------------------------------------------------------------

            //Using Arraylist
            {
                ArrayList scores = new ArrayList() { 67, 77, 97, 90 };

                //Here with can Insert/Add a new items and work with multiple items.
                scores.Add(44);

                //But the flexibility can cause problems, cannot operate a string.
                //scores.Add("Great Student"); ERROR CAUSE BY US

                foreach (var score in scores)
                    Console.WriteLine("We have {0} and with hundred increase {1}", score, (int)score + 100);

            }

            Console.WriteLine("\n");

            //-------------------------------------------------------------------------------------------------------------

            //Using List<>
            {
                List<int> scores = new List<int> { 67, 77, 97, 90 };

                //Here with can Insert/Add a new items.
                scores.Add(44);

                //Here the type-safe help us to evoid problems before mencioned.

                //scores.Add("Great Student"); ERROR

                foreach (var score in scores)
                    Console.WriteLine("We have {0} and with hundred increase {1}", score, (int)score + 100);

            }


        }
    }
}
