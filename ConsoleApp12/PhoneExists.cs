using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class PhoneExists
    {
       
        public static bool CheckPhone(Contact contact)
        {
            using StreamReader reader = new StreamReader("dane.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains($"{contact.PhoneNumber}"))
                {
                    return true;
                }
            }
            reader.Close();
            return false;
        }
        public static void UpdateContact(Contact contact)
        {
            Console.WriteLine("Podaj nowe imię: ");
            string updatedName = Console.ReadLine();
            Console.WriteLine("Podaj nowe nazwisko: ");
            string updatedSurname = Console.ReadLine();

            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader("dane.txt");
            string line;

            while ((line  = reader.ReadLine()) != null)
            {
                if (line.Contains($"{contact.PhoneNumber}"))
                {
                    line = $"{contact.PhoneNumber}-{updatedName} {updatedSurname}";
                }
                lines.Add(line);
            }
            reader.Close();

            using StreamWriter writer = new StreamWriter("dane.txt", append: false);
            foreach (var l in lines)
            {
                writer.WriteLine(l);
            }
        }
    }
}
