using System.ComponentModel;
using System.Globalization;

class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private double _length;
    private string _author;
    public Video(List<Comment> comments, string title, string author, int length)
    {
        foreach (Comment comment in comments)
        {
            _comments.Add(comment);
        }
        _title = title;
        _author =author;
        _length = length;
    }
    public int CommentNum()
    {
        int num = 0;
        foreach (Comment comment in _comments)
        {
            num += 1;
        }
        return num;
    }
    public void Display()
    {
        double minutes = _length / 60;
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"({_length:F0} seconds ({minutes:F2} minutes) long)");
        int comment_num = CommentNum();
        Console.WriteLine($"\nComments: {comment_num}");
        foreach (Comment comment in _comments)
        {
            comment.Summary();
        }
    }
}