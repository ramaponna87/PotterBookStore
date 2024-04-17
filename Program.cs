using PotterBookStore.Repository.IRepository;
using PotterBookStore.Repository;
using PotterBookStore;

class Program
{
    static void Main(string[] args)
    {
        // Initialize repository and service
        IBookRepository bookRepository = new BookRepository();
        IPriceCalculatorService priceCalculatorService = new PriceCalculatorService(bookRepository);

        // Create books
        var book1 = new Book { Id = 1, Title = "Book 1", Price = 8.0 };
        var book2 = new Book { Id = 2, Title = "Book 2", Price = 8.0 };
        var book3 = new Book { Id = 3, Title = "Book 3", Price = 8.0 };
        var book4 = new Book { Id = 4, Title = "Book 4", Price = 8.0 };

        // Add books to the basket
        var basket = new List<Book> { book1, book2, book3, book4 };

        // Calculate total price
        double totalPrice = priceCalculatorService.CalculatePrice(basket);

        Console.WriteLine($"Total price: {totalPrice} EUR");
    }
}
