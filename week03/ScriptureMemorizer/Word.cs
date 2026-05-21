public class Word
{

//I am using encapsulation to keep the word's text and hidden while providing public methods to interact with it.
 private string _text;
 private bool _isHidden;

//constructor to initialize the word with its text and set it to not hidden by default.
  public Word(string text)
  {
    _text = text;  // Set the word's text.
    _isHidden = false;  //default to not hidden when created.
  } 




      // This method hides the word.
      public void Hide()
      {
          _isHidden = true;
      }

      // This method makes the word visible again.
      public void Show()
      {
          _isHidden = false;
      }

      // This method returns what should be displayed for the word.
      // If the word is hidden, it shows underscores instead of the letters.
      // If not hidden, it shows the actual word.
      public string GetDisplayText()
      {
          if (_isHidden)
          {
              // Show underscores for each letter if hidden.
              return new string('_', _text.Length);// Create a string of underscores with the same length as the word.
          }
          else
          {
              // Show the real word if not hidden.
              return _text;
          }
      }
  }