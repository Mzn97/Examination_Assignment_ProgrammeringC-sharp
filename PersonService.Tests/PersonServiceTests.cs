using AddressBook.Models;
using AddressBook.Services;

namespace personService.Tests;
public class PersonServiceTests
{
    [Fact]
    public void AddPersonService_ShouldAddPersonItemSerivce_ReturnTrue()
    {
        // Arrange
        PersonService _personService = new PersonService();
        Person person = new Person { FirstName = "Mazen", LastName = "Karim", Email = "mazen@domain.com" };

        // Act
        _personService.AddToList(person);

        // Assert
        var persons = _personService.GetAllPersons();
        var addedPerson = persons.FirstOrDefault(p => p.Email == "mazen@domain.com");

        Assert.NotNull(addedPerson);
        Assert.Equal("Mazen", addedPerson.FirstName);
    }
}