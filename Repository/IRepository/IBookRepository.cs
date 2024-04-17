using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterBookStore.Repository.IRepository
{
    //Interface for the book repository
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
    }
}
