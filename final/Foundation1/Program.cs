using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();

        List<Comment> comments1 = new List<Comment>();
        Comment comment1_1 = new Comment("sunnShine", "so pretty!!");
        comments1.Add(comment1_1);
        Comment comment1_2 = new Comment("hoogabooga", "Walks away with suspicious art-shaped lump");
        comments1.Add(comment1_2);
        Comment comment1_3 = new Comment("artiist", "How did you do the shading on page 3?");
        comments1.Add(comment1_3);
        Video video1 = new Video(comments1, "My Sketchbook Tour", "creativeCat", 600);
        videos.Add(video1);

        List<Comment> comments2 = new List<Comment>();
        Comment comment2_1 = new Comment("foxy23", "this looks delicious!");
        comments2.Add(comment2_1);
        Comment comment2_2 = new Comment("c0c0a", "can I have some?");
        comments2.Add(comment2_2);
        Comment comment2_3 = new Comment("Maisy_4", "Love your content! I'll be sure to make this for my son's birthday");
        comments2.Add(comment2_3);
        Video video2 = new Video(comments2, "How to Make the Best Chocolate Cake", "iLoveChocolate", 1100);
        videos.Add(video2);

        List<Comment> comments3 = new List<Comment>();
        Comment comment3_1 = new Comment("Astrid", "Can't wait to go flying with you later.");
        comments3.Add(comment3_1);
        Comment comment3_2 = new Comment("Fishlegs", "Does this technique work on all dragons? Would any step change depending on species? Or the size of the dragon? Should we use the dragon's favorite food, and how would we know what it is?");
        comments3.Add(comment3_2);
        Comment comment3_3 = new Comment("roughnut", "siccck");
        comments3.Add(comment3_3);
        Video video3 = new Video(comments3, "How to Befriend a Dragon", "Hiccup", 2500);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("\n---------------------------");
            Console.WriteLine();
            Thread.Sleep(3000);
        }
    }
}