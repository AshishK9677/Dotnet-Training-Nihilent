namespace Repositories;
using Entities;

public class TransactionRepository : ITransactionRepository
{
   private IPersonRepository personRepository = new PersonRepository();
   public Person updateBalance(Person person)
   { 
      return personRepository.UpdatePerson(person);
   }
}