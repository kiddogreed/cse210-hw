public class Scripture
{
   private Reference _reference; // The scripture reference (like "John 3:16")
    private List<Word> _words; // The list of words in the scripture text

     Random random = new Random();

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

    public void HideRandomWords(int numberToHide)
    {
        // Build a list of positions (indexes) for words that are still visible.
        // This way we never pick the same word twice, and there's no infinite loop.
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden()) // Only include words that are not already hidden
                visibleIndexes.Add(i);
        }

        // If there aren't enough visible words, just hide whatever is left.
        int count = Math.Min(numberToHide, visibleIndexes.Count);

        for (int i = 0; i < count; i++)
        {
            int pick = random.Next(visibleIndexes.Count); // Pick a random position from the visible list
            _words[visibleIndexes[pick]].Hide(); // Hide that word
            visibleIndexes.RemoveAt(pick); // Remove it so we can't pick it again
        }
    }

    // Stretch challenge: undo hiding by revealing random words that are currently hidden.
    public void ShowHiddenWords(int numberToShow)
    {
        // Build a list of positions (indexes) for words that are currently hidden.
        // Same safe approach as HideRandomWords — no infinite loop, no duplicate picks.
        List<int> hiddenIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden()) // Only include words that are hidden
                hiddenIndexes.Add(i);
        }

        // If there aren't enough hidden words, just show whatever is hidden.
        int count = Math.Min(numberToShow, hiddenIndexes.Count);

        for (int i = 0; i < count; i++)
        {
            int pick = random.Next(hiddenIndexes.Count); // Pick a random position from the hidden list
            _words[hiddenIndexes[pick]].Show(); // Show (un-hide) that word
            hiddenIndexes.RemoveAt(pick); // Remove it so we can't pick it again
        }
    }
   

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
            if (!word.IsHidden()) // If the word is not hidden
            {
                return false; // Not completely hidden
            }
        }
        return true; // All words are hidden
    }
}