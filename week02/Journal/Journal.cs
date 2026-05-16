// This class holds all your journal entries
using System.IO; 
public class Journal

{
  
  // This is a list (like a growing list of pages) that stores all your journal entries in file
  List<Entry> _entries = new List<Entry>();

  // This adds a new entry (a new page) to your journal
  public void AddEntry(Entry entry)
  {
    _entries.Add(entry); // Put the new entry into the list
  }

  // This shows all the entries in your journal, one by one
  public void DisplayAll()
  {  // adding visibility to the journal display for easier reading
    Console.WriteLine("\n======= Journal Entries =======\n");
    foreach (Entry entry in _entries)
    {
      entry.Display(); // Show the entry details
      Console.WriteLine(); // Add a blank line between entries
    }
    Console.WriteLine("======= End of Entries =======\n");
  }

  // This saves all your journal entries to a file
  // Uses StreamWriter, just like in the CSE 210 CSV Reading and Writing Demo
  public void SaveToFile(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename)) // Open the file for writing
    {
      foreach (Entry entry in _entries)
      {
        // Write each part of the entry to the file, one line at a time
        writer.WriteLine($"Date: {entry._date}");
        writer.WriteLine($"Prompt: {entry._promptText}");
        writer.WriteLine($"Entry: {entry._entryText}");
        writer.WriteLine(); // Blank line between entries
      }
    }
  }

  // This loads all your journal entries from a file
  // Uses StreamReader, just like in the CSE 210 CSV Reading and Writing Demo
  public void LoadFromFile(string filename)
  {
    if (File.Exists(filename))
    {
      _entries.Clear(); // Start fresh by clearing out any old entries
      using (StreamReader reader = new StreamReader(filename)) // Open the file for reading
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          // Each entry starts with a line that says "Date: "
          if (line.StartsWith("Date: "))
          {
            Entry entry = new Entry();
            entry._date = line.Substring(6); // Get the date after "Date: "
            entry._promptText = reader.ReadLine().Substring(8); // Get the prompt after "Prompt: "
            entry._entryText = reader.ReadLine().Substring(7); // Get the entry text after "Entry: "
            _entries.Add(entry); // Add the entry to the list
          }
        }
      }
    }
    else
    {
      // If the file isn't found, let you know
      Console.WriteLine($"File '{filename}' not found.");
    }
  }
}