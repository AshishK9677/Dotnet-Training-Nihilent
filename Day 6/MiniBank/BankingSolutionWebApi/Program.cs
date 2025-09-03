using WebApiServices;
using WebApiEntities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

PersonServices personService = new PersonServices();

app.MapGet("/home", () => {
    return "Hello World!";
});

app.MapGet("/api/person/getAllPerson", () =>
{
   return Results.Ok(personService.GetAllPersons());
});

app.MapPost("/api/person/addPerson", (PersonDTO personDTO) =>
{
    Person person = personService.AddPerson(personDTO);
    return Results.Created($"/api/person/{person.Id}", person);
});

app.Run();
