using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Contact contact = ContactCollector.ContactDetails();

        FileHelper.AddToFile(contact);
    }
}
public class ContactCollector
{
    public static Contact ContactDetails()
    {
        Console.WriteLine("Podaj imię: ");
        string name = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Podaj nr telefonu: ");
        int phone_number = int.Parse(Console.ReadLine());

        return new Contact
        {
            Name = name,
            Surname = surname,
            PhoneNumber = phone_number
        };
    }
}
public class Contact
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int PhoneNumber { get; set; }
}
public class FileHelper
{
    public static void AddToFile(Contact contact)
    {
        using StreamWriter writer = new StreamWriter("dane.txt", append: true);

        writer.WriteLine($"imie: {contact.Name}, nazwisko: {contact.Surname}, nr_telefonu: {contact.PhoneNumber}");
        writer.Close();
    }
}
