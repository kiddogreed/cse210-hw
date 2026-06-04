namespace Mindfulness;

public class Activity
{
  private readonly string _name;
  private readonly string _description;

  protected int _duration;

  public Activity()
    : this("", "")
  {
  }

  protected Activity(string name, string description)
  {
    _name = name;
    _description = description;
    _duration = 0;
  }

  public void DisplayStartingMessage()
  {
    // Show the activity name and a short explanation.
    Console.WriteLine($"Welcome to the {_name} activity.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    // Ask how long the user wants to do this activity.
    Console.Write("How long, in seconds, would you like your session? ");

    string input = Console.ReadLine() ?? string.Empty;
    // Use a default length if the input is missing or not a number.
    if (!int.TryParse(input, out _duration) || _duration <= 0)
    {
      _duration = 30;
    }

    Console.WriteLine();
    // Give the user a short moment to get ready.
    Console.WriteLine("Get ready...");
    ShowSpinner(3);
    Console.WriteLine();
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    // Let the user know the activity is finished.
    Console.WriteLine("Well done!");
    Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    Console.WriteLine();
    // Pause a little before returning to the menu.
    ShowSpinner(3);
    Console.WriteLine();
  }

  public static void ShowSpinner(int duration)
  {
    // Show a small moving mark while the app waits.
    string[] frames = ["|", "/", "-", "\\"];
    // Each full spin has four quick steps.
    int ticks = duration * 4;

    for (int i = 0; i < ticks; i++)
    {
      Console.Write(frames[i % frames.Length]);
      Thread.Sleep(250);
      Console.Write("\b");
    }
  }

  public static void ShowCountDown(int duration)
  {
    // Count down so the user can prepare to start.
    for (int i = duration; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}