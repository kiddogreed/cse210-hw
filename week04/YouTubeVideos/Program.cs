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
        Video v1 = new Video("Learning C#", "John", 300);
        v1.AddComment(new Comment("Peter", "Great explanation!"));
        v1.AddComment(new Comment("James", "Very helpful."));
        v1.AddComment(new Comment("Matt", "Loved the examples!"));

        // Create the second video: a cooking video by Chef Mia, 480 seconds (8 min) long.
        Video v2 = new Video("Brain Blast Experiment", "Doc Godard", 1000);
        v2.AddComment(new Comment("Sheen", "Looks delicious!"));
        v2.AddComment(new Comment("Carl", "I’ll try this tonight."));
        v2.AddComment(new Comment("Jimmy", "Perfect recipe!"));

        // Create the third video: a Japan travel vlog by Sam, 720 seconds (12 min) long.
        Video v3 = new Video("Travel Vlog: PHilippines", "Russelle", 720);
        v3.AddComment(new Comment("Unknown67", "Beautiful scenery!"));
        v3.AddComment(new Comment("@edisapusoMo!", "I want to visit Japan now."));
        v3.AddComment(new Comment("destroyer69", "Amazing video!"));

        // Add all three videos to our list so we can loop through them easily.
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Loop through each video in the list and call its DisplayInfo() method to print all the details.  
         Video.DisplayAll(videos);
        


    }
}