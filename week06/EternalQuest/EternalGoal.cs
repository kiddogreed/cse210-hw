// An eternal goal never fully ends — like reading scriptures every day.
public class EternalGoal : Goal
{
  public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
  {
  }

  // Load constructor — restores the last-recorded date from a file.
  public EternalGoal(string shortName, string description, int points, DateTime? lastRecorded) : base(shortName, description, points, lastRecorded)
  {
  }

  // Always awards points — no limit, the goal repeats forever.
  public override int RecordEvent()
  {
      SetLastRecorded(); // stamps today's date and time each time this is recorded
      Console.WriteLine($"You earned {GetPoints()} points for: {GetShortName()}!");
      return GetPoints();
  }

  // Eternal goals are never "done" — they keep going indefinitely.
  public override bool IsComplete()
  {
      return false;
  }

  // Always shows [ ] because it can never be fully checked off, plus the last recorded date.
  public override string GetDisplayString()
  {
      return $"[ ] {GetShortName()} ({GetDescription()})  |  {GetLastRecordedString()}";
  }

  // Saves to file with the type tag.
  public override string GetStringRepresentation()
  {
      return $"EternalGoal|{base.GetStringRepresentation()}";
  }
}