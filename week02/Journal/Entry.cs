using System;
//  represents a single journal entry
public class Entry
{
  //  date when the entry was written
  public string _date;
  //  question or prompt for the journal entry
  public string _promptText;
  //  text written by the user in response to the prompt
  public string _entryText;

  //  method shows the entry details 
  public void Display()
  {
    // adding visibility to the entry display for easier reading
    Console.WriteLine("------------------------------");
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Prompt: {_promptText}");
    Console.WriteLine($"Entry: {_entryText}");
    Console.WriteLine("------------------------------");
  }
}