using AddressBook.Models;
using AddressBook.Services;

namespace personService.Tests
{
    public class PersonServiceTests
    {
        [Fact]  
        public void AddPersonService_ShouldAddPersonItemSerivce_ReturnTrue()
        {
            PersonService _personService = new PersonService();
            Person person = new() { Id = Guid.NewGuid(), FirstName,"Mazen", LastName };


            bool result = _personService.AddPerson(person);

            Assert.True(result);

        }
    }
}