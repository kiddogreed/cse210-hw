// This class helps to manage journal prompts

public class PromptGenerator
{

  // store all promtps 
  List<string> _prompts = new List<string>();


  // The file  prompts are saved and loaded
  string _filePath = "prompts.txt";
  // This is the name of the filse where your questions are saved

  //loads prompts from the file
  public PromptGenerator()
  {
    // This part happens automatically when you make a new PromptGenerator
    if (File.Exists(_filePath))
    {
      // If the file is there
      // Read all prompts from the file and add them to the list
      _prompts.AddRange(File.ReadAllLines(_filePath));
    }
    else
    {
    
      //  error if the file doesn't exist
      Console.WriteLine($"Error: The file {_filePath} does not exist.");
    }
  }

  // Add a new prompt 
  public void AddPrompt(string prompt)
  {
    // This lets you add a new question to your bucket and also saves it to the file
    _prompts.Add(prompt);
    File.AppendAllLines(_filePath, new[] { prompt });
  }

  // Get a random prompt from the file
  public string GetRandomPrompt()
  {
    // This gives you a surprise question from your bucket
    if (_prompts.Count == 0)
    {
      // If your bucket is empty, tell you so
      return "No prompts available.";
    }
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }

//  to see all the prompts
  public void DisplayAllPrompts()
  {
    // This shows you every question in your bucket, one by one
    Console.WriteLine("Available Prompts:");
    foreach (string prompt in _prompts)
    {
      Console.WriteLine($"-{prompt}");
    }
  }
}