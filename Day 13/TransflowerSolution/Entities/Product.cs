namespace Entities;

public class Product
{
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public int Stock { get; set; }
      public string ImageUrl { get; set; }

      public Product() {
         Name = string.Empty;
         Price = 0;
         Stock = 0;
         ImageUrl = string.Empty;
      }
}
