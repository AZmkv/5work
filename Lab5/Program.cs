using Lab5;

class Program
{
    static void Main()
    {
        Shop shop = new Shop();

        // Add some products
        shop.AddProduct(new Product("Laptop", 1000.0, "High performance laptop", "Electronics", 5));
        shop.AddProduct(new Product("Headphones", 50.0, "Noise-cancelling headphones", "Electronics", 4));
        shop.AddProduct(new Product("Running Shoes", 80.0, "Lightweight running shoes", "Sports", 4));
        shop.AddProduct(new Product("Book", 20.0, "Bestseller novel", "Books", 4));

        // Register some users
        User user1 = new User("patrick", "star_stone");
        User user2 = new User("spange_bob", "pineapple");
        User user3 = new User("squidward", "my.favorite_clarinet");

        shop.RegisterUser(user1);
        shop.RegisterUser(user2);
        shop.RegisterUser(user3);

        // Create and place orders
        Order order1 = new Order();
        order1.AddProduct(shop.Products[0], 2);
        shop.PlaceOrder(user1, order1);

        Order order2 = new Order();
        order2.AddProduct(shop.Products[1], 1);
        order2.AddProduct(shop.Products[2], 3);
        shop.PlaceOrder(user2, order2);

        Order order3 = new Order();
        order3.AddProduct(shop.Products[3], 2); 
        shop.PlaceOrder(user3, order3);

        // Search for products
        List<Product> electronicsInRange = shop.SearchByPriceRange(40.0, 1200.0);
        List<Product> sportsProducts = shop.SearchByCategory("Sports");
        List<Product> highRatedProducts = shop.SearchByRating(4);

        // Print search results
        Console.WriteLine("Electronics in range $40 - $1200:");
        foreach (var product in electronicsInRange)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("\nSports products:");
        foreach (var product in sportsProducts)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("\nHigh rated products:");
        foreach (var product in highRatedProducts)
        {
            Console.WriteLine(product.Name);
        }
    }
}
