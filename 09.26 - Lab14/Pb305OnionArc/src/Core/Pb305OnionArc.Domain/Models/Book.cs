namespace Pb305OnionArc.Domain.Models;

public class Book(string title, BookStatus status, string authorId) : AuditableEntity()
{
    public string Title { get; private set; } = title;
    public BookStatus Status { get; private set; } = status;
    public string AuthorId { get; private set; } = authorId;
    public Author? Author { get; private set; }
}