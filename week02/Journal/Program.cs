using System;


// Main class for the Journal application
class Program
{
//     Functional Requirements
// This program must contain the following features:

// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
// Provide a menu that allows the user choose these options
// Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?
// Your interface should generally follow the pattern shown in the video demo below.
    static void Main(string[] args)
    {
        // original code
        Console.WriteLine("Hello World! This is the Journal Project.");

        // testing ranom prompt  
        //PromptGenerator promptGenerator = new PromptGenerator();

        // testing add entry
        // Entry entry = new Entry();
        // entry._date = DateTime.Now.ToString("yyyy-MM-dd");  
        // entry._promptText = promptGenerator.GetRandomPrompt();
        // entry._entryText = "This is my response to the prompt.";
        //entry.Display();

        // Entry entry2 = new Entry();
        // entry2._date = DateTime.Now.ToString("yyyy-MM-dd");  
        // entry2._promptText = promptGenerator.GetRandomPrompt(); 
        // entry2._entryText = "This is my second response to the prompt.";
        //entry2.Display();


        // testing journal 
        // Journal journal = new Journal();
        // journal.AddEntry(entry2);
        // journal.AddEntry(entry);
        //journal.DisplayAll();
        // journal.SaveToFile("journal.txt");
        // testing load from file
        // Journal loadedJournal = new Journal();
        // loadedJournal.LoadFromFile("journal.txt");
        // loadedJournal.DisplayAll();

        //now create simple UI with loops
    // Create main journal and prompt manager objects
    //  Use persistent objects so entries and prompts remain available throughout the session
    Journal journal = new Journal();
    PromptGenerator promptGenerator = new PromptGenerator();
    // Default filename for saving/loading
    //  Use a default filename to simplify user experience and avoid errors with empty filenames
    string filename = "journal.txt";
    // Menu options for the user
    // Use a multi-line string for readability and easy menu updates
    string menuOption = 
    @"Welcome to your Journal! Please choose an option:
    1. Write a new entry
    2. Display the journal
    3. Save the journal to a file
    4. Load the journal from a file
    5. Add a new prompt
    6. Display all prompts
    7. Exit";

    // Main loop to keep the program running until the user chooses to exit
    while (true)
    {
        // Show menu and get user choice
        Console.WriteLine(menuOption);
        string choice = Console.ReadLine();

        // Use string numbers for menu choices for simplicity

        // Option 1: Write a new journal entry
        if (choice == "1")
        {
            //Always use current date and a random prompt for each entry
            Entry entry = new Entry();
            entry._date = DateTime.Now.ToShortDateString();
            entry._promptText = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine("Your response:");
            entry._entryText = Console.ReadLine();
            journal.AddEntry(entry);
            Console.WriteLine("Entry added!");
        }
        // Option 2: Display all journal entries
        else if (choice == "2")
        {
            // Display all entries in memory for immediate feedback
            journal.DisplayAll();
        }
        //Save journal to a file
        else if (choice == "3")
        {
            // Allow user to change filename or use default for convenience
            Console.WriteLine($"Enter filename to save the journal (press Enter for default: {filename}):");
            string input = Console.ReadLine();
            // I use string.IsNullOrWhiteSpace to check if the input is empty or just spaces.
            // This prevents invalid filenames and makes the program more robust.
            // I learned about IsNullOrWhiteSpace from C# documentation and online tutorials—it's a common way to validate user input in .NET.
            // If input is empty, it keeps the default filename. Otherwise, it uses the user's input as the filename.
            if (!string.IsNullOrWhiteSpace(input))
            {
                filename = input;
            }
            //Save all entries to the specified file
            journal.SaveToFile(filename);
            Console.WriteLine($"Journal saved to {filename}");
        }
        //  Load journal from a file
        else if (choice == "4")
        {
            // Allow user to change filename or use default for convenience
            Console.WriteLine($"Enter filename to load the journal (press Enter for default: {filename}):");
            string input = Console.ReadLine();
            // Is
            if (!string.IsNullOrWhiteSpace(input))
            {
                filename = input;
            }
            //   Load entries from the specified file, replacing current entries
            journal.LoadFromFile(filename);
            Console.WriteLine($"Journal loaded from {filename}");
        }
        // Option 5: Add a new prompt
        else if (choice == "5")
        {
            //    Let user expand the prompt list dynamically for creativity
            Console.WriteLine("Enter the new prompt to add:");
            string newPrompt = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPrompt))
            {
                //   Add prompt to both memory and file for persistence
                promptGenerator.AddPrompt(newPrompt);
                Console.WriteLine("Prompt added!");
            }
            else
            {
                // Prevent empty prompts for data quality
                Console.WriteLine("Prompt cannot be empty.");
            }
        }
        // Option 6: Display all prompts
        else if (choice == "6")
        {
            //  : Show all prompts so user can review or get inspiration
            promptGenerator.DisplayAllPrompts();
        }
        // Option 7: Exit the program
        else if (choice == "7")
        {
            //    Clean exit with goodbye message
            Console.WriteLine("Goodbye!");
            break;
        }
        // Handle invalid menu options
        else
        {
            //  : Guide user to valid input
            Console.WriteLine("Invalid option. Please try again.");
        }
    }


    }
}