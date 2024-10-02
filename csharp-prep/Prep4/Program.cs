using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Please note could use a we use do-while loop here instead 
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        // Part 2: Compute the average
        // Notice that we first cast the sum variable to a float. Otherwise, because
        // both the sum and the count are integers, the computer will do interger division
        // and I will not get a decimal value ( even though, it put the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorthing the list

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
        //find the smallest positive number
        
        int min = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number <min)
          
            { 
                min = number;
            }
        }

        if (min == int.MaxValue)
        {  
            Console.WriteLine($"No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {min}");
        }

        // Sort the  numbers 
        numbers.Sort();

        Console.WriteLine("The Sorted list is: " + string.Join(", ", numbers));
    }
}