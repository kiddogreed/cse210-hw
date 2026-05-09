using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, This is the Exercise3 Project.");

//      In the Guess My Number game the computer picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.

// This assignment is a little tricky, because it brings together many of the concepts you've learned in this course including loops and if statements.

    //task 1 asking the user for the magic number
    //task 1.2 use random number to generate magic number instead of asking user for it
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generates a random number between
        Console.WriteLine("What is the magic number?"); 
        //int magicNumber = int.Parse(Console.ReadLine());
        int trackCount = 0; // This variable will keep track of the number of guesses the user has made.

        //create loop that continues until the user guesses the magic number
        int userGuess = -1; // Initialize userGuess to a value that cannot be the magic number to ensure the loop starts
        while (userGuess != magicNumber)
        {
            //task 2 ask the user for their guess
            Console.WriteLine($"What is your guess? {trackCount} guesses so far.");
            userGuess = int.Parse(Console.ReadLine());
            trackCount++; // Increment the guess count each time the user makes a guess


            //task 3 if the user's guess is too low, print "Higher!" if the user's guess is too high, print "Lower!" if the user's guess is correct, print "Congratulations! You guessed the magic number!"
            if (userGuess < magicNumber)
                Console.WriteLine("Higher!");
            else if (userGuess > magicNumber)
                Console.WriteLine("Lower!");
            else
                Console.WriteLine($"Congratulations! You guessed the magic number! It took you {trackCount} guesses.");    
        }
    }

}