namespace Entities;

public class BankDetails
{
   public int Id { get; set; }
   public string AccountNumber { get; set; }
   public decimal Balance { get; set; }
   public DateTime DateOpened { get; set; }

   public BankDetails() {
      AccountNumber = string.Empty;
      Balance = 0;
      DateOpened = DateTime.Now;
   }
}

public class TransactionDTO
{
   public int Id { get; set; }
   public decimal Amount { get; set; }
   public string Action { get; set; }
} 