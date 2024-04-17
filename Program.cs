using PotterBookStore.Repository.IRepository;
using PotterBookStore.Repository;

class Program
{
    static void Main(string[] args)
    {
        // Initialize repository and service
        IBookRepository bookRepository = new BookRepository();
        IPriceCalculatorService priceCalculatorService = new PriceCalculatorService(bookRepository);

        Console.WriteLine("Hello!!");
    }
}
