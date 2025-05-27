using List.Tasks.Models;

namespace List.Tasks
{
    public class BookService
    {
        List<Book> books = new List<Book>();

        public bool AddBook(Book book)
        {
            var check = books.FirstOrDefault(x => x.Title == book.Title);
            if (check == null)
            {
                books.Add(book);
                return true;
            }
            throw new Exception("Bu adda kitab movcuddur");
        }

        public void SearchByGenre(Genre genre)
        {
            List<Book> searchedBooks = books.Where(x => x.Genre == genre).ToList();

            searchedBooks.ForEach(x => Console.WriteLine(x));
        }

        public void Find()
        {
            List<Book> old = books.OrderBy(x => x.Year).ToList();
            Console.WriteLine(old.First());
            Console.WriteLine(old.Last());
        }

        public void SortByName()
        {
            List<Book> sorted = books.OrderByDescending(x => x.Title).ToList();
            sorted.ForEach(Console.WriteLine);
        }
    }
}
