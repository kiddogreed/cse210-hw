// A checklist goal must be done a set number of times to complete.
// Example: attend the temple 10 times for a big bonus.
public class ChecklistGoal : Goal
{
  // Tracks how many times the user has recorded this goal.
  private int _amountCompleted;
  // How many times it must be done total.
  private int _target;
  // Extra points awarded when the target is finally reached.
  private int _bonus;

  // Standard constructor — starts with zero completions.
  public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
  {
      _amountCompleted = 0;
      _target = target;
      _bonus = bonus;
  }

  // Load constructor — restores the progress count and last-recorded date from a file.
  public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted, DateTime? lastRecorded) : base(shortName, description, points, lastRecorded)
  {
      _amountCompleted = amountCompleted;
      _target = target;
      _bonus = bonus;
  }

  // Awards regular points each time. Adds a bonus when the target count is hit.
  public override int RecordEvent()
  {
      if (_amountCompleted >= _target)
      {
          Console.WriteLine($"Already finished: {GetShortName()}");
          return 0;
      }

      _amountCompleted++;
      SetLastRecorded(); // stamps today's date and time each time progress is recorded
      int earned = GetPoints();
      Console.WriteLine($"You earned {earned} points for: {GetShortName()}! ({_amountCompleted}/{_target})");

      if (_amountCompleted == _target)
      {
          earned += _bonus;
          Console.WriteLine($"BONUS! Goal complete — you earned an extra {_bonus} points!");
      }

      return earned;
  }

  // Complete when the count reaches the target.
  public override bool IsComplete()
  {
      return _amountCompleted >= _target;
  }

  // Shows [ ] or [X] plus the current progress count and last recorded date.
  public override string GetDisplayString()
  {
      string status = IsComplete() ? "[X]" : "[ ]";
      return $"{status} {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target} times  |  {GetLastRecordedString()}";
  }

  // Saves full state — name, desc, points, progress count, target, and bonus.
  public override string GetStringRepresentation()
  {
      return $"ChecklistGoal|{base.GetStringRepresentation()}|{_amountCompleted}|{_target}|{_bonus}";
  }
}