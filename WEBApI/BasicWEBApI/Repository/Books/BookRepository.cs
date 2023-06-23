using BasicWEBApI.Model;

namespace BasicWEBApI.Repository.Books
{
    public class BookRepository
    {
        public static List<Book> Books { get; set; } = new List<Book>()
        {
            new Book()
            {
                BookName = "book-1",
                ISBN = "323spb",
                 Author = "monir miya",
                  Id = 1,
            },
              new Book()
            {
                BookName = "book-2",
                ISBN = "323spb34",
                 Author = "jamal miya",
                  Id = 2,
            }
        };
    }
}
