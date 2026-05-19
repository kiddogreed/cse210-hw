using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // setting up some fractions to test our class
        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        //basic output using public get fraction/decimal methods from the Fraction class
        Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
        Console.WriteLine($"f4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");
    }
}