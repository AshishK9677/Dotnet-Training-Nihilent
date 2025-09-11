namespace Repositories;
using Entities;

public class ProductRepository : IProductRepository
{
   private List<Product> products = JSONCatalogManager.LoadProducts().ToList();

   public void AddProduct(Product product)
   {
      products.Add(product);
      JSONCatalogManager.SaveProducts(products);
   }

   public Product? GetProductById(int id)
   {
      return products.FirstOrDefault(p => p.Id == id);
   }

   public List<Product> GetAllProducts()
   {
      return products;
   }

   public void UpdateProduct(Product product)
   {
      var existingProduct = GetProductById(product.Id);
      if (existingProduct != null)
      {
         existingProduct.Name = product.Name;
         existingProduct.Price = product.Price;
         existingProduct.Stock = product.Stock;
         existingProduct.ImageUrl = product.ImageUrl;
         JSONCatalogManager.SaveProducts(products);
      }
   }

   public void DeleteProduct(int id)
   {
      var product = GetProductById(id);
      if (product != null)
      {
         products.Remove(product);
         JSONCatalogManager.SaveProducts(products);
      }
   }
}
