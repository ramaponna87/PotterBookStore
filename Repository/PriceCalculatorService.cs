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
            double discount = CalculateDiscount(basket);
            return totalPrice;
        }

        // Method to calculate the discount based on the number of distinct books
        private double CalculateDiscount(IEnumerable<Book> basket)
        {
            var distinctBooksCount = basket.Distinct().Count();
            var totalPrice = CalculateTotalPrice(basket);
            double discount = 0;

            return discount;
        }

        // Method to calculate the total price of the books
        private double CalculateTotalPrice(IEnumerable<Book> basket)
        {
            double totalPrice = 0;
            foreach (var book in basket)
            {
                totalPrice += book.Price;
            }
            return totalPrice;
        }
    }
}
