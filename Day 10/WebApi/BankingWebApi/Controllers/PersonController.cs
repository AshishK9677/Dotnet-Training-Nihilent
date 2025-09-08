using Microsoft.AspNetCore.Mvc;
using Services;
using Entities;
namespace BankingWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private PersonServices personService = new PersonServices();
    private TransactionServices transactionService = new TransactionServices();

    [HttpGet("/getAllPerson", Name = "GetAllPerson")]
    [Produces("application/json")] // automatic serialisation handled by ASP.NET Core
    public ActionResult<List<Person>> GetAllPerson()
    {
        List<Person> persons = personService.GetAllPersons();
        return Ok(persons);
    }

    //add person
    [HttpPost("/addPerson", Name = "AddPerson")]
    public ActionResult<Person> AddPerson(PersonDTO personDTO)
    {
        Person person = personService.AddPerson(personDTO);
        return Created($"/{person.Id}", person);
    }

    //update person
    [HttpPut("/updatePerson/{id}", Name = "UpdatePerson")]
    public ActionResult<Person> UpdatePerson(int id, PersonDTO updatedPersonDTO)
    {
        Person person = personService.UpdatePerson(id, updatedPersonDTO);
        return Ok(person);
    }

    //delete person
    [HttpDelete("/deletePerson/{id}", Name = "DeletePerson")]
    public ActionResult<Person> DeletePerson(int id)
    {
        Person person = personService.DeletePerson(id);
        return Ok(person);
    }

    //update balance
    [HttpPatch("/updateBalance", Name = "UpdateBalance")]
    public ActionResult<Person> UpdateBalance(TransactionDTO transactionDTO)
    {
        Person person = transactionService.updateBalance(transactionDTO.Id, transactionDTO.Amount, transactionDTO.Action);
        return Ok(person);
    }
}   
