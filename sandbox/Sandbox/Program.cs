using System;

class Program

{
    // FIX: Variable declarations must be inside a method in C#. 'var' cannot be used at class level.
    static void Main(string[] args)
    {
        var num1 = 5;
        var num2 = 10;
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        // Call the Test method and print the result
        int result = Test(num1, num2);
        Console.WriteLine($"Test result: {result}");
    }

    // FIX: Use C# method syntax, not 'function'. Methods cannot be nested in C#.
    static int Test(int num1, int num2)
    {
        Console.WriteLine("This is a test function.");
        return num1 + num2;
    }
}