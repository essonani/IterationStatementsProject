using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            // exercise 1
            // write this loop 15 time
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
         /*   for (int i = 0; i < 5; i++) ;
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} ");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            } */

            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();


            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var num = 0;



            // Create a do-while loop and use the template below:
            do
            {
                // Increment num by 1
                num++;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } // <---- While your variable is less than 100 
            while (num < 100);


            // Create a while loop
            // <--- While num is less than 200
            while (num < 200)
            {
                // Increment num by 1
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop
                num++;
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers



            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            //start for loop here
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                // place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]);
            }


            //------------End of exercise
            //exerice3 
            //Write a method that will print to the console all numbers 1000 through -1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            //Write a method that will print to the console numbers 3 through 999 by 3 each time

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
            //Write a method to accept two integers as parameterss and check whether they are equal or not
            //Write a method to accept two integers as parameterss and check whether they are equal or not
            int x = 0; int y = 0;
            Console.WriteLine("enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("same numbers");

            }
            else
            {
                Console.WriteLine("not the same");
            }
            //Write a method to check whether a given number is even or odd  
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }
            //Write a method to check whether a given number is positive or negative  
            int r = 0;
            Console.WriteLine("enter r");
            r = Convert.ToInt32(Console.ReadLine());
            if (r >= 0)
            {
                Console.WriteLine("positive");
            }
            else { Console.WriteLine("negative"); }
            //Write a method to read the age of a candidate and determine whether they can vote. 
            Console.WriteLine("what is your age");
            int age = Convert.ToInt32(Console.ReadLine()); 
            if(age >18)
            {
                Console.WriteLine("you are eligible to vote");
            } 
            else { Console.WriteLine("you are too young"); }

            
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            int s, nub;
            Console.WriteLine("enter a number in the table");
            nub = Convert.ToInt32(Console.ReadLine());
            for (s =1; s <= 12; s++)
            {
                Console.WriteLine(s * nub);
            }
            // Write a method to check if an integer(from the user) is in the range -10 to 10 
            int k = -10; int f = 10; int v;
            Console.WriteLine("enter a number");
            v = Convert.ToInt32(Console.ReadLine());
            if (v >= k && v<=f ) 
            {
                Console.WriteLine("it is in range");
            } 
            
            else { Console.WriteLine("it is not in range"); }
        }

    }












    
    
    //Write a method to read the age of a candidate and determine whether they can vote.

}
