public class Assignment 
{
 private string _studentName;
 private string _topic;

// Constructor to initialize the student name and topic of the assignment
public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

// Method to return a summary of the assignment in simple terms
  public virtual string GetSummary()
  {
      return $"Student: {_studentName}, Topic: {_topic}";
  }
}