// ScriptureManager: think of this as a bookshelf.
// It holds a collection of scriptures, lets you load them from a file,
// add new ones manually, and grab a random one to use in the game.
public class ScriptureManager
{
    private List<Scripture> _scriptures; // List to hold all the scriptures

    // Sets up an empty bookshelf — ready to receive scriptures.
    public ScriptureManager()
    {
        _scriptures = new List<Scripture>(); // Initialize the list of scriptures
    }

    // Opens a text file and reads every scripture inside it, one line at a time.
    // Each line must follow the format: Book|Chapter|Verse|Text
    // Splits each line at the "|" symbol to get the book, chapter, verse, and text separately.
    public void LoadFromFile(string filePath)
    {
        foreach (string line in File.ReadAllLines(filePath))
        {
            string[] parts = line.Split('|');
            if (parts.Length < 4) continue; // Skip malformed lines

            string book    = parts[0];
            int chapter    = int.Parse(parts[1]); // Convert the chapter text to a number
            int verse      = int.Parse(parts[2]); // Convert the verse text to a number
            string text    = parts[3];

            Reference reference = new Reference(book, chapter, verse);
            _scriptures.Add(new Scripture(reference, text));
        }
    }

    // Lets you add a single scripture by hand instead of loading from a file.
    // Useful for testing or adding a scripture on the fly.
    // Method to manually add a scripture to the manager
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    // Picks a scripture at random from the bookshelf and returns it.
    // If the bookshelf is empty, returns nothing so the program doesn't crash.
    // Method to get a random scripture from the manager
    public Scripture GetRandomScripture(Random random)
    {
        if (_scriptures.Count == 0) // Safety check — nothing to pick from
            return null;

        int index = random.Next(_scriptures.Count); // Pick a random index from the list
        return _scriptures[index];
    }
}