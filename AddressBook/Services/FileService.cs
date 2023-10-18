namespace AddressBook.Services;

public class FileService
{
    private static readonly string _filePath = @"C:\Users\Mr. M\Desktop\PersonalContactList\persons.json";


    public static void SaveToFile(string contentAsJson) // Sparas kvar i Json.
    {
        using StreamWriter sw = new StreamWriter(_filePath);
        sw.WriteLine(contentAsJson);
    }

    public static string ReadFromFile() // Visar/läser sparade kontakter.
    {
        if (File.Exists(_filePath))
        {
            using var sr = new StreamReader(_filePath);
            return sr.ReadToEnd();
        }

        return null!;

    }
}
