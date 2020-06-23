using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0

            List<int> numbers = new List<int>();
            int i = 0;



            do
            {
                i++;
                numbers.Add(i);
            }
            while (i < 100);



            // Create a while loop
            
            // While your variable is less than 200

            while (i < 200)
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"

                i++;
                numbers.Add(i);

            }

            Console.WriteLine("Increase:");

            // Create a foreach loop

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            // Write your variable to the console

            Console.WriteLine("");
            
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int a = 199; a <= numbers.Count && a >= 0; a--) 
            {
                Console.WriteLine($"The number {numbers[a]} is at the index {a}");
                // Write to the console "numbers" at index i
               
            }
        }
    }
}
