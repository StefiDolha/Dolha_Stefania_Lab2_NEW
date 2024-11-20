using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}