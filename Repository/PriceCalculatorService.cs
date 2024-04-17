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
            totalPrice -= discount;
            return totalPrice;
        }

        // Method to calculate the discount based on the number of distinct books
        private double CalculateDiscount(IEnumerable<Book> basket)
        {
            var distinctBooksCount = basket.Distinct().Count();
            var totalPrice = CalculateTotalPrice(basket);
            double discount = 0;

            switch (distinctBooksCount)
            {
                case 2:
                    discount = totalPrice * 0.05;
                    break;
                case 3:
                    discount = totalPrice * 0.10;
                    break;
                case 4:
                    discount = CalculateFourBooksDiscount(basket);
                    break;
                case 5:
                    discount = totalPrice * 0.25;
                    break;
                default:
                    break;
            }

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

        // Method to calculate discount for four books with three distinct titles
        private double CalculateFourBooksDiscount(IEnumerable<Book> basket)
        {
            var distinctBookTitlesCount = basket.Select(b => b.Title).Distinct().Count();
            var totalCount = basket.Count();
            var regularPrice = basket.First().Price;

            double discount = 0;

            if (distinctBookTitlesCount == 3 && totalCount == 4)
            {
                // 10% discount on the 3 different titles, 4th book remains at regular price
                discount = regularPrice * 3 * 0.10;
            }
            else
            {
                // 20% discount on all 4 different titles
                discount = regularPrice * 4 * 0.20;
            }

            return discount;
        }
    }
}
