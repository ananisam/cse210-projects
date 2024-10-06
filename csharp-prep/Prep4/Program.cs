using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Introduction statement
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Declaring variable to hold a list of numbers and the number
        // That is, using a list class and creating a new object or instance of that class.
        List<int> numbers = new List<int>();

        // Declaring and initializing the loop variable.
        int userNumber = -1;

        // Setting the coondition to add numbers to the list until the user enters 0
        while (userNumber != 0)
        {
            // Prompting the user for the number and the converting it
            Console.Write("Enter number: ");
            string userInputNumber = Console.ReadLine();
            userNumber = int.Parse(userInputNumber);

            // Adding the number to the list
            // Setting the condition to make sure 0 is not added to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // Leaving the loop to do the computations
        // # Declaring and initializing the variables to accumulate the "total".
        int total = 0;

        // Computing the sum, or total, of the numbers in the list.
        foreach (int number in numbers)
        {
            total += number;
        }

        // Computing the average. First get the count from the list
        // Also casting the total variable to be a float since integer division can give results in decimal.
        int count = numbers.Count;
        float average = ((float)total) / count;

        // Finding the maximum or largest, smallest and smallest positive number (Stretched 1) in the list.

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                // Comparing the numbers so if this number is greater than the largest, 
                // the largest is updated with the number to be the new largest.
                largest = number;
            }
        }

        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                // Comparing the numbers so that if this number is less than the smallest, 
                // the smallest is updated with the number to be the new smallest.
                smallest = number;
            }
        }

        // Stretched 1:
        int smallestPositive = 999999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                // We have a new smallest positive number
                smallestPositive = number;
            }

        }


        // Stretch Challenge 2: Sorting the list
        // To be done later

        // Displaying the results
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is:");

        // Displaying the sorted list
        // To be done later
    }
}