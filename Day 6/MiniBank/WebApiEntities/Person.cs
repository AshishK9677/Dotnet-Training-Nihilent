namespace WebApiEntities;

public class Person : BankDetails
{
   public int Id { get; set; }
   public string Name { get; set; }
   public int Age { get; set; }
   public string Email { get; set; }
   public string PhoneNumber { get; set; }

   public Person() {
      Name = string.Empty;
      Age = 0;
      Email = string.Empty;
      PhoneNumber = string.Empty;
   }
}

public class BankDetails {
   public string AccountNumber { get; set; }
   public decimal Balance { get; set; }
   public DateTime DateOpened { get; set; }
   
   public BankDetails() {
      AccountNumber = string.Empty;
      Balance = 0;
      DateOpened = DateTime.Now;
   }
}

public class PersonDTO {
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
