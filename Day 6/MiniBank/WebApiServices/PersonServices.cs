namespace WebApiServices;
using WebApiRepositories;
using WebApiEntities;

public class PersonServices
{

   // function to add person
   PersonRepository personRepository = new PersonRepository();
   
   public List<Person> GetAllPersons()
   {
      return personRepository.GetAllPersons();
   }
   public Person? GetPersonById(int id)
   {
      return personRepository.GetPersonById(id);
   }
   public Person AddPerson(PersonDTO personDTO)
   {
      Person person = new Person();
      person.Name = personDTO.Name;
      person.Age = personDTO.Age;
      person.Email = personDTO.Email;
      person.PhoneNumber = personDTO.PhoneNumber;
      // Auto generate sequential 4 digit Id
      person.Id = 1110 + personRepository.GetAllPersons().Count + 1;
      // Logic to generate numeric account number
      person.AccountNumber = (DateTime.Now.Ticks % 10000000000).ToString("D10");
      // Initial balance
      person.Balance = 0;
      person.DateOpened = DateTime.Now;
      return personRepository.AddPerson(person);
   }
   public void UpdatePerson(int id, Person updatedPerson)
   {
      personRepository.UpdatePerson(id, updatedPerson);
   }
}
