namespace Services;
using Entities;

public interface IProductService
{
   void AddProduct(Product product);
   Product? GetProductById(int id);
   List<Product> GetAllProducts();
   void UpdateProduct(Product product);
   void DeleteProduct(int id);
}
