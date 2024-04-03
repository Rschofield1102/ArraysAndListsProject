using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {



            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create an int array and populate it with numbers 1-10


            /* Create a list of type int
             * Name the list "evens"
             * * Create another list of type int
             * Name the list "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>() ;

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */

            foreach (var num in numbers)
            {

                if (num % 2 == 0)
                {
                    evens.Add(num);
                    Console.WriteLine(evens);//return number to the evens list
                }
                else
                {
                    odds.Add(num);
                    Console.WriteLine(odds);//return numbers to the odds list
                }
                
            }

            //foreach (int num in evens)
            //{
            //    Console.WriteLine(num);
            //}
            //***
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                    Console.WriteLine(evens[i]);
                }

                else
                {
                    odds.Add(numbers[i]);
                    Console.WriteLine(odds[i]);
                }
                

            }
            //***


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */

            Console.WriteLine("----EVENS BEGIN------");
            //***
            foreach (var num in evens)
            {
                Console.WriteLine(num);
                
            }
            Console.WriteLine("----ODDS BEGIN------");
            /* Using a for loop,
             * display the numbers in your "odds" list
             */

            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
            Console.WriteLine("----------");
        }
        //***


    }
    }
    
