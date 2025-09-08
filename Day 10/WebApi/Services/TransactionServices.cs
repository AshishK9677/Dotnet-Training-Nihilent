namespace Services;
using Entities;
using Repositories;

public class TransactionServices : ITransactionServices
{
   PersonServices personService = new PersonServices();
   TransactionRepository transactionRepository = new TransactionRepository();

   public Person updateBalance(int id, decimal amount, string action) 
   {
      Person person = personService.GetPersonById(id);
      if (person != null) {
         if (action == "add")
         {
            person.Balance += amount;
         }  
         else if (action == "deduct")
         {
            person.Balance -= amount;
         }
         return transactionRepository.updateBalance(person);
         }
      else {
         throw new Exception("Person not found");
      }
   }
}
