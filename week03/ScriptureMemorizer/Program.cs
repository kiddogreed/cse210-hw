using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

//  Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// Clear the console screen and display the complete scripture, including the reference and the text.
// Prompt the user to press the enter key or type quit.
// If the user types quit, the program should end.
// If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again. (Hiding a word means that the word should be replace by underscores (_) and the number of underscores should match the number of letters in that word.)
// The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// When all words in the scripture are hidden, the program should end. (The final display of the scripture should show the scripture with all words hidden.)
// When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

// testing values and code
  string book = "John";
  int chapter = 3;
  int verse = 16;
  int endVerse = 0; // Example of an end verse for a range
  Random random = new Random();
  int hideRandom = random.Next(1, 10); // Example of generating a random number between 1 and 10
  string text = "16 For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."; 

// // testing code to create a scripture and display it
  Reference testScriptureRef = new Reference(book, chapter, verse); // Create a Reference object for "John 3:16"
  Scripture testScripture = new Scripture(testScriptureRef, text); // Create a Scripture object with the reference and text
//   Console.WriteLine(testScripture.GetDisplayText()); // Display the scripture text with the reference

//   // testing code to hide random words and display the scripture again
//   testScripture.HideRandomWords(3); // Hide 3 random words in the scripture
//   Console.WriteLine(testScripture.GetDisplayText()); // Display the scripture text again with some
//   testScripture.HideRandomWords(4); 
//   Console.WriteLine(testScripture.GetDisplayText());
//   testScripture.HideRandomWords(5);
//   Console.WriteLine(testScripture.GetDisplayText());
//   testScripture.HideRandomWords(6); 
//   Console.WriteLine(testScripture.GetDisplayText()); 

  //all components are working independently, now I need to connect them together in the main program loop to meet the requirements of the project.
  // add read left arrowkey to undo hiding words (stretch challenge) done
  // read scripture from a file instead of hardcoding it (stretch challenge) - not  yet
  // randomly select a scripture from a list of scriptures (stretch challenge)- not  yet


  //for the main loop
    while (true)
    {
        Console.Clear(); // Clear the  screen
        Console.WriteLine(testScripture.GetDisplayText()); // Display the scripture text with the reference

        if (testScripture.isCompletelyHidden()) // Check if all words are hidden
        {
            break; // Exit the loop if all words are hidden
        }

        Console.WriteLine("Press Enter to hide words, Left Arrow to undo, or type 'quit' to exit.");

        // Inner loop: reads keypresses one at a time so we can catch arrow keys AND let the user type "quit".
        string typed = "";    // Builds up what the user types letter by letter
        bool handled = false; // Becomes true once we know what action to take
        bool shouldQuit = false;

        while (!handled)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read one key silently (don't print it automatically)

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (typed.ToLower() == "quit") // User typed "quit" and hit Enter
                {
                    shouldQuit = true;
                }
                else // Just pressed Enter without typing anything (or typed something else)
                {
                    testScripture.HideRandomWords(hideRandom); // Hide more words
                }
                handled = true;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow && typed == "") // Left arrow only works before typing
            {
                testScripture.ShowHiddenWords(hideRandom); // Undo — reveal some hidden words
                handled = true;
            }
            else if (keyInfo.Key == ConsoleKey.Backspace && typed.Length > 0)
            {
                typed = typed.Substring(0, typed.Length - 1); // Remove the last letter
                Console.Write("\b \b"); // Erase the last character shown on screen
            }
            else if (!char.IsControl(keyInfo.KeyChar)) // Any normal letter or number
            {
                typed += keyInfo.KeyChar;       // Add it to what we're building
                Console.Write(keyInfo.KeyChar); // Show it on screen so the user can see what they typed
            }
        }

        if (shouldQuit) break; // Exit the main loop if the user typed "quit"
    //
     Console.Clear(); // Clear the  screen
      Console.WriteLine(testScripture.GetDisplayText()); // Display the scripture text with the reference
  }
  

  }
}