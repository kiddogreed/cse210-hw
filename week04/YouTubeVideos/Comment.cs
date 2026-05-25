// This class represents a single comment left on a YouTube video.
// Just like when you type a comment under a video, this stores who said it and what they said.
public class Comment
{
  // The name of the person who wrote the comment (e.g., "Bob")
  private string _commenterName;

  // The actual message the person wrote (e.g., "Great video!")
  private string _commentText;

  // This is the constructor — it runs when we create a new Comment.
  // You give it the commenter's name and their message, and it saves both.
  public Comment(string commenterName, string commentText)
  {
    _commenterName = commenterName;
    _commentText = commentText;
  }

  // Returns the name of the person who wrote the comment.
  public string GetCommenterName()
  {
    return _commenterName;
  }

  // Returns the text/message of the comment.
  public string GetCommentText()
  {
    return _commentText;
  }
}