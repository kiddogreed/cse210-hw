public class WritingAssignment : Assignment
{
   // Private string to store the title of the writing assignment
   private string _title;

   // Constructor that takes a student name, topic, and title as arguments and passes the student name and topic to the base class constructor
   public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

   // Override of GetSummary() method from base class to return a summary of the assignment
   public override string GetSummary()
   {
    return base.GetSummary();
   }

   // Method that returns information about the writing assignment including its title
   public string GetWritingInformation()
   {
    return $"Title: {_title}";
   }
}

