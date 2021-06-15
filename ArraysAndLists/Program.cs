using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] Array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for(int i = 1; i < 20000; i++)
            {
                if (i % 2 == 0)
                    evens.Add(i);
                else
                    odds.Add(i);
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("List of all even numbers through 20000");
            foreach(int evenNumber in evens)
            {
                Console.Write($"{evenNumber} ");
                if (evenNumber % 20 == 0) 
                    Console.WriteLine();
            }
            Console.WriteLine("Now all the odd numbers through 20000");
            foreach(int oddNumber in odds)
            {
                Console.Write($"{oddNumber} ");
                if (oddNumber % 9 == 0)
                    Console.WriteLine();
            }

        }
    }
}
