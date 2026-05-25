using System;

// This is the main entry point of the program.
// It creates a few sample YouTube videos, adds comments to each one,
// then displays all the video info on the screen.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create an empty list that will hold all of our Video objects.
         List<Video> videos = new List<Video>();

        // Create the first video: a C# tutorial by Alice that is 600 seconds (10 min) long.
        // Then add three comments from different viewers.
        Video v1 = new Video("Learning C#", "Alice", 600);
        v1.AddComment(new Comment("Bob", "Great explanation!"));
        v1.AddComment(new Comment("Charlie", "Very helpful."));
        v1.AddComment(new Comment("Dana", "Loved the examples!"));

        // Create the second video: a cooking video by Chef Mia, 480 seconds (8 min) long.
        Video v2 = new Video("Cooking Pasta", "Chef Mia", 480);
        v2.AddComment(new Comment("Leo", "Looks delicious!"));
        v2.AddComment(new Comment("Nina", "I’ll try this tonight."));
        v2.AddComment(new Comment("Omar", "Perfect recipe!"));

        // Create the third video: a Japan travel vlog by Sam, 720 seconds (12 min) long.
        Video v3 = new Video("Travel Vlog: Japan", "Sam", 720);
        v3.AddComment(new Comment("Tina", "Beautiful scenery!"));
        v3.AddComment(new Comment("Raj", "I want to visit Japan now."));
        v3.AddComment(new Comment("Ella", "Amazing video!"));

        // Add all three videos to our list so we can loop through them easily.
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Go through each video in the list and print its details to the screen.
        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}