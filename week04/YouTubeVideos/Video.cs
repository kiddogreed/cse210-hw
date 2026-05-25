// This class represents a YouTube video.
// Think of it like a single video card on YouTube — it has a title, who made it,
// how long it is, and a list of comments people left on it.
public class Video
{
  // The name/title of the video (e.g., "Learning C#")
  private string _title;

  // The person who uploaded or created the video (e.g., "Alice")
  private string _author;

  // How long the video is, measured in seconds (e.g., 600 = 10 minutes)
  private int length;

  // A list that holds all the Comment objects for this video.
  // It starts empty and we add comments to it later.
  public List<Comment> comments = new List<Comment>();

  // Constructor — called when we create a new Video.
  // You provide the title, author, and length, and it saves them.
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    this.length = length;
  }

  // Returns how many comments have been added to this video.
  // It just counts the items in the comments list.
  public int NumberOfComments()
  {
    return comments.Count;
  }

  // Adds a new Comment object to this video's comment list.
  // Like clicking "Post comment" on YouTube.
  public void AddComment(Comment comment)
  {
      comments.Add(comment);
  }

  // Prints all the video's information to the screen:
  // title, author, length, total comment count, and each comment's text and author.
  public void DisplayInfo()
  {
      Console.WriteLine($"Title: {_title}");
      Console.WriteLine($"Author: {_author}");
      Console.WriteLine($"Length: {length} seconds");
      Console.WriteLine($"Number of comments: {NumberOfComments()}");
      Console.WriteLine("Comments:");
      foreach (Comment c in comments)
      {
          // Print the comment text first, then the name of who wrote it.
          Console.WriteLine($"- {c.GetCommentText()}: {c.GetCommenterName()}");
      }
      Console.WriteLine();
  }
}