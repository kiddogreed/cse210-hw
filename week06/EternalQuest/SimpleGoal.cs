// A simple goal can only be completed once, like running a marathon.
public class SimpleGoal : Goal
{
  // Tracks whether this goal has been marked done.
  private bool _isComplete;

  // Standard constructor — starts as not complete.
  public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
  {
      _isComplete = false;
  }

  // Load constructor — restores the completion state and last-recorded date from a file.
  public SimpleGoal(string shortName, string description, int points, DateTime? lastRecorded, bool isComplete) : base(shortName, description, points, lastRecorded)
  {
      _isComplete = isComplete;
  }

  // Awards points only the first time. Returns 0 if already done.
  public override int RecordEvent()
  {
      if (!_isComplete)
      {
          _isComplete = true;
          SetLastRecorded(); // stamps today's date and time on this goal
          Console.WriteLine($"You earned {GetPoints()} points for completing: {GetShortName()}!");
          return GetPoints();
      }
      else
      {
          Console.WriteLine($"Already completed: {GetShortName()}");
          return 0;
      }
  }

  // Returns true once the goal has been recorded once.
  public override bool IsComplete()
  {
      return _isComplete;
  }

  // Shows [X] when done, [ ] otherwise, plus the last recorded date.
  public override string GetDisplayString()
  {
      string status = _isComplete ? "[X]" : "[ ]";
      return $"{status} {GetShortName()} ({GetDescription()})  |  {GetLastRecordedString()}";
  }

  // Saves to file with the type tag and the completion flag.
  public override string GetStringRepresentation()
  {
      return $"SimpleGoal|{base.GetStringRepresentation()}|{_isComplete}";
  }
}