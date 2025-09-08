namespace Entities;

public class Person : BankDetails 
{
   public int Id { get; set; }
   public string Name { get; set; }
   public int Age { get; set; }
   public string Email { get; set; }
   public string PhoneNumber { get; set; }

   public Person(): base() {
      Name = string.Empty;
      Age = 0;
      Email = string.Empty;
      PhoneNumber = string.Empty;
   }
}

public class PersonDTO
{
   public string Name { get; set; }
   public int Age { get; set; }
   public string Email { get; set; }
   public string PhoneNumber { get; set; }

   public PersonDTO() {
      Name = string.Empty;
      Age = 0;
      Email = string.Empty;
      PhoneNumber = string.Empty;
   }
}
