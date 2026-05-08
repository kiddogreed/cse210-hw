using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Assignment
          Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. (Remember: You should not add 0 to the list. If you do, later calculations and operations will not be correct.)

          Once you have a list, have your program do the following:

          Core Requirements
          Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

          Compute the um, or total, of the numbers in the list.
s
          Compute the average of the numbers in the list.

          Find the maximum, or largest, number in the list.");
      
        // Create a list to store the numbers entered by the user
        List<int> numbers = new List<int>(); // This list will hold all the numbers the user enters
        int sum = 0; // This variable will hold the sum of the numbers
        double average = 0; // This variable will hold the average of the numbers
        int max = int.MinValue; // This variable will hold the maximum number, initialized to the smallest possible integer

        // Ask the user for numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput = int.Parse(Console.ReadLine()); // Read the first number from the user

        // Keep asking for numbers until the user enters 0
        while (userInput != 0)
        {
            numbers.Add(userInput); // Add the number to the list
            sum += userInput; // Add the number to the running sum
            if (userInput > max) max = userInput; // Update max if this number is larger
            // Show the current list to the user
            Console.WriteLine("Enter a list of numbers, type 0 when finished. List: {" + string.Join(", ", numbers) + "}");
            userInput = int.Parse(Console.ReadLine()); // Read the next number
        }

        // After the loop, check if any numbers were entered
        if (numbers.Count == 0)
        {
            // If no numbers were entered, print a message and set outputs to 0 or N/A
            Console.WriteLine("No numbers entered. Sum: 0, Average: 0, Largest: N/A");
        }
        else
        {
            // Calculate the average by dividing the sum by the number of items in the list
            average = (double)sum / numbers.Count;
            // Print the results to the user
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
    }



}