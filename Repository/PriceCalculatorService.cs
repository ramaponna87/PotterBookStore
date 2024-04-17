using PotterBookStore.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterBookStore.Repository
{
    public class PriceCalculatorService : IPriceCalculatorService
    {
        private const double SingleBookPrice = 8;
        private readonly IBookRepository _bookRepository;
        public PriceCalculatorService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public double CalculatePrice(IEnumerable<Book> basket)
        {
            double totalPrice = CalculateTotalPrice(basket);         
         
            return totalPrice;
        }

        private double CalculateTotalPrice(IEnumerable<Book> basket)
        {
            throw new NotImplementedException();
        }
    }
}
