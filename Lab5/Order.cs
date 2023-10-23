namespace Lab5
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }

        public Order()
        {
            Products = new List<Product>();
            Quantities = new List<int>();
            TotalPrice = 0.0;
            Status = "Pending";
        }

        public void AddProduct(Product product, int quantity)
        {
            Products.Add(product);
            Quantities.Add(quantity);
            TotalPrice += product.Price * quantity;
        }
    }
}
