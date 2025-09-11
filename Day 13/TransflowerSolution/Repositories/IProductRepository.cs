namespace Repositories;
using Entities;

public interface IProductRepository
{
   //Crud operations interface
   void AddProduct(Product product);
   Product? GetProductById(int id);
   List<Product> GetAllProducts();
   void UpdateProduct(Product product);
   void DeleteProduct(int id);
}
