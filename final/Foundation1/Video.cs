public class Video //stores info about each video
{
    public string _title;
    public string _author;
    public int _length; //in seconds
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string commentAuthor, string text)
    {
        Comment comment = new Comment(commentAuthor, text);
        _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}