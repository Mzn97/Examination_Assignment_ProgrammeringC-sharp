namespace AddressBook.Services;

public class FileService
{
    private static readonly string _filePath = @"C:\Users\Mr. M\Desktop\PersonalContactList\persons.json";

    // Sparas kvar i Json.
    public static void SaveToFile(string contentAsJson) 
    {
        using StreamWriter sw = new StreamWriter(_filePath);
        sw.WriteLine(contentAsJson);
    }

    // Visar/läser sparade kontakter.
    public static string ReadFromFile() 
    {
        if (File.Exists(_filePath))
        {
            using var sr = new StreamReader(_filePath);
            return sr.ReadToEnd();
        }

        return null!;

    }
}
