using System.Dynamic;

class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title} by {_author}");
        Console.WriteLine($"Number of comments: {this.GetCommentCount()}");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}:\n{comment.GetText()}");
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}