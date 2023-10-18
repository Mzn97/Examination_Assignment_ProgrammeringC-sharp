using AddressBook.Models;
using Newtonsoft.Json;

namespace AddressBook.Services;

public class PersonService
{
    private List<Person> _persons = new List<Person>(); 

    public void AddToList(Person person)
    {
        _persons.Add(person);

        FileService.SaveToFile(JsonConvert.SerializeObject(_persons)); // Sparar kontakter i fil.
    }
    public IEnumerable<Person> GetAllPersons()
    {
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _persons = JsonConvert.DeserializeObject<List<Person>>(content)!;

        return _persons;
    }

    public Person GetOnePerson(String email)
    {
        return _persons.FirstOrDefault(x => x.Email == email)!; // Raderar en kontakt genom E-mail.
    }

    public void RemovePerson(string email)
    {
        var person = GetOnePerson(email);
        _persons.Remove(person);

        FileService.SaveToFile(JsonConvert.SerializeObject(_persons)); // Uppdaterar min Json.
    }
}

