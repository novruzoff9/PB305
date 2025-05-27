using List.Tasks.Models;

namespace List.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Author = "Eli Eliev",
                Year = 2015,
                Title = "Kitab1",
                Genre = Genre.Drama
            };
            Book book2 = new Book()
            {
                Author = "Eli Sadiqov",
                Year = 2010,
                Title = "Kitab2",
                Genre = Genre.History
            };
            Book book3 = new Book()
            {
                Author = "Eli Eliev",
                Year = 2015,
                Title = "Kitab3",
                Genre = Genre.Drama
            };
            BookService bookservice = new();
            bookservice.AddBook(book1);
            bookservice.AddBook(book2);
            bookservice.AddBook(book3);

            // bookservice.SearchByGenre(Genre.Drama);

            //bookservice.Find();
            bookservice.SortByName();
        }
    }
}
