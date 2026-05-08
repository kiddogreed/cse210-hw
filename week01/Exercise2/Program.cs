using System;

// This program asks the user for their grade percentage and tells them their letter grade and if they passed or failed.

    // int  A = 90;
      // int  B = 80
      // int  C = 70
      // int  D >= 60
      // int  F < 60
      // task 1 ask user for grade percentage use if, else if, else 
      // task 2 >=70 to pass , if pass print "Congratulations you passed!" else print "Sorry you failed, better luck next time!"  
      // task 3   create a new variable called letter and then in each block, set this variable to the appropriate value
      // strech add + or - to letter grade (+)if the last digit is >= 7 (-) for <= 3 
class Program
{
    static void Main(string[] args)
    {
        // Print a welcome message to the user
        Console.WriteLine("Write a program that determines the letter grade for a course");

        // Declare variables to store the letter grade and the pass/fail message
        string grade;
        string message;

        // Ask the user to enter their grade percentage
        Console.WriteLine("What is your grade percentage?");
        // Read the user's input, convert it from a string to an integer, and store it in gradeInput
        int gradeInput = int.Parse(Console.ReadLine());

        // Check if the user passed (70 or above) or failed (below 70)
        if (gradeInput >= 70)
            message = "Congratulations you passed!"; // Set message for passing
        else
            message = "Sorry you failed, better luck next time!"; // Set message for failing

        // Determine the letter grade based on the percentage
        if (gradeInput >= 90)
            grade = "A"; // 90 and above is an A
        else if (gradeInput >= 80)
            grade = "B"; // 80-89 is a B
        else if (gradeInput >= 70)
            grade = "C"; // 70-79 is a C
        else if (gradeInput >= 60)
            grade = "D"; // 60-69 is a D
        else
            grade = "F"; // Below 60 is an F

        // Add a plus or minus to the grade for A-D (not F)
        if (grade != "F")
        {
            // Get the last digit of the grade (e.g., 87 % 10 = 7)
            int lastDigit = gradeInput % 10;
            // If the last digit is 7 or higher, add a plus (except for A+ above 100)
            if (lastDigit >= 7 && gradeInput >= 60)
                grade += "+"; // grade += "+"; means: grade = grade + "+"; This adds a plus sign to the end of the grade string.
            // If the last digit is 3 or lower, add a minus (but not for 97 and above)
            else if (lastDigit <= 3 && gradeInput < 97)
                grade += "-"; // grade += "-"; means: grade = grade + "-"; This adds a minus sign to the end of the grade string.
        }

        // Print the final result to the user
        Console.WriteLine($"Your letter grade is {grade}. {message}");
    }
}