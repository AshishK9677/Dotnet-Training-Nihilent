namespace Repositories;
using Entities;

public interface IPersonRepository
{
   // CRUD operations for Person entity
   IEnumerable<Person> GetAllPersons();
   Person? GetPersonById(int id);
   Person AddPerson(Person person);
   Person UpdatePerson(Person person);
   Person DeletePerson(Person person);
}
