namespace List.Tasks.Models;

public partial class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public Genre Genre { get; set; }

    public override string ToString()
    {
        return $"Title {Title}, Author {Author}, Year {Year}";
    }
}
