namespace Mindfulness;

public static class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            // Show the menu each time the user comes back.
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine() ?? string.Empty;

            // Send the user to the activity they picked.
            switch (choice)
            {
                case "1":
                    // Run the breathing exercise.
                    new BreathingActivity().Run();
                    break;
                case "2":
                    // Run the list-making exercise.
                    new ListingActivity().Run();
                    break;
                case "3":
                    // Run the reflection exercise.
                    new ReflectingActivity().Run();
                    break;
                case "4":
                    return;
            }

            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}