using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterBookStore.Repository.IRepository
{
    // Interface for price calculator service
    public interface IPriceCalculatorService
    {
        double CalculatePrice(IEnumerable<Book> basket);
    }
}
