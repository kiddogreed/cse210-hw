using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Assignment Instructions
For this assignment, write a C# program that has several simple functions:

DisplayWelcome - Displays the message, ""Welcome to the Program!""
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.");

    //forgot to call the functions in the main method, so I added that in here
        DisplayWelcome();
        // to store the return values from PromptUserName and PromptUserNumber 
        string name = PromptUserName();
        int number = PromptUserNumber();
        
        int squaredNumber = SquareNumber(number);
        // display the result using the DisplayResult function
        DisplayResult(name, squaredNumber);
    }



    //task 1 DisplayWelcome - Displays the message, ""Welcome to the Program!""
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    //task 2 PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }
    //task 3 PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }   
    //task 4 SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        return number * number;
    }   
    //task 5 DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }   
}