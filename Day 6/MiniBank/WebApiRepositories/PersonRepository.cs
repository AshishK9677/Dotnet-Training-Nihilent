namespace WebApiRepositories;
using WebApiEntities;

public class PersonRepository
{
      private static List<Person> persons = new List<Person>();
      public List<Person> GetAllPersons()
      {
         return persons;
      }
   
      public Person? GetPersonById(int id)
      {
          return persons.FirstOrDefault(p => p.Id == id);
      }
   
      public Person AddPerson(Person person)
      {
         persons.Add(person);
         return person;
      }
   
      public Person UpdatePerson(int id, Person updatedPerson)
      {
         var person = persons.FirstOrDefault(p => p.Id == id);
         if (person != null)
         {
            person = updatedPerson;
            return person;
         } else {
            Person emptyPerson = new Person();
            return emptyPerson;
         }
      }
   
      public void DeletePerson(int id)
      {
         var person = persons.FirstOrDefault(p => p.Id == id);
         if (person != null)
         {
               persons.Remove(person);
         }
      }
}
