using System;

// =============================================================
// Eternal Quest — Week 06 EternalQuest Project
//
// Exceeds Requirements (Creativity):
//
//   1. Level System: As you earn points you advance through five
//      named levels: Novice Seeker → Rising Seeker →
//      Faithful Adventurer → Celestial Champion → Eternal Master.
//      Your current level title is shown next to your score in
//      every menu loop so you always know how far you have come.
//
//   2. DateTime Tracker: Every goal records the exact date and
//      time it was last worked on. This is shown next to each
//      goal in the list (e.g., "Last: 2026-06-13 09:45") and is
//      saved to the file so it persists between sessions.
//      Goals that have never been recorded show "Never recorded".
// =============================================================

class Program
{
    static void Main(string[] args)
    {
        // GoalManager keeps the full list of goals and the player's score.
        GoalManager manager = new GoalManager();
        bool running = true;

        Console.WriteLine("=== Welcome to Eternal Quest ===");

        // Keep showing the menu until the player chooses to quit.
        while (running)
        {
            Console.WriteLine();
            manager.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Record an event");
            Console.WriteLine("  4. Save goals");
            Console.WriteLine("  5. Load goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    // FR8 — show goals with [ ]/[X] status and checklist progress.
                    manager.ListGoals();
                    break;
                case "3":
                    // FR7 — record an event and award points.
                    RecordEvent(manager);
                    break;
                case "4":
                    // FR9 — save goals and score to a file.
                    Console.Write("Filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "5":
                    // FR9 — load goals and score from a file.
                    Console.Write("Filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye! Keep working on your eternal quest.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    // FR6 — asks the user which type of goal to create, then collects the required details.
    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Goal types:");
        Console.WriteLine("  1. Simple Goal    — done once, then marked complete");
        Console.WriteLine("  2. Eternal Goal   — repeats forever, like daily scripture reading");
        Console.WriteLine("  3. Checklist Goal — must be done a set number of times, earns a bonus");
        Console.Write("Type: ");
        string type = Console.ReadLine();

        Console.Write("Short name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points per completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                // simple goal, awarded once.
                manager.AddGoal(new SimpleGoal(name, desc, points));
                Console.WriteLine("Simple goal added!");
                break;
            case "2":
                //eternal goal, awarded every time it is recorded.
                manager.AddGoal(new EternalGoal(name, desc, points));
                Console.WriteLine("Eternal goal added!");
                break;
            case "3":
                // checklist goal with a target count and a bonus.
                Console.Write("How many times must it be completed? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points on final completion: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                Console.WriteLine("Checklist goal added!");
                break;
            default:
                Console.WriteLine("Unknown type. Goal not added.");
                break;
        }
    }

    // Shows the goal list and lets the user pick which one to mark progress on.
    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("Which goal did you work on?");
        manager.ListGoals();
        Console.Write("Enter goal number: ");

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            // The list is shown as 1-based, but GoalManager uses 0-based indexing internally.
            manager.RecordEvent(index - 1);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}