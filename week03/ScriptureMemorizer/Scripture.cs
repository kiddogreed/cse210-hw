public class Scripture
{
   private Reference _reference; // The scripture reference (like "John 3:16")
    private List<Word> _words; // The list of words in the scripture text

    // Constructor to initialize the scripture with a reference and text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference; // Set the scripture reference
        _words = new List<Word>(); // Initialize the list of words
        foreach (string word in text.Split(' ')) // Split the text into words
        {
            _words.Add(new Word(word)); // Create a Word object for each word and add it to the list
        }

      
    }

    public void HideRandomWords(int numbertToHide )
    {
        // This method hides a specified number of random words in the scripture.
        // It uses a loop to hide words until the desired number is hidden.
        // It checks to avoid hiding the same word multiple times.\
        Random random = new Random(); // Create a random number generator
        int hiddenCount = 0; // Keep track of how many words have been hidden
        while (hiddenCount < numbertToHide)
        {
            int index = random.Next(_words.Count); // Get a random index for the words list
            if (!_words[index].GetDisplayText().Contains('_')) // Check if the word is not already hidden
            {
                _words[index].Hide(); // Hide the word at the random index
                hiddenCount++; // Increment the count of hidden words
            }
        }
     
    }

    // temporary method to add words to the scripture (for testing purposes)

 //For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.
   

    public string GetDisplayText()
    {
        // This method constructs the display text for the scripture.
        // It starts with the reference and then adds each word's display text.
        // Hidden words will show as underscores, while visible words show normally.
        string displayText = _reference.GetDisplayText() + " "; // Start with the reference
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; // Add each word's display text
        }
        return displayText.Trim(); // Remove any extra space at the end
    }

    public bool isCompletelyHidden()
    {
        // This method checks if all words in the scripture are hidden.
        // It returns true if every word is hidden, and false if any word is still visible.
        foreach (Word word in _words)
        {
            if (!word.GetDisplayText().Contains('_')) // If the word is not hidden
            {
                return false; // Not completely hidden
            }
        }
        return true; // All words are hidden
    }
}