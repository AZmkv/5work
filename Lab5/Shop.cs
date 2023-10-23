namespace Lab5
{
    public class Shop : ISearchable
    {
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }

        public Shop()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
        }

        public void PlaceOrder(User user, Order order)
        {
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
        }

        public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
        {
            return Products.FindAll(p => p.Price >= minPrice && p.Price <= maxPrice);
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.FindAll(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> SearchByRating(int minRating)
        {
            return Products.FindAll(p => p.Rating >= minRating);
        }

        public void PrintAllProducts()
        {
            Console.WriteLine("All Products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}, Category: {product.Category}, Rating: {product.Rating}");
            }
        }

        public void PrintAllUsers()
        {
            Console.WriteLine("All Users:");
            foreach (var user in Users)
            {
                Console.WriteLine($"Username: {user.Username}");
            }
        }

        public void PrintAllOrders()
        {
            Console.WriteLine("All Orders:");
            foreach (var order in Orders)
            {
                Console.WriteLine($"Order Status: {order.Status}, Total Price: {order.TotalPrice:C}");
                for (int i = 0; i < order.Products.Count; i++)
                {
                    Console.WriteLine($"Product: {order.Products[i].Name}, Quantity: {order.Quantities[i]}, Price: {order.Products[i].Price:C}");
                }
                Console.WriteLine();
            }
        }
    }
}
