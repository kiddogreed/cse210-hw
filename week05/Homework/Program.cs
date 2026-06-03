using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        // string studentName = "John Doe";
        // string topic = "Math Homework";
        // Assignment mathAssignment = new MathAssignment();
        // Console.WriteLine(mathAssignment.GetSumary(studentName, topic));


        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", "Chapter 3", "Problems 1-5");
        Console.WriteLine(mathAssignment.GetSummary());         // Output: Student: John Doe, Topic: Algebra, Textbook Section: Chapter 3
        Console.WriteLine(mathAssignment.GetHomeworkList());   // Output: Section Chapter 3, Problems 1-5

        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "English", "The Great Gatsby");
        Console.WriteLine(writingAssignment.GetSummary());      // Output: Student: Jane Smith, Topic: English
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Output: Title: The Great Gatsby
    }
}