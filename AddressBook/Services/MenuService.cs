using AddressBook.Models;

namespace AddressBook.Services;

public class MenuService
{
    private static readonly PersonService personService = new PersonService(); 
    public static void AddPersonMenu() // Vad användaren ska fylla i.
    {
        Person person = new Person();
        Console.Write("Förnamn: ");
        person.FirstName = Console.ReadLine();
        Console.Write("Efternamn: ");
        person.LastName = Console.ReadLine();
        Console.Write("Telefonnummer: ");
        person.PhoneNumber = Console.ReadLine();
        Console.Write("E-postadress: ");
        person.Email = Console.ReadLine();



        person.Address = new Address();
        Console.Write("Gatunamn: ");
        person.Address.StreetName = Console.ReadLine();
        Console.Write("Gatunummer: ");
        person.Address.StreetNumber = Console.ReadLine();
        Console.Write("Postnummer: ");
        person.Address.PostalCode = Console.ReadLine();
        Console.Write("Stad/Ort: ");
        person.Address.City = Console.ReadLine();

        personService.AddToList(person);
        
    }

    public static void ViewAllPersonsMenu() 
    {
        foreach (var person in personService.GetAllPersons())
        {
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.PhoneNumber);
            Console.WriteLine(person.Email);
            Console.WriteLine(person.Address?.FullAddress);
            Console.WriteLine();
        }
    }

    public static void ViewOnePersonMenu() // Visar enstaka kontakt.
    {
        Console.Write("E-psotadress: ");
        var email = Console.ReadLine();

        var person = personService.GetOnePerson(email!);

        Console.WriteLine(person.FullName);
        Console.WriteLine(person.PhoneNumber);
        Console.WriteLine(person.Email);
        Console.WriteLine(person?.Address?.FullAddress);
        Console.WriteLine();
    }

    public static void RemoveOnePersonMenu() // Radera kontakt med hjälp av e-post.
    {
        Console.Write("E-postAdress: ");
        var email = Console.ReadLine();

        personService.RemovePerson(email!);
    }

    public static void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine(" Adressbok ");
            Console.WriteLine("1. Lägg till ny kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Sök efter specifik kontakt");
            Console.WriteLine("4. Radera en kontakt");
            Console.WriteLine("0. Stäng ner adressbok ");
            Console.Write("Vänligen välj ett alternativ från listan: ");
            var option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    AddPersonMenu();
                    break;

                case "2":
                    ViewAllPersonsMenu();
                    break;

                case "3":
                    ViewOnePersonMenu();
                    break;

                case "4":
                    RemoveOnePersonMenu();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

            }

            Console.ReadKey();

        } while (true);
    }
}
