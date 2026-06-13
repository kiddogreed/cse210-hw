using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // First, test one square by itself.
        Square square = new Square("Red", 5.0);
        Console.WriteLine($"The square is {square.GetColor()} and has an area of {square.GetArea()}.");

        // List can hold any object that inherits from Shape.
        // Big idea behind polymorphism: one list, many shape types.
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(new Rectangle("Blue", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // Even though each item is stored as a Shape, C# still calls the correct GetArea()
        // for the real object type (Square, Rectangle, or Circle).
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }

    }
}g