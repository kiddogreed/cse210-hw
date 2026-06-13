// Base class — holds the things every goal type has in common.
public class Goal
{
  // Private fields — only accessible inside this class.
  private string _shortName;
  private string _description;
  private int _points;
  // Tracks the last time the user recorded this goal. Null means never recorded yet.
  private DateTime? _lastRecorded;

  // Standard constructor — starts with no recorded date.
  public Goal(string shortName, string description, int points)
  {
      _shortName = shortName;
      _description = description;
      _points = points;
      _lastRecorded = null;
  }

  // Load constructor — also restores a previously saved last-recorded date.
  public Goal(string shortName, string description, int points, DateTime? lastRecorded)
  {
      _shortName = shortName;
      _description = description;
      _points = points;
      _lastRecorded = lastRecorded;
  }

  // Getter so GoalManager and child classes can read the point value.
  public int GetPoints()
  {
      return _points;
  }

  // Getter for the short name, used when building display text.
  public string GetShortName()
  {
      return _shortName;
  }

  // Getter for the description, used when building display text.
  public string GetDescription()
  {
      return _description;
  }

  // Stamps the current date and time on this goal.
  // Child classes call this whenever they actually award points.
  protected void SetLastRecorded()
  {
      _lastRecorded = DateTime.Now;
  }

  // Returns a readable last-recorded message for display.
  // Shows "Never recorded" if the goal has not been worked on yet.
  protected string GetLastRecordedString()
  {
      return _lastRecorded.HasValue
          ? $"Last: {_lastRecorded.Value:yyyy-MM-dd HH:mm}"
          : "Never recorded";
  }

  // Called when the user records progress on a goal.
  // Returns how many points were earned. Child classes override with their own rules.
  public virtual int RecordEvent()
  {
      SetLastRecorded();
      Console.WriteLine($"You earned {_points} points!");
      return _points;
  }

  // Whether this goal counts as finished. Base version always says no.
  // Child classes override to add their own completion logic.
  public virtual bool IsComplete()
  {
      return false;
  }

  // One-line summary shown when listing goals — shows [ ] or [X] status plus last recorded date.
  // Child classes override to add extra detail like a progress count.
  public virtual string GetDisplayString()
  {
      string status = IsComplete() ? "[X]" : "[ ]";
      return $"{status} {_shortName} ({_description})  |  {GetLastRecordedString()}";
  }

  // Converts goal data to a pipe-separated string for saving to a file.
  // Saves lastRecorded as "yyyy-MM-dd HH:mm:ss" or "never" if null.
  // Child classes override to include their extra fields after this base part.
  public virtual string GetStringRepresentation()
  {
      string lastStr = _lastRecorded.HasValue
          ? _lastRecorded.Value.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
          : "never";
      return $"{_shortName}|{_description}|{_points}|{lastStr}";
  }
}