using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj imię: ");
        string name = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Podaj nr telefonu: ");
        int phone_number = int.Parse(Console.ReadLine());

        AddToFile(name, surname, phone_number);
    }

    public static void AddToFile(string name, string surname, int phone_number)
    {
        using StreamWriter writer = new StreamWriter("dane.txt", append: true);

        writer.WriteLine($"imie: {name}, nazwisko: {surname}, nr_telefonu: {phone_number}");
        writer.Close();
    }

}
