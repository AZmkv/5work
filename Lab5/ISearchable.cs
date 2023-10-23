namespace Lab5
{
    public interface ISearchable
    {
        List<Product> SearchByPriceRange(double minPrice, double maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int minRating);
    }
}
