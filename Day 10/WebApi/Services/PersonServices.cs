namespace Services;
using Entities;
using Repositories;

public class PersonServices : IPersonServices
{
   //implementation of business logic for Person entity
   private readonly PersonRepository personRepository = new PersonRepository();
   
   public List<Person> GetAllPersons() {
      return personRepository.GetAllPersons().ToList();
   }
   public Person? GetPersonById(int id) {
      return personRepository.GetPersonById(id);
   }
   public Person AddPerson(PersonDTO personDTO) {
      Person person = new Person();
      person.Name = personDTO.Name;
      person.Age = personDTO.Age;
      person.Email = personDTO.Email;
      person.PhoneNumber = personDTO.PhoneNumber;
      // Auto generate sequential 4 digit Id
      person.Id = 1110 + personRepository.GetAllPersons().Count() + 1;
      // Logic to generate numeric account number
      person.AccountNumber = (DateTime.Now.Ticks % 10000000000).ToString("D10");
      // Initial balance
      person.Balance = 0;
      person.DateOpened = DateTime.Now;
      return personRepository.AddPerson(person);
   }
   public Person UpdatePerson(int id, PersonDTO updatedPersonDTO) {
      var existingPerson = personRepository.GetPersonById(id);
      if (existingPerson == null) {
         throw new Exception("Person not found");
      } else {
         existingPerson.Name = updatedPersonDTO.Name;
         existingPerson.Age = updatedPersonDTO.Age;
         existingPerson.Email = updatedPersonDTO.Email;
         existingPerson.PhoneNumber = updatedPersonDTO.PhoneNumber;
         return personRepository.UpdatePerson(existingPerson);
      }
   }
   public Person DeletePerson(int id) {
      var existingPerson = personRepository.GetPersonById(id);
      if (existingPerson == null) {
         throw new Exception("Person not found");
      } else {
         return personRepository.DeletePerson(existingPerson);
      }
   }
}
