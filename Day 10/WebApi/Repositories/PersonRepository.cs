namespace Repositories;
using Entities;

public class PersonRepository : IPersonRepository
{
   //implementation of CRUD operations for Person entity
   private static List<Person> persons = new List<Person>();

   public IEnumerable<Person> GetAllPersons() {
      return persons;
   }
   public Person? GetPersonById(int id) {
      return persons.FirstOrDefault(p => p.Id == id);
   }
   public Person AddPerson(Person person) {
      persons.Add(person);
      return person;
   }
   public Person UpdatePerson(Person person) {
      var existingPerson = persons.FirstOrDefault(p => p.Id == person.Id);
      existingPerson = person;
      return existingPerson;
   }
   public Person DeletePerson(Person person) {
      persons.Remove(person);
      return person;
   }
}
