using SepiStore.Models;

namespace SepiStore.Services
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product.Price<=0)
            {
                throw new Exception("....");
            }
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
