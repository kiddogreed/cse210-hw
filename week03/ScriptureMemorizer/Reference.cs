// This class is for storing a scripture reference, like "John 3:16" or "John 3:16-17"
public class Reference
{
  
    private string _book;  // name of the book (like "John")
   
    private int _chapter; //  chapter number (like 3)
   
    private int _verse; //  starting verse number (like 16)
  
    private int _endVerse;  // The ending verse number (if there is a range, like 17)


    //  constructor  for a single verse 
    public Reference(string book, int chapter, int verse)
    {
        _book = book; // Set the book name
        _chapter = chapter; // Set the chapter number
        _verse = verse; // Set the verse number
        // _endVerse is left as 0 (not used)
    }

    //  constructor  for a verse with range 
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book; // Set the book name
        _chapter = chapter; // Set the chapter number
        _verse = verse; // Set the starting verse number
        _endVerse = endVerse; // Set the ending verse number
    }

    //gives back the reference as a string to show to the user
    public string GetDisplayText()
    {
        // If there is an end verse, show the range (like "John 3:16-17")
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Show book, chapter, start verse, and end verse
        }
        else // no end verse
        {
            return $"{_book} {_chapter}:{_verse}"; // Show book, chapter, and verse only
        }
    }

 
} 