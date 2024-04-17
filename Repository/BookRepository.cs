using PotterBookStore.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterBookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;
        public BookRepository()
        {
            // Initialize with sample book data
            _books = new List<Book>
        {
            new Book { Id = 1, Title = "Book 1", Price = 8 },
            new Book { Id = 2, Title = "Book 2", Price = 8 },
            new Book { Id = 3, Title = "Book 3", Price = 8 },
            new Book { Id = 4, Title = "Book 4", Price = 8 },
            new Book { Id = 5, Title = "Book 5", Price = 8 }
        };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
    }
}
