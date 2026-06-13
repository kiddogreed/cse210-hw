// GoalManager owns the player's score and their full list of goals.
public class GoalManager
{
  // Running total of all points the player has earned.
  private int _score;
  // All goals in the player's list — can be any goal type since they all extend Goal.
  private List<Goal> _goals;

  public GoalManager()
  {
      _score = 0;
      _goals = new List<Goal>();
  }

  // Adds a new goal to the player's list.
  public void AddGoal(Goal goal)
  {
      _goals.Add(goal);
  }

  // Prints the player's current score and their level title side by side.
  public void DisplayPlayerInfo()
  {
      Console.WriteLine($"Score: {_score} points  |  Level: {GetLevel()}");
  }

  // Returns a level title based on score thresholds.
  // Exceeds Requirements — Creativity: a progression system that rewards the player as they earn more points.
  private string GetLevel()
  {
      if (_score >= 10000) return "Eternal Master";
      if (_score >= 5000)  return "Celestial Champion";
      if (_score >= 2000)  return "Faithful Adventurer";
      if (_score >= 500)   return "Rising Seeker";
      return "Novice Seeker";
  }

  // Lists all goals with their [ ]/[X] status and any extra detail.
  public void ListGoals()
  {
      if (_goals.Count == 0)
      {
          Console.WriteLine("No goals yet. Create one first!");
          return;
      }
      for (int i = 0; i < _goals.Count; i++)
      {
          Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
      }
  }

  // Records progress on the chosen goal and adds the earned points to the score.
  // RecordEvent() returns the points earned, so we just add that return value here.
  public void RecordEvent(int goalIndex)
  {
      if (goalIndex >= 0 && goalIndex < _goals.Count)
      {
          int earned = _goals[goalIndex].RecordEvent();
          _score += earned;
      }
      else
      {
          Console.WriteLine("Invalid goal selection.");
      }
  }

  // Writes the score and all goals to a text file so progress is not lost.
  public void SaveGoals(string filename)
  {
      using (StreamWriter writer = new StreamWriter(filename))
      {
          writer.WriteLine(_score);
          foreach (var goal in _goals)
          {
              writer.WriteLine(goal.GetStringRepresentation());
          }
      }
      Console.WriteLine("Goals saved.");
  }

  // Reads a previously saved file and rebuilds each goal from the stored text.
  public void LoadGoals(string filename)
  {
      if (!File.Exists(filename))
      {
          Console.WriteLine("Save file not found.");
          return;
      }

      using (StreamReader reader = new StreamReader(filename))
      {
          _score = int.Parse(reader.ReadLine());
          _goals.Clear();
          string line;
          while ((line = reader.ReadLine()) != null)
          {
              string[] parts = line.Split('|');
              switch (parts[0])
              {
                  case "SimpleGoal":
                      // File format: type|name|desc|points|lastRecorded|isComplete
                      _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), ParseLastRecorded(parts[4]), bool.Parse(parts[5])));
                      break;
                  case "EternalGoal":
                      // File format: type|name|desc|points|lastRecorded
                      _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), ParseLastRecorded(parts[4])));
                      break;
                  case "ChecklistGoal":
                      // File format: type|name|desc|points|lastRecorded|amountCompleted|target|bonus
                      _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[5]), ParseLastRecorded(parts[4])));
                      break;
                  default:
                      Console.WriteLine($"Unknown goal type skipped: {parts[0]}");
                      break;
              }
          }
      }
      Console.WriteLine("Goals loaded.");
  }

  // Converts a saved date string back to a DateTime. Returns null if "never".
  // Uses InvariantCulture to ensure the format always parses correctly regardless of system locale.
  private static DateTime? ParseLastRecorded(string s)
  {
      return s == "never"
          ? (DateTime?)null
          : DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
  }
}