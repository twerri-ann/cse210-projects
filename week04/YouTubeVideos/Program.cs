using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Funny Cats Compilation", "CatLovers", 300);
        Video video3 = new Video("Top 10 Space Discoveries", "ScienceDaily", 900);

        video1.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video1.AddComment(new Comment("Bob", "I learned a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "This is exactly what I needed."));

        video2.AddComment(new Comment("Dave", "LOL, I can't stop laughing!"));
        video2.AddComment(new Comment("Eve", "My cat does this too."));
        video2.AddComment(new Comment("Frank", "The last one was hilarious."));

        video3.AddComment(new Comment("Grace", "Mind-blowing facts!"));
        video3.AddComment(new Comment("Heidi", "I love space science."));
        video3.AddComment(new Comment("Ivan", "Please make more videos like this."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
