namespace Services;
using Entities;

public interface IPersonServices
{
   List<Person> GetAllPersons();
   Person? GetPersonById(int id);
   Person AddPerson(PersonDTO personDTO);
   Person UpdatePerson(int id, PersonDTO updatedPersonDTO);
   Person DeletePerson(int id);
}
