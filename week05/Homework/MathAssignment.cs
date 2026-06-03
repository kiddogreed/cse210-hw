// Define a class for math assignments that inherits from the Assignment base class
public class MathAssignment : Assignment {
    // Declare private fields to store the textbook section and problems for this assignment
    private string _textbookSection;
    private string _problems;

  // Constructor that takes in values for student name, topic, textbook section, and problems
  public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) {
        // Initialize the private fields with the provided values
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Override the GetSummary method from the base class to include the textbook section in the summary
    public override string GetSummary() {
        return $"{base.GetSummary()}, Textbook Section: {_textbookSection}";
    }

    // Method to get a list of homework assignments, including the textbook section and problems
    public string GetHomeworkList() {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}